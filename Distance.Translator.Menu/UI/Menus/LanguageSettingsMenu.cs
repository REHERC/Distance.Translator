using System.Collections.Generic;
using Distance.Translator.Menu;
using Spectrum.Menu.UI;

namespace Spectrum.Menu.Menus
{
    public class LanguageSettingsMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => LanguageKeys.PLUGIN_MENU_TITLE;
        public override string Name_ => LanguageKeys.PLUGIN_MENU_NAME;

        public override bool DisplayInMenu(bool isPauseMenu) => true;

        public override void InitializeVirtual()
        {
            CurrentPlugin.Log.Warning("Listing all languages");
            foreach (KeyValuePair<string, string> lang in LanguageManager.Languages)
            {
                CurrentPlugin.Log.Warning($"{lang.Key} | {lang.Value}");
            }


            /*
            TweakEnum<string>(LanguageKeys.PLUGIN_MENU_LANGUAGE
                     , () => SharedSettings.CURRENT_LANGUAGE
                     , (string lang) => {
                         SharedSettings.CURRENT_LANGUAGE = lang;
                         IPCAntenna.SendSetting("DistanceTranslator", "config.language", lang);
                     }
                     , LanguageKeys.PLUGIN_MENU_LANGUAGE_DESCRIPTION
                     , LanguageManager.Languages.ToArray());
                     */

             TweakBool(LanguageKeys.PLUGIN_MENU_RAINBOWMODE
                     , SharedSettings.RAINBOW_MODE
                     , (bool value) => {
                         SharedSettings.RAINBOW_MODE = value;
                         IPCAntenna.SendSetting("DistanceTranslator", "config.rainbow", value);
                     }
                     , LanguageKeys.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);
        }

        public List<KeyValuePair<string, string>> LanguageList = new List<KeyValuePair<string, string>>(){
            KVP<string,string>("English",":default:"),
            KVP<string,string>("Français","FR-fr"),
            KVP<string,string>("BEAN","NOPE")
        };

        public override void OnPanelPop()
        {

        }
    }
}
