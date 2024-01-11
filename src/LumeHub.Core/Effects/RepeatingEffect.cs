using LumeHub.Core.LedControllers;

namespace LumeHub.Core.Effects;

public abstract class RepeatingEffect : Effect
{
    private Thread? _thread;
    private CancellationTokenSource? _tokenSource;

    public override void Apply(LedController ledController)
    {
        _tokenSource = new CancellationTokenSource();
        _thread = new Thread(() => Loop(ledController, _tokenSource.Token));
        _thread.Start();
    }

    public void Stop() => _tokenSource?.Cancel();

    private void Loop(LedController ledController, CancellationToken ct)
    {
        while (!ct.IsCancellationRequested) Update(ledController, ct);
    }

    protected abstract void Update(LedController ledController, CancellationToken ct);
}
