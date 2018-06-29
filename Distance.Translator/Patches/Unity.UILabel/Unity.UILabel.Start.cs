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
        [HarmonyPatch(typeof(UILabel), "Start")]
        internal class UILabel_Start_Patch : UILabel
        {
            public static void Postfix(UILabel __instance)
            {

                /*
                switch (__instance.name)
                {
                    case "UILabel - PressAnyButton":
                        __instance.text = Language.MAINMENU_PRESSKEY;
                        break;
                }
                */
                
            }
        }
    }
}