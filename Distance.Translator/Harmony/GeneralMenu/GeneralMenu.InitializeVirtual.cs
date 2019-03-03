using static Distance.Translator.Extensions.GeneralMenuExtensions;
using static Distance.Translator.CurrentPlugin;
using Harmony;
using UnityEngine;
using System;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(GeneralMenu), "InitializeVirtual")]
    public class GeneralMenu__InitializeVirtual__Patch
    {
        static void Postfix(GeneralMenu __instance)
        {
            Menu.menuBlueprint = __instance.menuBlueprint_;
            
            __instance.TweakAction("LANGUAGE SETTINGS", () => {
                foreach (var component in __instance.PanelObject_.GetComponents<LanguageMenu>())
                    component.Destroy();
                
                LanguageMenu menu = __instance.PanelObject_.AddComponent<LanguageMenu>();

                menu.MenuPanel = MenuPanel.Create(menu.PanelObject_, true, true, false, true, false, false);

                menu.MenuPanel.onPanelPop_ += () =>
                {
                    __instance.PanelObject_.SetActive(true);
                };

                __instance.PanelObject_.SetActive(false);
                G.Sys.MenuPanelManager_.Push(menu.MenuPanel);
            });
        }
    }
}
