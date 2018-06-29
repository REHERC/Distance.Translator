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
        [HarmonyPatch(typeof(PauseMenuLogic), "Start")]
        internal class PauseMenuLogic_Start_Patch : PauseMenuLogic
        {
            public static void Postfix(PauseMenuLogic __instance)
            {
                __instance.resumeButton_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_RESUME;
                __instance.restartButton_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_RESTART;
                __instance.spectateButton_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_SPECTATE;
                __instance.backToEditorButton_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_GOEDITOR;
                __instance.backToLobbyButton_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_GOLOBBY;
                __instance.mainMenuButton_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_GOMENU;
                __instance.optionsButtons_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_OPTIONS;
                __instance.optionButtonsPanel_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_NEXTLEVEL;
                __instance.reportBugButton_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_BUGREPORT;
                __instance.quitButton_.GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_QUIT;

            }
        }
    }
}