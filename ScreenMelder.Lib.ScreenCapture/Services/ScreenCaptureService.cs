﻿using ScreenMelder.Lib.ScreenCapture.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.ScreenCapture.Services
{
    public class ScreenCaptureService : IScreenCaptureService
    {

        public Bitmap Capture(Point upperLeftSource, Point lowerRightDestination, Size blockRegionSize)
        {
            var width = ScreenUtils.GetWidth(upperLeftSource, lowerRightDestination);
            var height = ScreenUtils.GetHeight(upperLeftSource, lowerRightDestination);
            var bmp = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.CopyFromScreen(upperLeftSource.X, upperLeftSource.Y, 0, 0, bmp.Size);
            }
            return bmp;
        }
    }
}
