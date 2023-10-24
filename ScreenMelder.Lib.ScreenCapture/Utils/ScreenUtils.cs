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
        public static int GetWidth(Point upperLeftSource, Point lowerRightDestination)
        {
            return (lowerRightDestination.X - upperLeftSource.X);
        }
        public static int GetHeight(Point upperLeftSource, Point lowerRightDestination)
        {
            return (lowerRightDestination.Y - upperLeftSource.Y);
        }
    }
}
