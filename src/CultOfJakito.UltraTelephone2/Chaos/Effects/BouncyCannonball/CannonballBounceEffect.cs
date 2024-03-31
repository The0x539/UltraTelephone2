using Configgy;
using CultOfJakito.UltraTelephone2.Chaos;
using CultOfJakito.UltraTelephone2.DependencyInjection;
using HarmonyLib;

namespace CultOfJakito.UltraTelephone2.Effects.BouncyCannonball;

[HarmonyPatch]
[RegisterChaosEffect]
public class CannonballBounceEffect : ChaosEffect
{
    [Configgable("Chaos/Effects", "Bouncy Cannonball")]
    private static ConfigToggle s_enabled = new(true);

    private static bool s_currentlyActive;

    public override void BeginEffect(UniRandom random) => s_currentlyActive = true;
    public override bool CanBeginEffect(ChaosSessionContext ctx) => s_enabled.Value && base.CanBeginEffect(ctx);
    public override int GetEffectCost() => 1;


    [HarmonyPrefix, HarmonyPatch(typeof(Cannonball), nameof(Cannonball.Start))]
    public static void Start(Cannonball __instance)
    {
        if (!s_currentlyActive || !s_enabled.Value)
            return;

        BouncyCannonball cb = __instance.gameObject.AddComponent<BouncyCannonball>();
    }

    [HarmonyPrefix, HarmonyPatch(typeof(Cannonball), nameof(Cannonball.Break))]
    public static bool Break(Cannonball __instance) => !s_currentlyActive || __instance.GetComponent<BouncyCannonball>().RemainingTime <= 0;

    protected override void OnDestroy() => s_currentlyActive = false;
}


