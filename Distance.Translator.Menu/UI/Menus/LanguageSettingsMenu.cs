using System.Collections.Generic;
using Distance.Translator.Menu;
using Spectrum.Menu.UI;
using UnityEngine.SceneManagement;

namespace Spectrum.Menu.Menus
{
    public class LanguageSettingsMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => LanguageKeys.PLUGIN_MENU_TITLE;
        public override string Name_ => "Language";


        public override bool DisplayInMenu(bool isPauseMenu)
        {
            return true;
        }
        
        public override void InitializeVirtual()
        {
            TweakEnum<string>(LanguageKeys.PLUGIN_MENU_LANGUAGE
                     , () => SharedSettings.CURRENT_LANGUAGE
                     , (string lang) => 
                     {
                         SharedSettings.CURRENT_LANGUAGE = lang;
                         IPCAntenna.SendSetting("DistanceTranslator", "config.language", lang);
                     }
                     , LanguageKeys.PLUGIN_MENU_LANGUAGE_DESCRIPTION
                     , LanguageManager.Languages.ToArray());

            TweakBool(LanguageKeys.PLUGIN_MENU_RAINBOWMODE
                     , SharedSettings.RAINBOW_MODE
                     , (bool value) => 
                     {
                         SharedSettings.RAINBOW_MODE = value;
                         IPCAntenna.SendSetting("DistanceTranslator", "config.rainbow", value);
                     }
                     , LanguageKeys.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);
            
            TweakAction(LanguageKeys.PLUGIN_MENU_LANGUAGE_UPDATE
                       , () => 
                       {
                           Scene scene = SceneManager.GetActiveScene();
                           if (scene.name == "MainMenu")
                           {
                               G.Sys.MenuPanelManager_.ShowOkCancel(LanguageKeys.PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_MESSAGE, LanguageKeys.PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_TITLE, () =>
                               {
                                   IPCAntenna.SendCommand("DistanceTranslator", "language-reload");
                               });
                           }
                           else
                           {
                               G.Sys.MenuPanelManager_.ShowError(LanguageKeys.PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_UNAVAILABLE_MESSAGE,LanguageKeys.PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_UNAVAILABLE_TITLE);
                           }
                       }
                       , LanguageKeys.PLUGIN_MENU_LANGUAGE_UPDATE_DESCRIPTION);
                       
        }

        public override void OnPanelPop()
        {

        }
    }
}
