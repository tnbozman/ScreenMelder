using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.ScreenCapture.Services.CaptureTarget
{
    public class ScreenCaptureTargets : ICaptureTargetStrategy
    {
        public List<string> GetTargets()
        {
            List<string> targets = new List<string>();
            var screenCount = Screen.AllScreens.Length;
            for(int i = 0; i < screenCount; i++)
            {
                targets.Add(i.ToString());
            }
            return targets;
        }
    }
}
