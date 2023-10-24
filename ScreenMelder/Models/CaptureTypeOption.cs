using ScreenMelder.Lib.ScreenCapture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Models
{
    public class CaptureTypeOption
    {
        public string Label { get; set; }
        public CaptureType Value { get; set; }

        public override string ToString()
        {
            return Label;
        }
    }
}
