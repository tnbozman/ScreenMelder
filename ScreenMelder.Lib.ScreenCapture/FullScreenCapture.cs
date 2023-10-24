using ScreenMelder.Lib.ScreenCapture.Models;
using ScreenMelder.Lib.ScreenCapture.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ScreenMelder.Lib.ScreenCapture
{
    public class FullScreenCapture: ICaptureService
    {
        public CaptureType CaptureType => CaptureType.SCREEN;
        public int ScreenId { get; set; }   
        public CaptureType Type { get; set; }
        public string Name { get; set; }

        private readonly IScreenCaptureService _service;
        public FullScreenCapture(IScreenCaptureService captureService, string captureName)
        {
            _service = captureService;
            Name = captureName;
            int screenId;
            if (!int.TryParse(captureName, out screenId))
            {
                screenId = 0;
            }
            ScreenId = screenId;
        }
        

        public Bitmap Capture()
        {
            
            Rectangle screenBounds = Screen.AllScreens[ScreenId].Bounds;
            return _service.Capture(Point.Empty, Point.Empty, screenBounds.Size);
        }

    }
}
