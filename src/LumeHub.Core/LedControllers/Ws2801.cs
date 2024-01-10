using System.Device.Spi;

using LumeHub.Core.Colors;

namespace LumeHub.Core.LedControllers;

public sealed class Ws2801(int pixelCount, SpiConnectionSettings settings) : LedController(pixelCount)
{
    private readonly byte[] _buffer = new byte[pixelCount * 3];

    public override RgbColor this[int index]
    {
        get
        {
            int offset = index * 3;
            return new RgbColor(_buffer[offset], _buffer[offset + 1], _buffer[offset + 2]);
        }
        set
        {
            int offset = index * 3;
            _buffer[offset + 0] = value.Red;
            _buffer[offset + 1] = value.Green;
            _buffer[offset + 2] = value.Blue;
        }
    }

    public override void Show()
    {
        using var device = SpiDevice.Create(settings);
        device.Write(_buffer);
        Thread.Sleep(1);
    }
}
