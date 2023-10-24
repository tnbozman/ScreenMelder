using ScreenMelder.Lib.ScreenCapture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.ScreenCapture
{
    public interface ICaptureService
    {
        CaptureType CaptureType { get; }
        string Name { get; set; }
        Bitmap Capture();

        Bitmap CaptureRegion(Rectangle region);
    }
}
