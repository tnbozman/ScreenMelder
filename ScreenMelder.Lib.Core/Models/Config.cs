using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Models
{
    public class Config
    {
        public int CaptureType { get; set; }
        public string CaptureName { get; set; }
        public RoiConfig Trigger { get; set; }
        public List<RoiConfig> Regions { get; set; }
    }
}
