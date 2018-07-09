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
            TweakEnum<string>(LanguageKeys.PLUGIN_MENU_LANGUAGE
                     , () => SharedSettings.CURRENT_LANGUAGE
                     , (string lang) => {
                         SharedSettings.CURRENT_LANGUAGE = lang;
                         IPCAntenna.SendSetting("DistanceTranslator", "config.language", lang);
                     }
                     , LanguageKeys.PLUGIN_MENU_LANGUAGE_DESCRIPTION
                     , LanguageManager.Languages.ToArray());

            TweakBool(LanguageKeys.PLUGIN_MENU_RAINBOWMODE
                     , SharedSettings.RAINBOW_MODE
                     , (bool value) => {
                         SharedSettings.RAINBOW_MODE = value;
                         IPCAntenna.SendSetting("DistanceTranslator", "config.rainbow", value);
                     }
                     , LanguageKeys.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);
        }

        public override void OnPanelPop()
        {

        }
    }
}
