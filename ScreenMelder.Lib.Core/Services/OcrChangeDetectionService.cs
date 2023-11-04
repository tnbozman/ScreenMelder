using Microsoft.Extensions.Logging;
using ScreenMelder.Lib.ChangeDetection.Services;
using ScreenMelder.Lib.CommunicationsProxy;
using ScreenMelder.Lib.Core.Models;
using ScreenMelder.Lib.Core.Util;
using ScreenMelder.Lib.OCR.Services;
using ScreenMelder.Lib.ScreenCapture;
using ScreenMelder.Lib.ScreenCapture.Models;
using ScreenMelder.Lib.ScreenCapture.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Services
{
    public class OcrChangeDetectionService : IOcrChangeDetectionService
    {
        private readonly ScreenCaptureFactory _captureFactory;
        private readonly IOcrService _ocrService;
        private readonly IConfigurationService _configService;
        private readonly IChangeDetectionService _changeDetectionService;
        private readonly IPayloadService _payloadService;
        private readonly CommunicationProxy _commsProxy;
        private readonly ILogger<OcrChangeDetectionService> _logger;
        private bool running = false;
        private Thread captureThread;
        private Config? config;
        private string templatePath;
        private string overlayOutputPath;
        private string captureCountLabel;
        private int period;
        private ICaptureService captureService;

        public OcrChangeDetectionService(ScreenCaptureFactory captureFactory, 
                                            IOcrService ocrService, 
                                            IConfigurationService configService, 
                                            IChangeDetectionService changeDetectionService,
                                            IPayloadService payloadService,
                                            CommunicationProxy commsProxy,
                                            ILogger<OcrChangeDetectionService> logger) {
            _captureFactory = captureFactory;
            _ocrService = ocrService;
            _configService = configService;
            _changeDetectionService = changeDetectionService;
            _payloadService = payloadService;
            _commsProxy = commsProxy;
            _logger = logger;
        }
        public bool Start(string configPath, string templatePath, string overlayOutputPath, int period, string captureCountLabel)
        {
            var result = false;
            config = _configService.ReadConfig(configPath);
            if(config == null)
            {
                _logger.LogError("Failed to read configuations. Start aborted");
                return result;
            }
            this.templatePath = templatePath;
            this.overlayOutputPath = overlayOutputPath;
            this.period = period;
            this.captureCountLabel = captureCountLabel;
            // TODO: support application
            captureService = _captureFactory.GetCapture(CaptureType.SCREEN, config.CaptureName);
            if (overlayOutputPath != null)
            {
                SaveImageWithRegions(captureService, overlayOutputPath, config.Regions, config.Trigger);
            }

            captureThread = new Thread(Process);
            captureThread.IsBackground = true;
            captureThread.Start();
            return true;
        }

        private void Process(object input)
        {
            Bitmap previousTrigger = null;
            string previousPayload = null;
            int counter = 1;
            running = true;
            while (running)
            {
                var triggerCapture = captureService.CaptureRegion(new Rectangle(config.Trigger.X, config.Trigger.Y, config.Trigger.Width, config.Trigger.Height));

                if (_changeDetectionService.HasChanged(triggerCapture, ref previousTrigger))
                {
                    _logger.LogInformation("Screen Change Detected");
                    var ocrValues = new Dictionary<string, object>();
                    foreach (var region in config.Regions)
                    {
                        var regionCapture = captureService.CaptureRegion(new Rectangle(region.X, region.Y, region.Width, region.Height));
                        var result = _ocrService.ProcessImage(regionCapture);
                        object parsedResult = null;
                        if(region.DataType != null)
                        {
                            result = result.Replace("\n", "").TrimEnd();
                            parsedResult = DataTypeParser.Validate(result, region.DataType);
                        }

                        _logger.LogInformation($"{region.Label}: {parsedResult}");
                        ocrValues.Add(region.Label, parsedResult);
                    }
                    
                    if(ocrValues.All(a => a.Value != null && a.Value.ToString().Length > 0))
                    {
                        _logger.LogInformation("All OCR reads successful");

                        // need to pull counter into a new payload service function that can be used by itself
                        ocrValues.Add(captureCountLabel, counter);
                        var payload = _payloadService.PopulateTemplateWithRegions(templatePath, config.Regions, ocrValues);
                        // ignore duplicate reads
                        if(previousPayload != payload) {
                            // add counter if specified by the ui
                            if (!string.IsNullOrEmpty(captureCountLabel))
                            {
                                payload = _payloadService.AddCounterToTemplate(captureCountLabel, counter);
                            }
                            _commsProxy.SendJson(payload);
                            counter++;
                            previousPayload = payload;
                        }
                        
                    } 
                }

                Thread.Sleep(period);
            }
        }

        private void SaveImageWithRegions(ICaptureService captureService, string path, List<RoiConfig> regions, RoiConfig trigger)
        {
            Bitmap screenshot = captureService.Capture();
            DrawRegionsOnBitmap(screenshot, regions, trigger);
            screenshot.Save(path, ImageFormat.Png);
        }

        private void DrawRegionsOnBitmap(Bitmap bitmap, List<RoiConfig> regions, RoiConfig trigger)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                foreach (var region in regions)
                {
                    g.DrawRectangle(Pens.Green, region.X, region.Y, region.Width, region.Height);
                    g.DrawString(region.Label, SystemFonts.DefaultFont, Brushes.Green, region.X, region.Y - 20);
                }

                g.DrawRectangle(Pens.Yellow, trigger.X, trigger.Y, trigger.Width, trigger.Height);
                g.DrawString("Trigger", SystemFonts.DefaultFont, Brushes.Yellow, trigger.X, trigger.Y - 20);
            }
        }



        public void Stop()
        {
            running = false;
        }
    }
}
