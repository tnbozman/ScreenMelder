using ScreenMelder.Lib.ScreenCapture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.ScreenCapture.Services.CaptureTarget
{
    public class CaptureTargetContext
    {
        private readonly Dictionary<CaptureType, ICaptureTargetStrategy> _strategies;
        public CaptureTargetContext() {
            _strategies = new Dictionary<CaptureType, ICaptureTargetStrategy>();
            _strategies.Add(CaptureType.SCREEN, new ScreenCaptureTargets());
            _strategies.Add(CaptureType.APPLICATION, new ApplicationCaptureTargets());
        }

        public List<String> GetTargets(CaptureType captureType)
        {
            if(_strategies.ContainsKey(captureType)) {
                return _strategies[captureType].GetTargets();
            }
            // TODO: add exception
            return null;
        }
    }
}
