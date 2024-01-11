using LumeHub.Core.Colors;
using LumeHub.Core.LedControllers;

namespace LumeHub.Core.Effects.Repeating;

public sealed class RainbowWave : RepeatingEffect
{
    public required float Multiplier { get; set; }
    public required int Timeout { get; set; }

    protected override void Update(LedController ledController, CancellationToken ct)
    {
        for (int colorIndex = 0; colorIndex < 256; colorIndex++)
        {
            for (int i = 0; i < ledController.PixelCount; i++)
            {
                if (ct.IsCancellationRequested) break;
                ledController[i] = new RainbowCycleColor(colorIndex, ledController.PixelCount, Multiplier, i);
            }

            if (ct.IsCancellationRequested) break;

            ledController.Show();
            Thread.Sleep(Timeout);
        }
    }
}
