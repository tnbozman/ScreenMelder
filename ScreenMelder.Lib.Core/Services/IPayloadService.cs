using ScreenMelder.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Services
{
    public interface IPayloadService
    {
        string Load(string templatePath);
        bool Save(string templatePath, string jsonString);
        string AddCounterToTemplate(string captureCountLabel, int count);
        string PopulateTemplateWithRegions(string templatePath, List<RoiConfig> regions, Dictionary<string, string> ocrValues);
    }
}
