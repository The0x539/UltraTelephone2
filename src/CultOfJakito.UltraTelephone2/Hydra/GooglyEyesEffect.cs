﻿using Configgy;
using CultOfJakito.UltraTelephone2.Assets;
using CultOfJakito.UltraTelephone2.Chaos;
using CultOfJakito.UltraTelephone2.DependencyInjection;
using HarmonyLib;
using UnityEngine;

namespace CultOfJakito.UltraTelephone2.Hydra;

[RegisterChaosEffect]
[HarmonyPatch]
public class GooglyEyesEffect : ChaosEffect
{
    private static bool s_effectActive;
    private static UniRandom s_random;

    [Configgable("Hydra/Chaos", "Googly Eyes")]
    private static ConfigToggle s_enabled = new(true);

    public override void BeginEffect(UniRandom rand)
    {
        s_random = rand;
        s_effectActive = true;
    }

    public override int GetEffectCost() => 1;
    private void OnDestroy() => s_effectActive = false;


    [HarmonyPatch(typeof(EnemyIdentifier), "Start"), HarmonyPostfix]
    private static void OnEnemyStart(EnemyIdentifier __instance)
    {
        if (!s_effectActive || !s_enabled.Value)
            return;

        switch (__instance.enemyType)
        {
            case EnemyType.Filth:
                ApplyGooglyEyes_Filth(__instance);
                break;
            case EnemyType.Stray:
                ApplyGooglyEyes_Stray(__instance);
                break;
            case EnemyType.Drone:
                ApplyGooglyEyes_Drone(__instance);
                break;
            case EnemyType.Schism:
                ApplyGoogleEyes_Schism(__instance);
                break;
            case EnemyType.Soldier:
                ApplyGooglyEyes_Soldier(__instance);
                break;
            case EnemyType.Streetcleaner:
                ApplyGooglyEyes_Streetcleaner(__instance);
                break;
            case EnemyType.MaliciousFace:
                ApplyGooglyEyes_MaliciousFace(__instance);
                break;
            case EnemyType.Virtue:
                ApplyGooglyEyes_Virtue(__instance);
                break;
            case EnemyType.Cerberus:
                ApplyGooglyEyes_Cerberus(__instance);
                break;
            case EnemyType.Swordsmachine:
                ApplyGooglyEyes_Swordsmachine(__instance);
                break;
            case EnemyType.Mindflayer:
                ApplyGooglyEyes_Mindflayer(__instance);
                break;
            case EnemyType.Turret:
                ApplyGooglyEyes_Turret(__instance);
                break;
            case EnemyType.Mannequin:
                ApplyGooglyEyes_Mannequin(__instance);
                break;
            case EnemyType.MinosPrime:
                ApplyGooglyEyes_MinosPrime(__instance);
                break;
            case EnemyType.SisyphusPrime:
                ApplyGooglyEyes_SisyphusPrime(__instance);
                break;
            case EnemyType.V2:
                ApplyGooglyEyes_V2(__instance);
                break;
            case EnemyType.V2Second:
                ApplyGooglyEyes_V2Two(__instance);
                break;
            case EnemyType.Minos:
                ApplyGooglyEyes_MinosCorpse(__instance);
                break;
            case EnemyType.Ferryman:
                ApplyGooglyEyes_Ferryman(__instance);
                break;
            case EnemyType.Idol:
                ApplyGooglyEyes_Idol(__instance);
                break;
            case EnemyType.Guttertank:
                ApplyGooglyEyes_GutterTank(__instance);
                break;
            case EnemyType.Stalker:
                ApplyGooglyEyes_Stalker(__instance);
                break;
            default:
                break;
        }
    }


