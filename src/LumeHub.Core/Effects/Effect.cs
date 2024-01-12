using LumeHub.Core.LedControl;

namespace LumeHub.Core.Effects;

public abstract class Effect
{
    public abstract void Apply(LedController ledController);
}