using LumeHub.Core.Colors;

namespace LumeHub.Core.Effects.Normal;

public sealed class SetColor() : Effect(nameof(SetColor))
{
    public required RgbColor Color { get; set; }
}
