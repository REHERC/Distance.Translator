using UnityEngine;
using static Distance.Translator.CurrentPlugin;

namespace Distance.Translator
{
    class LanguageMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => "Language Settings";
        public override string Name_ => "Language";

        public MenuPanel MenuPanel { get; set; }
        public LanguageMenuController Controller { get; set; }

        public override bool DisplayInMenu(bool isPauseMenu) => true;

        public override void InitializeVirtual()
        {
            TweakEnum<string>("INTERFACE LANGUAGE",
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

            TweakEnum<string>("SUBTITLES LANGUAGE",
                () =>
                {
                    return CurrentPlugin.Configuration["SubtitlesLanguage"].ToString();
                },
                (value) =>
                {
                    CurrentPlugin.Configuration["SubtitlesLanguage"] = value;
                    CurrentPlugin.Configuration.Save();
                    Language.Reload();
                },
                "",
                LanguageFiles.ToArray()
            );

            Controller = PanelObject_.AddComponent<LanguageMenuController>();

            Controller.Menu = this;
        }

        public override void OnPanelPop()
        {
            Controller.Destroy();
        }

        internal class LanguageMenuController : MonoBehaviour
        {
            public LanguageMenu Menu { get; set; }
            public InputManager im;

            void Start()
            {
                im = G.Sys.InputManager_;
                Log.Success("LanguageMenuController Start");
            }

            void Update()
            {
                if (Menu != null && Menu.PanelObject_.activeInHierarchy && Menu.MenuPanel.IsTop_)
                {
                    G.Sys.MenuPanelManager_.SetBottomLeftActionButton(InputAction.MenuPageUp, "PREVIOUS");
                    G.Sys.MenuPanelManager_.SetBottomLeftActionButton(InputAction.MenuPageDown, "NEXT");

                    if (im.GetKeyUp(InputAction.MenuPageUp, -2))
                    {
                        Log.Success("PREVIOUS");
                    }

                    if (im.GetKeyUp(InputAction.MenuPageDown, -2))
                    {
                        Log.Success("NEXT");
                    }
                }
            }
        }
    }
}
