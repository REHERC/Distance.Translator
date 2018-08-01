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
                var LanguageSettingsObject = new GameObject("Panel - Language");
                var LanguageMenuController = LanguageSettingsObject.AddComponent<LanguageSettingsMenu>();
                LanguageMenuController.SetManager(CurrentPlugin._manager);

                List<OptionsSubmenu> submenus = new List<OptionsSubmenu>(__instance.subMenus_); 
                while (!submenus.Contains(LanguageMenuController))
                {
                    List<OptionsSubmenu> OPTIONS = new List<OptionsSubmenu>(__instance.subMenus_);
                    OPTIONS.Add(LanguageMenuController);
                    __instance.subMenus_ = OPTIONS.ToArray();
                    submenus = new List<OptionsSubmenu>(__instance.subMenus_);
                }
            }
        }
    }
}
