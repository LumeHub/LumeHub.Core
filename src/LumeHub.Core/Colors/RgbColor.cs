using System.Drawing;

namespace LumeHub.Core.Colors;

public record RgbColor(byte Red, byte Green, byte Blue)
{
    public RgbColor(int red, int green, int blue) : this((byte)red, (byte)green, (byte)blue)
    { }

    public static implicit operator Color(RgbColor rgbColor) =>
        Color.FromArgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);

    public static implicit operator RgbColor(Color color) =>
        new(color.R, color.G, color.B);
}
