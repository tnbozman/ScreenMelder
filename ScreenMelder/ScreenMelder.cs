using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
using System.Security.Policy;
using System.Text.Json;

namespace ScreenMelder
{
    public partial class ScreenMelder : Form
    {
        private readonly ServiceProvider _ServiceProvider;
        private readonly ScreenCaptureFactory _screenCaptureFactory;
        private readonly CaptureTargetContext _captureTargetStrategy;
        private readonly IConfigurationService _configurationService;
        private readonly IPayloadService _payloadService;
        private IOcrChangeDetectionService _ocrChangeDetectionService;
        private CommunicationProxy _communications;
        private readonly ILogger<ScreenMelder> _logger;
        private TextBox logTextBox;
        private string configPath;
        private string payloadPath;
        private string overlayPath;

        public ScreenMelder(ServiceProvider ServiceProvider, ILogger<ScreenMelder> logger, TextBox logTextBox)
        {
            _ServiceProvider = ServiceProvider;
            _configurationService = _ServiceProvider.GetRequiredService<IConfigurationService>();
            _payloadService = _ServiceProvider.GetRequiredService<IPayloadService>();
            _screenCaptureFactory = new ScreenCaptureFactory(_ServiceProvider.GetRequiredService<IScreenCaptureService>());
            _captureTargetStrategy = new CaptureTargetContext();
            _logger = logger;
            configPath = BuildPath(Properties.Settings.Default.configPath);
            payloadPath = BuildPath(Properties.Settings.Default.payloadPath);
            overlayPath = BuildPath(Properties.Settings.Default.overlayPath);


            InitializeComponent();

            payloadTextBox.Text = _payloadService.Load(payloadPath);
            configTextBox.Text = _configurationService.ReadConfigToString(configPath);

            // 
            // logTextBox
            // 
            logTab.Controls.Add(logTextBox);
            this.logTextBox = logTextBox;
            this.logTextBox.Location = new Point(6, 5);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new Size(527, 364);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.ScrollBars = ScrollBars.Vertical;
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
                _communications = CreateCommunications();
            }

            if (!_communications.IsConnected)
            {
                _communications.Connect();
                _communications.SetCleanupRegex(string.IsNullOrEmpty(ocrPayloadRegex.Text) ? null : ocrPayloadRegex.Text);
                host_connect_button.Enabled = !_communications.IsConnected;
                host_disconnect_button.Enabled = !host_connect_button.Enabled;

                if (_communications.IsConnected)
                {
                    _logger.LogInformation($"Connected");
                }
                else
                {
                    _logger.LogInformation($"Failed to connect");
                }

            }
        }

        private string BuildUriString(string protocol, string host, string port)
        {
            return $"{protocol}://{host}:{port}";
        }

        private CommunicationProxy CreateCommunications()
        {
            var uri = BuildUriString("tcp", host_input.Text, port_input.Text);
            _logger.LogInformation($"Attempting to connect to {uri}");
            Uri commsUri = new Uri(uri);
            return new CommunicationProxy(commsUri, _ServiceProvider.GetRequiredService<ILogger<CommunicationProxy>>());
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
                                                                        _payloadService,
                                                                        _communications,
                                                                        _ServiceProvider.GetRequiredService<ILogger<OcrChangeDetectionService>>());
            _logger.LogInformation($"Starting OCR Change Detection");
            var result = _ocrChangeDetectionService.Start(configPath, payloadPath, overlayOutputEnable.Checked ? overlayPath : null, int.Parse(pollingPeriod.Value.ToString()), captureCount.Text);

            if (!result)
            {
                stopOcrButton_Click(null, null);
            }

        }

        private string BuildPath(string path)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
        }

        private void stopOcrButton_Click(object sender, EventArgs e)
        {
            stopOcrButton.Enabled = false;
            stopOcrButton.ForeColor = Color.Red;
            ocrStartButton.Enabled = true;
            ocrStartButton.ForeColor = Color.Black;
            _ocrChangeDetectionService.Stop();
            _logger.LogInformation($"Stopping OCR Change Detection");
        }

        private void manual_send_button_Click(object sender, EventArgs e)
        {
            _logger.LogInformation($"Manually sending payload");
            _communications.SendJson(manual_textBox.Text);
        }

        private void host_disconnect_button_Click(object sender, EventArgs e)
        {
            _logger.LogInformation($"Communications Disconnecting");
            _communications.Disconnect();
            host_connect_button.Enabled = true;
            host_disconnect_button.Enabled = false;
        }
        private void ocrPayloadRegex_TextChanged(object sender, EventArgs e)
        {
            if (_communications != null)
            {
                _communications.SetCleanupRegex(ocrPayloadRegex.Text);
            }
        }

        private void configEditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            configTextBox.Enabled = configEditCheckBox.Checked;
            configSaveButton.Enabled = configEditCheckBox.Checked;
        }

        private void payloadEditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            payloadTextBox.Enabled = payloadEditCheckBox.Checked;
            payloadSaveButton.Enabled = payloadEditCheckBox.Checked;
        }

        private void configSaveButton_Click(object sender, EventArgs e)
        {
            _configurationService.SaveConfigFromString(configTextBox.Text, configPath);
        }

        private void payloadSaveButton_Click(object sender, EventArgs e)
        {
            _payloadService.Save(payloadPath, payloadTextBox.Text);
        }
    }
}