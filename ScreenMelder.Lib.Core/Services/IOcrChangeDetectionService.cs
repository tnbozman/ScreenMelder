﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Services
{
    public interface IOcrChangeDetectionService
    {
        bool Start(string configPath, string templatePath, string overlayOutputPath, int period, string captureCountLabel);
        void Stop();
    }
}
