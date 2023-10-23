using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.ScreenCapture
{
    public interface ICaptureService
    {
        Bitmap Capture(string name);
    }
}
