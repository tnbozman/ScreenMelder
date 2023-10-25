using ScreenMelder.Lib.ChangeDetection.Services;
using ScreenMelder.Lib.CommunicationsProxy;
using ScreenMelder.Lib.Core.Models;
using ScreenMelder.Lib.OCR.Services;
using ScreenMelder.Lib.ScreenCapture;
using ScreenMelder.Lib.ScreenCapture.Models;
using ScreenMelder.Lib.ScreenCapture.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
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
        private bool running = false;
        public OcrChangeDetectionService(ScreenCaptureFactory captureFactory, 
                                            IOcrService ocrService, 
                                            IConfigurationService configService, 
                                            IChangeDetectionService changeDetectionService,
                                            IPayloadService payloadService,
                                            CommunicationProxy commsProxy) {
            _captureFactory = captureFactory;
            _ocrService = ocrService;
            _configService = configService;
            _changeDetectionService = changeDetectionService;
            _payloadService = payloadService;
            _commsProxy = commsProxy;
        }
        public void Start(string configPath, string templatePath, string overlayOutputPath, int period)
        {
            var config = _configService.ReadConfig(configPath);
            // TODO: support application
            var captureService = _captureFactory.GetCapture(CaptureType.SCREEN, config.CaptureName);
            if (overlayOutputPath != null)
            {
                SaveImageWithRegions(captureService, overlayOutputPath, config.Regions, config.Trigger);
            }

            Bitmap previousTrigger = null;
            running = true;
            while (running)
            {
                var triggerCapture = captureService.CaptureRegion(new Rectangle(config.Trigger.X, config.Trigger.Y, config.Trigger.Width, config.Trigger.Height));

                if (_changeDetectionService.HasChanged(triggerCapture, ref previousTrigger))
                {
                    var ocrValues = new Dictionary<string, string>();
                    foreach (var region in config.Regions)
                    {
                        var regionCapture = captureService.CaptureRegion(new Rectangle(region.X, region.Y, region.Width, region.Height));
                        var result = _ocrService.ProcessImage(regionCapture);
                        Console.WriteLine($"{region.Label}: {result}");
                        ocrValues.Add(region.Label, result);
                    }
                    var payload = _payloadService.PopulateTemplateWithRegions(templatePath, config.Regions, ocrValues);
                    _commsProxy.SendJson(payload);
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