    private static void ApplyGooglyEyes_Filth(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.03283036f, 0.3157102f, 0.05048939f);
        eye.transform.localRotation = Quaternion.Euler(-52.167f, 15.641f, 63.549f);
        eye.transform.localScale = Vector3.one*0.1765201f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(0.03624479f, 0.309489f, -0.06832973f);
        eye2.transform.localRotation = Quaternion.Euler(-52.263f, 146.45f, -53.117f);
        eye2.transform.localScale = Vector3.one * 0.1765201f;
    }

    private static void ApplyGooglyEyes_Stray(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.07322577f, 0.2133703f, 0.2188971f);
        eye.transform.localRotation = Quaternion.Euler(-7.8f, 0f, 0f);
        eye.transform.localScale = Vector3.one * 0.333f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.07322577f, 0.2133703f, 0.2188971f);
        eye2.transform.localRotation = Quaternion.Euler(-7.8f, 0f, 0f);
        eye2.transform.localScale = Vector3.one * 0.333f;
    }

    private static void ApplyGooglyEyes_Drone(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0f, 0.03500002f, 0.2942536f);
        eye.transform.localRotation = Quaternion.identity;
        eye.transform.localScale = Vector3.one * 0.1666667f;
    }

    private static void ApplyGoogleEyes_Schism(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.07031024f, 0.05864394f, 0.2592734f);
        eye.transform.localRotation = Quaternion.Euler(-35.028f, 32.298f, -29.169f);
        eye.transform.localScale = Vector3.one * 0.5535334f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.1423752f, 0.1149041f, 0.2724141f);
        eye2.transform.localRotation = Quaternion.Euler(-42.306f, 9.525001f, -14.797f);
        eye2.transform.localScale = Vector3.one * 0.5535334f;
    }

    private static void ApplyGooglyEyes_Soldier(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.002870823f, 0.1229381f, 0.2539791f);
        eye.transform.localRotation = Quaternion.Euler(5.02f, 0f, 0f);
        eye.transform.localScale = Vector3.one * 0.4782089f;
    }

    private static void ApplyGooglyEyes_Streetcleaner(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.1359702f, 0.1398589f, 0.02247924f);
        eye.transform.localRotation = Quaternion.Euler(-3.198f, 81.51601f, -26.321f);
        eye.transform.localScale = Vector3.one * 0.6752786f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.1176301f, 0.1545803f, 0.04294725f);
        eye2.transform.localRotation = Quaternion.Euler(-2.715f, -86.592f, 26.372f);
        eye2.transform.localScale = Vector3.one * 0.6752786f;
    }

    private static void ApplyGooglyEyes_MaliciousFace(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.109875f, -0.07116663f, 0.2713113f);
        eye.transform.localRotation = Quaternion.Euler(0f, 22.134f, 0f);
        eye.transform.localScale = Vector3.one * 0.3934997f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.109875f, -0.07116663f, 0.2713113f);
        eye2.transform.localRotation = Quaternion.Euler(0f, -22.134f, 0f);
        eye2.transform.localScale = Vector3.one * 0.4782089f;
    }

    private static void ApplyGooglyEyes_Virtue(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0f, -0.01479552f, 0.135705f);
        eye.transform.localRotation = Quaternion.Euler(0f, 22.134f, 0f);
        eye.transform.localScale = Vector3.one * 0.7022591f;
    }

    private static void ApplyGooglyEyes_Cerberus(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.06363031f, 0.1479863f, 0.2291597f);
        eye.transform.localRotation = Quaternion.Euler(0f, 3.07f, 0f);
        eye.transform.localScale = Vector3.one * 0.333333f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.06363031f, 0.1479863f, 0.2291597f);
        eye2.transform.localRotation = Quaternion.Euler(0f, -3.07f, 0f);
        eye2.transform.localScale = Vector3.one * 0.333333f;
    }

    private static void ApplyGooglyEyes_Swordsmachine(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.14472931f, -0.2546722f, 0.1683541f);
        eye.transform.localRotation = Quaternion.Euler(-8.184f, 1.992f, 3.83f);
        eye.transform.localScale = Vector3.one;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.1022849f, 0.08561087f, 0.1290056f);
        eye2.transform.localRotation = Quaternion.Euler(-6.414001f, -0.638f, 5.912f);
        eye2.transform.localScale = Vector3.one;
    }

    private static void ApplyGooglyEyes_Mindflayer(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.183806f, -0.2144246f, 0.4077076f);
        eye.transform.localRotation = Quaternion.Euler(-2.168f, 0.5840001f, -0.454f);
        eye.transform.localScale = new Vector3(0.7999951f, 0.7273716f, 3.644038f);

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.183806f, -0.2144246f, 0.4077076f);
        eye2.transform.localRotation = Quaternion.Euler(-2.168f, 0.5840001f, -0.454f);
        eye2.transform.localScale = new Vector3(0.7999951f, 0.7273716f, 3.644038f);

    }

    private static void ApplyGooglyEyes_Turret(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.003100248f, 0.009723132f, 0.2271778f);
        eye.transform.localRotation = Quaternion.Euler(2.679f, 0.041f, 0.642f);
        eye.transform.localScale = Vector3.one * 0.8333333f;
    }

    private static void ApplyGooglyEyes_Mannequin(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(-0.02386483f, 0.1794786f, 0.03902283f);
        eye.transform.localRotation = Quaternion.Euler(3.772f, -14.941f, -154.437f);
        eye.transform.localScale = Vector3.one * 0.2862214f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(0.101f, 0.193f, 0.043f);
        eye2.transform.localRotation = Quaternion.Euler(-4.647f, 4.707f, -152.508f);
        eye2.transform.localScale = Vector3.one * 0.2862214f;
    }

    private static void ApplyGooglyEyes_MinosPrime(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.07735992f, 0.1082705f, 0f);
        eye.transform.localRotation = Quaternion.Euler(-19.597f, 90f, -154.437f);
        eye.transform.localScale = Vector3.one * 0.300404f;
    }

    private static void ApplyGooglyEyes_SisyphusPrime(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.05748453f, 0.1543258f, 0.1337435f);
        eye.transform.localRotation = Quaternion.Euler(2.266f, 0f, 0f);
        eye.transform.localScale = Vector3.one * 0.25432f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.05748453f, 0.1543258f, 0.1337435f);
        eye2.transform.localRotation = Quaternion.Euler(2.266f, 0f, 0f);
        eye2.transform.localScale = Vector3.one * 0.25432f;
    }

    private static void ApplyGooglyEyes_V2(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(-0.0213f, 0.1502f, -0.1363f);
        eye.transform.localRotation = Quaternion.Euler(9.667001f, 4.716f, -0.22f);
        eye.transform.localScale = Vector3.one * 0.3920001f;
    }

    private static void ApplyGooglyEyes_V2Two(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.09459145f, 0.1897086f, -0.09157142f);
        eye.transform.localRotation = Quaternion.Euler(0.396f, 1.481f, 0.7730001f);
        eye.transform.localScale = Vector3.one * 0.4624357f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.1505641f, 0.18682f, -0.1028761f);
        eye2.transform.localRotation = Quaternion.Euler(0.396f, 1.481f, 0.7730001f);
        eye2.transform.localScale = Vector3.one * 0.4624357f;
    }

    private static void ApplyGooglyEyes_MinosCorpse(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.2275272f, 0.2584675f, -0.02878922f);
        eye.transform.localRotation = Quaternion.Euler(-10.291f, -245.163f, 89.83301f);
        eye.transform.localScale = Vector3.one * 0.3443233f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(0.1198885f, 0.2723473f, -0.1831242f);
        eye2.transform.localRotation = Quaternion.Euler(-9.893001f, -229.932f, 87.148f);
        eye2.transform.localScale = Vector3.one * 0.3443233f;
    }

    private static void ApplyGooglyEyes_Ferryman(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.099f, 0.27f, 0.095f);
        eye.transform.localRotation = Quaternion.Euler(-39.337f, 0f, 0f);
        eye.transform.localScale = Vector3.one * 0.5f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.099f, 0.27f, 0.095f);
        eye2.transform.localRotation = Quaternion.Euler(-39.337f, 0f, 0f);
        eye2.transform.localScale = Vector3.one * 0.5f;
    }

    private static void ApplyGooglyEyes_Idol(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.006f, 0.153f, 0.059f);
        eye.transform.localRotation = Quaternion.Euler(30.34f, -24.593f, 2.737f);
        eye.transform.localScale = Vector3.one * 0.3586133f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.109f, 0.135f, -0.006f);
        eye2.transform.localRotation = Quaternion.Euler(30.34f, -24.593f, 2.737f);
        eye2.transform.localScale = Vector3.one * 0.3586133f;

        GooglyEye eye3 = GooglyEye.New();
        eye3.transform.SetParent(hat.transform);
        eye3.transform.localPosition = new Vector3(-0.1288f, -0.1415f, -0.1102f);
        eye3.transform.localRotation = Quaternion.Euler(-12.341f, 38.612f, 2.63f);
        eye3.transform.localScale = Vector3.one * 0.2670228f;

        GooglyEye eye4 = GooglyEye.New();
        eye4.transform.SetParent(hat.transform);
        eye4.transform.localPosition = new Vector3(-0.2319f, -0.1523f, -0.0583f);
        eye4.transform.localRotation = Quaternion.Euler(-10.159f, 13.942f, 7.517f);
        eye4.transform.localScale = Vector3.one * 0.2670228f;
    }

    private static void ApplyGooglyEyes_GutterTank(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.1622703f, 0.05545729f, 0.539142f);
        eye.transform.localRotation = Quaternion.Euler(-41.08f, 0f, 0f);
        eye.transform.localScale = Vector3.one * 0.5470667f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.1622703f, 0.05545729f, 0.539142f);
        eye2.transform.localRotation = Quaternion.Euler(-41.08f, 0f, 0f);
        eye2.transform.localScale = Vector3.one * 0.5470667f;
    }

    private static void ApplyGooglyEyes_Stalker(EnemyIdentifier __instance)
    {
        SeasonalHats hat = __instance.GetComponentInChildren<SeasonalHats>(true);
        if (hat == null)
            return;

        GooglyEye eye = GooglyEye.New();
        eye.transform.SetParent(hat.transform);
        eye.transform.localPosition = new Vector3(0.07468935f, 0.1755633f, 0.01454816f);
        eye.transform.localRotation = Quaternion.Euler(-37.563f, 68.76801f, -63.458f);
        eye.transform.localScale = Vector3.one * 0.3644443f;

        GooglyEye eye2 = GooglyEye.New();
        eye2.transform.SetParent(hat.transform);
        eye2.transform.localPosition = new Vector3(-0.07468935f, 0.1755633f, 0.01454816f);
        eye2.transform.localRotation = Quaternion.Euler(-37.563f, -68.76801f, 63.458f);
        eye2.transform.localScale = Vector3.one * 0.3644443f;
    }

    //TODO Gabriel 1 + 2, gutterman

}

