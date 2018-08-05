using System;
using Distance.Translator.Menu;
using Spectrum.Menu.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Spectrum.Menu.Menus
{
    public class LanguageSettingsMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => "PLUGIN_MENU_TITLE";
        public override string Name_ => "Language";


        public override bool DisplayInMenu(bool isPauseMenu)
        {
            return !isPauseMenu;
        }
        
        public override void InitializeVirtual()
        {
            Console.WriteLine("LanguageSettingsMenu::InitializeVirtual");

            TweakEnum<string>("PLUGIN MENU LANGUAGE"
                     , () => SharedSettings.CURRENT_LANGUAGE
                     , (string lang) => 
                     {
                         SharedSettings.CURRENT_LANGUAGE = lang;
                         IPCAntenna.SendSetting("DistanceTranslator", "config.language", lang);
                         IPCAntenna.SendCommand("DistanceTranslator", "language-reload");
                     }
                     , "IF YOU CAN READ THIS, THERE IS A BUG SOMEWHERE !"
                     , LanguageManager.Languages.ToArray());


            string PathPrefix = "";
            Scene scene = SceneManager.GetActiveScene();
            switch (scene.name)
            {
                case "MainMenu":
                    PathPrefix = "OptionsFrontRoot";
                    break;
                case "GameMode":
                    PathPrefix = "OptionsFrontRoot(Clone)";
                    break;
            }

            GameObject DescriptionArea = GameObject.Find(PathPrefix + "/Panel - Options/Language/Options/DescriptionArea");
            if (DescriptionArea != null)
            {
                DescriptionArea.Destroy();
            }
        }

        public override void OnPanelPop()
        {

        }
    }
}
