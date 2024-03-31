﻿using System;
using System.Collections.Generic;
using System.Text;
using Configgy;
using CultOfJakito.UltraTelephone2.Assets;
using CultOfJakito.UltraTelephone2.DependencyInjection;
using HarmonyLib;

namespace CultOfJakito.UltraTelephone2.Patches
{
    [HarmonyPatch]
    public static class MannequinKrabs 
    {
        [Configgable("Patches", "Mannequins Steppies")]
        private static ConfigToggle s_enabled = new ConfigToggle(true);

        [HarmonyPatch(typeof(Mannequin), nameof(Mannequin.Start)), HarmonyPostfix]
        private static void OnStart(Mannequin __instance)
        {
            if (!s_enabled.Value)
                return;

            __instance.skitterSound.clip = HydraAssets.MannequinSkitterNoise; 
        }
    }
}
