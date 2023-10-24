﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.ScreenCapture.Services.CaptureTarget
{
    public interface ICaptureTargetStrategy
    {
        List<string> GetTargets();
    }
}
