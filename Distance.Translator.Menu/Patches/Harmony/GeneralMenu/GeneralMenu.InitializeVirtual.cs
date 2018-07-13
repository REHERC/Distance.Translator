using System.Collections.Generic;
using Harmony;
using Spectrum.Menu.Menus;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Menu
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(OptionsMenuLogic), "Awake")]
        internal class OptionsMenuLogic_Awake_Patch
        {
            public static void Postfix(OptionsMenuLogic __instance)
            {
                CurrentPlugin.Log.Error("OPTIONSMENULOGIC AWAKE EVENT");
                var LanguageSettingsObject = new GameObject("LanguageSettings");
                var LanguageMenuController = LanguageSettingsObject.AddComponent<LanguageSettingsMenu>();
                LanguageMenuController.SetManager(CurrentPlugin._manager);

                List<OptionsSubmenu> OPTIONS = new List<OptionsSubmenu>(__instance.subMenus_);
                OPTIONS.Add(LanguageMenuController);

                __instance.subMenus_ = OPTIONS.ToArray();
                CurrentPlugin.Log.Error("MENU ADDED");
            }
        }
    }
}
