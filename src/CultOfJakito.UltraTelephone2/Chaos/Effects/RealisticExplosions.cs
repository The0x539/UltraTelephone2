using Configgy;
using CultOfJakito.UltraTelephone2.DependencyInjection;
using HarmonyLib;
using UnityEngine;

namespace CultOfJakito.UltraTelephone2.Chaos.Effects;

[RegisterChaosEffect]
[HarmonyPatch]
public class RealisticExplosions : ChaosEffect
{
    [Configgable("Chaos/Effects", "Knuckle Blaster Recoil")]
    private static ConfigToggle s_enabled = new(true);

    private static bool s_currentlyActive;

    private static float s_timeSinceLastTick;

    public override void BeginEffect(UniRandom random) => s_currentlyActive = true;
    public override bool CanBeginEffect(ChaosSessionContext ctx) => s_enabled.Value && base.CanBeginEffect(ctx);
    public override int GetEffectCost() => 1;

    [HarmonyPatch(typeof(Explosion), nameof(Explosion.Start)), HarmonyPrefix]
    public static void BeamExtension()
    {
        if (!s_currentlyActive && !s_enabled.Value)
            return;

    }
}