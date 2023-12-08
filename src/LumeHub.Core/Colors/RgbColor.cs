using System.Drawing;

namespace LumeHub.Core.Colors;

public record RgbColor(byte Red, byte Green, byte Blue)
{
    public static implicit operator Color(RgbColor rgbColor) =>
        Color.FromArgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);

    public static implicit operator RgbColor(Color color) =>
        new(color.R, color.G, color.B);
}
