using Microsoft.Extensions.DependencyInjection;
using ScreenMelder.Lib.CommunicationsProxy;
using ScreenMelder.Lib.Core.Services;
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
        private CommunicationProxy _communications;
        public ScreenMelder(ServiceProvider ServiceProvider)
        {
            _ServiceProvider = ServiceProvider;
            _screenCaptureFactory = new ScreenCaptureFactory(_ServiceProvider.GetRequiredService<IScreenCaptureService>());
            _captureTargetStrategy = new CaptureTargetContext();
            InitializeComponent();
            ocrROIOptions.Items.Add(new CaptureTypeOption { Label = "Screen", Value = CaptureType.SCREEN });
            ocrROIOptions.Items.Add(new CaptureTypeOption { Label = "Application", Value = CaptureType.APPLICATION });
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
            using (var dialog = new ScreenRoiPicker(_ServiceProvider.GetRequiredService<IConfigurationService>(), captureService))
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
            if (_communications == null)
            {
                Uri commsUri = new Uri($"tcp://{host_input.Text}:{port_input.Text}");
                _communications = new CommunicationProxy(commsUri);
            }
        }
    }
}