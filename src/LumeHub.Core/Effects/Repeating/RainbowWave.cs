namespace LumeHub.Core.Effects.Repeating;

public sealed class RainbowWave() : RepeatingEffect(nameof(RainbowWave))
{
    public required float Multiplier { get; set; }
}
