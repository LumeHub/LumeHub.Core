namespace LumeHub.Core.LedControllers;

public class Ws2801Options : LedControllerOptions
{
    public required int BusId { get; init; }
    public required int ClockFrequency { get; init; } = 500_000;
}