using System.Drawing;


namespace ScreenMelder.Lib.ScreenCapture
{
    public interface IScreenCaptureService
    {
        Bitmap Capture(Point upperLeftSource, Point upperLeftDestination, Size blockRegionSize);

    }
}
