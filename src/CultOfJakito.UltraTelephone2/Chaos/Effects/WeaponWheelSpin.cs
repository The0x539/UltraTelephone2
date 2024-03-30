using Configgy;
using CultOfJakito.UltraTelephone2.DependencyInjection;
using HarmonyLib;
using UnityEngine;

namespace CultOfJakito.UltraTelephone2.Chaos.Effects;

[RegisterChaosEffect]
[HarmonyPatch]
public class WeaponWheelSpin : ChaosEffect
{
    [Configgable("Chaos/Effects", "Spin Weapon Wheel")]
    public static ConfigToggle s_enabled = new(true);

    private static bool s_effectActive;

    public override void BeginEffect(UniRandom random) => s_effectActive = true;
    public override bool CanBeginEffect(ChaosSessionContext ctx) => s_enabled.Value && base.CanBeginEffect(ctx);
    public override int GetEffectCost() => 1;

    [HarmonyPrefix, HarmonyPatch(typeof(WeaponWheel), nameof(WeaponWheel.Update))]
    public static void Patch(WeaponWheel __instance)
    {
        if (!s_effectActive || !s_enabled.Value)
            return;

        var transform = __instance.transform;
        transform.Rotate(new Vector3(0, 0, 540 * Time.deltaTime));
        //Quaternion currentRotation = transform.rotation;
        //Console.print($"{currentRotation.x}, {currentRotation.y},{currentRotation.z}");
        //currentRotation.z += (float)(180 * Time.deltaTime);
        //Console.print($"{currentRotation.x}, {currentRotation.y},{currentRotation.z}");
        //transform.rotation = currentRotation;
    }

    protected override void OnDestroy() => s_effectActive = false;
}
