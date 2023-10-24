using ScreenMelder.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Utils
{
    public class RoiUtil
    {
        public static RoiConfig CreateRegion(Point point, MouseEventArgs e)
        {
            return new RoiConfig
            {
                X = point.X,
                Y = point.Y,
                Width = e.X - point.X,
                Height = e.Y - point.Y
            };
        }

        public static RoiConfig UpdateRegion(RoiConfig region, Point point, MouseEventArgs e)
        {
            if (region == null)
            {
                return CreateRegion(point, e);
            }
            region.Width = e.X - point.X;
            region.Height = e.Y - point.Y;
            return region;
        }
    }
}
