using Microsoft.Extensions.DependencyInjection;
using ScreenMelder.Lib.ChangeDetection.Services;
using ScreenMelder.Lib.CommunicationsProxy;
using ScreenMelder.Lib.Core.Services;
using ScreenMelder.Lib.OCR.Services;
using ScreenMelder.Lib.ScreenCapture;
using ScreenMelder.Lib.ScreenCapture.Models;
using ScreenMelder.Lib.ScreenCapture.Services;
using ScreenMelder.Lib.ScreenCapture.Services.CaptureTarget;
using ScreenMelder.Models;
using System;

namespace ScreenMelder
{
    public partial class ScreenMelder : Form
    {
        private readonly ServiceProvider _ServiceProvider;
        private readonly ScreenCaptureFactory _screenCaptureFactory;
        private readonly CaptureTargetContext _captureTargetStrategy;
        private readonly IConfigurationService _configurationService;
        private IOcrChangeDetectionService _ocrChangeDetectionService;
        private CommunicationProxy _communications;
        public ScreenMelder(ServiceProvider ServiceProvider)
        {
            _ServiceProvider = ServiceProvider;
            _configurationService = _ServiceProvider.GetRequiredService<IConfigurationService>();
            _screenCaptureFactory = new ScreenCaptureFactory(_ServiceProvider.GetRequiredService<IScreenCaptureService>());
            _captureTargetStrategy = new CaptureTargetContext();
            InitializeComponent();
            ocrROIOptions.Items.Add(new CaptureTypeOption { Label = "Screen", Value = CaptureType.SCREEN });
            // ocrROIOptions.Items.Add(new CaptureTypeOption { Label = "Application", Value = CaptureType.APPLICATION });
            ocrROIOptions.SelectedIndex = 0;
            LoadCaptureTargets();
        }

        private void LoadCaptureTargets()
        {
            CaptureTypeOption selectedItem = (CaptureTypeOption)this.ocrROIOptions.SelectedItem;
            ocrROICaptureTargetOptions.Items.Clear();
            foreach (var target in _captureTargetStrategy.GetTargets(selectedItem.Value) ?? new List<string>())
            {
                ocrROICaptureTargetOptions.Items.Add(target);
            }

            ocrROICaptureTargetOptions.SelectedIndex = 0;
        }

        private void launch_roi_picker_button_Click(object sender, EventArgs e)
        {
            CaptureTypeOption selectedItem = (CaptureTypeOption)this.ocrROIOptions.SelectedItem;
            var captureName = this.ocrROICaptureTargetOptions.SelectedItem.ToString();

            var captureService = _screenCaptureFactory.GetCapture(selectedItem.Value, captureName);
            using (var dialog = new ScreenRoiPicker(_configurationService, captureService))
            {
                dialog.ShowDialog();
                this.Invalidate();
            }
        }

        private void ocrROIOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCaptureTargets();
        }

        private void host_connect_button_Click(object sender, EventArgs e)
        {
            ConnectCommunications();
        }

        private void ConnectCommunications()
        {
            if (_communications == null)
            {
                Uri commsUri = new Uri($"tcp://{host_input.Text}:{port_input.Text}");
                _communications = CreateCommunications();
            }

            if (!_communications.IsConnected)
            {
                _communications.Connect();
            }
        }

        private CommunicationProxy CreateCommunications()
        {
            Uri commsUri = new Uri($"tcp://{host_input.Text}:{port_input.Text}");
            return new CommunicationProxy(commsUri);
        }

        private void ocrStartButton_Click(object sender, EventArgs e)
        {
            stopOcrButton.Enabled = true;
            stopOcrButton.ForeColor = Color.Black;
            ocrStartButton.Enabled = false;
            ocrStartButton.ForeColor = Color.Green;

            ConnectCommunications();
            _ocrChangeDetectionService = new OcrChangeDetectionService(_screenCaptureFactory,
                                                                        _ServiceProvider.GetRequiredService<IOcrService>(),
                                                                        _configurationService,
                                                                        _ServiceProvider.GetRequiredService<IChangeDetectionService>(),
                                                                        _ServiceProvider.GetRequiredService<IPayloadService>(),
                                                                        _communications);


            _ocrChangeDetectionService.Start(BuildPath(configPath.Text), BuildPath(configPath.Text), BuildPath(overlayOutputPath.Text), int.Parse(pollingPeriod.Value.ToString()));
        }

        private string BuildPath(string path)
        {
            if (path.StartsWith('/'))
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                return Path.Combine(baseDirectory, "path");
            }
            return path;
        }

        private void stopOcrButton_Click(object sender, EventArgs e)
        {
            stopOcrButton.Enabled = false;
            stopOcrButton.ForeColor = Color.Red;
            ocrStartButton.Enabled = true;
            ocrStartButton.ForeColor = Color.Black;
            _ocrChangeDetectionService.Stop();
        }
    }
}