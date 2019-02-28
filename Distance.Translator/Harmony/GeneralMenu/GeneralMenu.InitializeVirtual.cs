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
            __instance.TweakEnum<string>("INTERFACE LANGUAGE",
                () =>
                {
                    return CurrentPlugin.Configuration["InterfaceLanguage"].ToString();
                },
                (value) =>
                {
                    CurrentPlugin.Configuration["InterfaceLanguage"] = value;
                    CurrentPlugin.Configuration.Save();
                    Language.Reload();
                },
                "",
                LanguageFiles.ToArray()
            );

            //GameObject options = Util.FindByName($"{Menu.GetOptionsRoot()}/Panel - Options");
            //MenuPanel panel = options.GetComponent<MenuPanel>();
            //panel.ClearBottomLeftButtons();

            //panel.SetBottomLeftButton(InputAction.MenuSpecial_2, "TEST");

            //panel.Push();

            //MenuPanel menuPanel = MenuPanel.Create(__instance.PanelObject_, false, false, false, true, false, true);
            //menuPanel.backgroundOpacity_ = 0.75f;
            //menuPanel.dontDisableOnPop_ = true;
            //menuPanel.ClearBottomLeftButtons();
            //menuPanel.SetBottomLeftButton(InputAction.MenuSpecial_2, "TEST");
            //menuPanel.selectOnPush_ = __instance.PanelObject_;

            //__instance.CreateLanguageDropdown();

            G.Sys.MenuPanelManager_.SetBottomLeftActionButton(InputAction.MenuPageLeft, "PREVIOUS");
            G.Sys.MenuPanelManager_.SetBottomLeftActionButton(InputAction.MenuPageRight, "NEXT");

            AddButtonAction(InputAction.MenuPageLeft, (sender) => {
                G.Sys.MenuPanelManager_.ShowError("InputAction.MenuPageLeft", "PREVIOUS BUTTON CLICKED");
            });

            AddButtonAction(InputAction.MenuPageRight, (sender) => {
                G.Sys.MenuPanelManager_.ShowError("InputAction.MenuPageRight", "NEXT BUTTON CLICKED");
            });
        }

        public static void AddButtonAction(InputAction a, UIEventListener.VoidDelegate d)
        {
            GameObject container = GameObject.Find("BackButton/Panel/BottomLeftButtons");
            foreach (GameObject button in container.GetChildren())
            {
                //if (button.HasComponent<UIExBlueprint>())
                //    continue;
                ControlsBasedUITexture control = button.GetComponent<ControlsBasedUITexture>();
                if (control)
                    if (control.inputAction_ == a)
                    {
                        UIEventListener listener = UIEventListener.Get(button);
                        listener.onClick = d;
                    }
            }
        }
    }
}
