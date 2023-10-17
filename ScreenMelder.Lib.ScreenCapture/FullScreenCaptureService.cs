using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenMelder.Lib.ScreenCapture
{
    public class FullScreenCaptureService: IScreenCaptureService
    {
        Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
        Bitmap screenshot = new Bitmap(screenBounds.Width, screenBounds.Height);

        public Bitmap Capture()
        {
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, screenBounds.Size);
            }
            return screenshot;
        }

    }
}