public class GooglyEye : MonoBehaviour
{
    public static GooglyEye New()
    {
        GameObject newGooglyEye = GameObject.Instantiate(HydraAssets.GooglyEye);
        return newGooglyEye.AddComponent<GooglyEye>();
    }

    private Transform center;
    private Transform eyeTransform;
    private Transform radiusMarkTransform;
    private float energy;
    private float energyDecayRate = 5f;

    float maxRadius;

    private void Awake()
    {
        center = FindButGood("EyeRoot");
        eyeTransform = FindButGood("Eye");
        radiusMarkTransform = FindButGood("LowPosition");
    }

    private Transform FindButGood(string name)
    {
        return transform.GetComponentsInChildren<Transform>().Where(x => x.name == name).FirstOrDefault();
    }

    private void Start()
    {
        maxRadius = Vector3.Distance(center.position, radiusMarkTransform.position);
        positionLastFrame = transform.position;
    }

    private void LateUpdate()
    {
        energy = Mathf.Max(0, energy - Time.deltaTime * energyDecayRate);
        Vector3 centerPoint = center.position;
        float sin = Mathf.Sin(Time.time*energy);

        if(energy == 0f)
            sin = 0f;

        float angle = sin * Mathf.Min(energy, 10f)*10f;
        Quaternion rot = Quaternion.Euler(0, 0, angle);
        rot = transform.rotation * rot;
        Vector3 offset = rot * Vector3.down*maxRadius;
        eyeTransform.position = centerPoint + offset;

        energy = Mathf.Min(energy + (transform.position - positionLastFrame).magnitude/2f, 20f);
        positionLastFrame = transform.position;
    }

    private Vector3 positionLastFrame;
    
}
