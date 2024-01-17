using LumeHub.Core.LedControl;
using System.Text.Json.Serialization;

namespace LumeHub.Core.Effects;

[JsonConverter(typeof(EffectConverter))]
public abstract class Effect(string name)
{
    public string Name => name;
    public abstract void Apply(LedController ledController);
}