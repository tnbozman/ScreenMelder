using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ScreenMelder.Lib.ScreenCapture;
using ScreenMelder.Lib.ScreenCapture.Models;
using ScreenMelder.Lib.ScreenCapture.Services;

namespace ScreenMelder.Lib.ScreenCapture
{
    public class ApplicationCapture : ICaptureService
    {
        public CaptureType CaptureType => CaptureType.APPLICATION;
        public string Name { get; set; }

        private readonly IScreenCaptureService _service;
        public ApplicationCapture(IScreenCaptureService captureService, string captureName)
        {
            _service = captureService;
            Name = captureName;
        }
        public Bitmap Capture()
        {
            throw new NotImplementedException();
        }

        public Bitmap CaptureRegion(Rectangle region)
        {
            throw new NotImplementedException();
        }
    }
}
