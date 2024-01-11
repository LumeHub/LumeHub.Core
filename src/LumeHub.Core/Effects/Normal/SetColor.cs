using LumeHub.Core.Colors;
using LumeHub.Core.LedControllers;

namespace LumeHub.Core.Effects.Normal;

public sealed class SetColor : Effect
{
    public required RgbColor Color { get; set; }

    public override void Apply(LedController ledController)
    {
        ledController.SetAllPixel(Color);
        ledController.Show();
    }
}
