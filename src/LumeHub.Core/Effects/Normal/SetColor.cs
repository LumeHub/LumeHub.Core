using LumeHub.Core.Colors;
using LumeHub.Core.LedControl;

namespace LumeHub.Core.Effects.Normal;

public sealed class SetColor() : Effect(nameof(SetColor))
{
    public required RgbColor Color { get; init; }

    public override void Apply(LedController ledController)
    {
        ledController.SetAllPixel(Color);
        ledController.Show();
    }
}
