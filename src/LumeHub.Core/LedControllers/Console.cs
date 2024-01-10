using LumeHub.Core.Colors;

namespace LumeHub.Core.LedControllers;

public sealed class Console(int pixelCount) : LedController(pixelCount)
{
    private readonly RgbColor[] _leds = new RgbColor[pixelCount];

    public override RgbColor this[int index]
    {
        get => _leds[index];
        set => _leds[index] = value;
    }

    public override void Show()
    {
        foreach (var color in _leds)
        {
            System.Console.Write($"\x1b[38;2;{color.Red};{color.Green};{color.Blue}m" + // Foreground
                                 $"\x1b[48;2;{color.Red};{color.Green};{color.Blue}m"); // Background
            System.Console.Write('\u2587');                                             // Write any char
            System.Console.Write("\x1b[0m");                                            // Reset the colors
        }

        System.Console.WriteLine();
    }
}
