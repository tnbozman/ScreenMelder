using ScreenMelder.Lib.ScreenCapture.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenMelder.Lib.ScreenCapture
{
    public class FullScreenCapture: ICaptureService
    {
        
        private readonly IScreenCaptureService _service;
        public FullScreenCapture(IScreenCaptureService captureService)
        {
            _service = captureService;
        }
        

        public Bitmap Capture(string name)
        {
            int screenId;
            if(!int.TryParse(name, out screenId))
            {
                screenId = 0;
            }
            Rectangle screenBounds = Screen.AllScreens[screenId].Bounds;
            Bitmap screenshot = new Bitmap(screenBounds.Width, screenBounds.Height);
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, screenBounds.Size);
            }
            return screenshot;
        }

    }
}
