using LumeHub.Core.Colors;

namespace LumeHub.Core.Effects.Normal;

public class FadeColor() : Effect(nameof(FadeColor))
{
    public required RgbColor Color { get; set; }
}
