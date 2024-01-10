using LumeHub.Core.Colors;

namespace LumeHub.Core.LedControllers;

public abstract class LedController
{
    public int PixelCount { get; }

    protected LedController(int pixelCount)
    {
        PixelCount = pixelCount;

        SetAllPixel(new RgbColor(0, 0, 0));
    }

    public abstract RgbColor this[int index] { get; set; }

    public void SetAllPixel(RgbColor color)
    {
        for (int i = 0; i < PixelCount; i++) this[i] = color;
    }

    public abstract void Show();
}
