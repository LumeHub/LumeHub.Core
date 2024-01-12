using LumeHub.Core.Colors;
using LumeHub.Core.LedControl;

namespace LumeHub.Core.Effects.Normal;

public class FadeColor : Effect
{
    public required RgbColor Color { get; init; }

    public override void Apply(LedController ledController)
    {
        var currentColor = ledController[0];
        foreach (var color in RgbColorUtils.InterpolateColors(currentColor, Color, 12))
        {
            ledController.SetAllPixel(color);
            ledController.Show();
            Thread.Sleep(10);
        }
    }
}
