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
        [HarmonyPatch(typeof(MainMenuLogic), "Start")]
        internal class MainMenuLogic_Start_Patch : MainMenuLogic
        {
            public static void Postfix(MainMenuLogic __instance)
            {
                GameObject.Find("Adventure").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_ADVENTURE;
                GameObject.Find("Arcade").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_ARCADE;
                GameObject.Find("Multiplayer").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_MULTIPLAYER;
                GameObject.Find("Level Editor").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_LEVELEDITOR;
                GameObject.Find("Steam Workshop").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_WORKSHOP;
                GameObject.Find("Garage").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_GARAGE;
                GameObject.Find("Report Bug").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_BUGREPORT;
                GameObject.Find("Options").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_OPTIONS;
                GameObject.Find("Quit").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_QUIT;
                
            }
        }
    }
}