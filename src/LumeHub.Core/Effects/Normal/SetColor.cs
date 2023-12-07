using LumeHub.Core.Color;

namespace LumeHub.Core.Effects.Normal;

public sealed class SetColor() : Effect(nameof(SetColor))
{
    public required RgbColor Color { get; set; }
}
