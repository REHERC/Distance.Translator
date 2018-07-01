using System;
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
using UnityEngine;
using UnityEngine.UI;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(UIPanel), "Start")]
        internal class UIPanel_Start_Patch : UIPanel
        {
            public static void Postfix(UIPanel __instance)
            {
				if (__instance.name == "Panel - Audio")
                {
                    CurrentPlugin.Log.Error("Found the audio options panel !");
                }
            }
        }
    }
}