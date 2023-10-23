using ScreenMelder.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Services
{
    public interface IConfigurationService
    {
        Config ReadConfig(string path);
        void SaveConfig(Config config, string path);

    }
}
