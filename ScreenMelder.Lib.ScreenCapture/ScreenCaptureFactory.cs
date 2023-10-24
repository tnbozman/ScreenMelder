using ScreenMelder.Lib.ScreenCapture.Models;
using ScreenMelder.Lib.ScreenCapture.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.ScreenCapture
{
    public class ScreenCaptureFactory
    {
        private readonly IScreenCaptureService _screenCaptureService;

        public ScreenCaptureFactory(IScreenCaptureService screenCaptureService) {
            _screenCaptureService = screenCaptureService;
        }
        public ICaptureService GetCapture(CaptureType type, string captureName)
        {
            switch (type)
            {
                case CaptureType.SCREEN:
                    return new FullScreenCapture(_screenCaptureService, captureName);
                case CaptureType.APPLICATION:
                    return new ApplicationCapture(_screenCaptureService, captureName);
                default:
                    return null;
            }
        }
    }
}
