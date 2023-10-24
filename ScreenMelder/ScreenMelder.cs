using Microsoft.Extensions.DependencyInjection;
using ScreenMelder.Lib.Core.Services;
using ScreenMelder.Lib.ScreenCapture;
using ScreenMelder.Lib.ScreenCapture.Models;
using ScreenMelder.Lib.ScreenCapture.Services;
using ScreenMelder.Models;
using System;

namespace ScreenMelder
{
    public partial class ScreenMelder : Form
    {
        private readonly ServiceProvider _ServiceProvider;
        private readonly ScreenCaptureFactory _screenCaptureFactory;
        public ScreenMelder(ServiceProvider ServiceProvider)
        {
            _ServiceProvider = ServiceProvider;
            _screenCaptureFactory = new ScreenCaptureFactory(_ServiceProvider.GetRequiredService<IScreenCaptureService>());
            InitializeComponent();
            ocrROIOptions.Items.Add(new CaptureTypeOption { Label = "Application", Value = CaptureType.APPLICATION });
            ocrROIOptions.Items.Add(new CaptureTypeOption { Label = "Screen", Value = CaptureType.SCREEN });
            ocrROIOptions.SelectedIndex = 0;
        }

        private void launch_roi_picker_button_Click(object sender, EventArgs e)
        {
            CaptureTypeOption selectedItem = (CaptureTypeOption)this.ocrROIOptions.SelectedItem;
            var captureName = this.ocrROIName.Text;
           
            var captureService = _screenCaptureFactory.GetCapture(selectedItem.Value, captureName);
            using (var dialog = new ScreenRoiPicker(_ServiceProvider.GetRequiredService<IConfigurationService>(), captureService))
            {
                dialog.ShowDialog();
                this.Invalidate();
            }
        }

    }
}