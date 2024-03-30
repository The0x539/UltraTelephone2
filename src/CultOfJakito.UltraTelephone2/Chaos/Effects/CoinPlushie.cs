﻿using System;
using System.Collections.Generic;
using System.Text;
using Configgy;
using CultOfJakito.UltraTelephone2.Assets;
using CultOfJakito.UltraTelephone2.Chaos;
using CultOfJakito.UltraTelephone2.DependencyInjection;
using HarmonyLib;
using UnityEngine;

namespace CultOfJakito.UltraTelephone2.Chaos.Effects
{
    [RegisterChaosEffect]
    internal class CoinPlushie : ChaosEffect
    {

        [Configgable("Chaos/Effects", "Coin Plushies")]
        private static ConfigToggle s_enabled = new(true);

        private static bool s_effectActive;

        private static List<GameObject> _plushiePrefabs = new();

        private static int _randomPlushieIndex;

        public override void BeginEffect(UniRandom random)
        {
            Console.WriteLine("Starting Coin Plushies");
            _plushiePrefabs.Add(UT2Assets.GetAsset<GameObject>("Assets/Telephone 2/Dev Plushies/Plushie Prefabs/zelzmiy Niko Plush.prefab"));
            _plushiePrefabs.Add(UT2Assets.GetAsset<GameObject>("Assets/Telephone 2/Dev Plushies/Plushie Prefabs/HydraDevPlushie.prefab"));
            // TODO: Add everybody else's Plushies in here :) (once they have them)

            _randomPlushieIndex = random.Next(0, _plushiePrefabs.Count - 1);
            s_effectActive = true;
        }

        public override int GetEffectCost() => 1;

        [HarmonyPatch(typeof(Coin), "Start"), HarmonyPostfix]
        private static void ChangeCoinToPlushie(Coin __instance)
        {
            if (!s_enabled.Value || !s_effectActive)
                return;

            GameObject plushie = _plushiePrefabs[_randomPlushieIndex];

            GameObject plush = Instantiate(plushie, __instance.transform.position, __instance.transform.rotation);
            plush.GetComponent<Rigidbody>().AddForce(__instance.GetComponent<Rigidbody>().velocity, ForceMode.VelocityChange);

            Destroy(__instance.gameObject);
        }
    }
}
