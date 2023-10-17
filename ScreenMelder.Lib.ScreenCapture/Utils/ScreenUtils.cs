using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.ScreenCapture.Utils
{
    public class ScreenUtils
    {
        public static int GetWidth(Point upperLeftSource, Point upperLeftDestination)
        {
            return (upperLeftDestination.X - upperLeftSource.X);
        }
        public static int GetHeight(Point upperLeftSource, Point upperLeftDestination)
        {
            return (upperLeftDestination.Y - upperLeftSource.Y);
        }
    }
}
