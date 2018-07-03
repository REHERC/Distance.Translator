﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using Spectrum.API;
using Spectrum.API.Configuration;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Logging;

namespace Distance.Translator
{
    public partial class Photon
    {
        // Only meant for translations purposes...
        [HarmonyPatch(typeof(ExperimentalMenu))]
        [HarmonyPatch("DisplayInMenu")]
        internal class ExperimentalMenu_DisplayInMenu_Patch : ExperimentalMenu
        {
            static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }

    }
}