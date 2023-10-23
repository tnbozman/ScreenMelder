using System.Drawing;


namespace ScreenMelder.Lib.ScreenCapture.Services
{
    public interface IScreenCaptureService
    {
        Bitmap Capture(Point upperLeftSource, Point upperLeftDestination, Size blockRegionSize);

    }
}
