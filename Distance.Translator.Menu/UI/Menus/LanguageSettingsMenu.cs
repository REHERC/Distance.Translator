using System.Collections.Generic;
using Distance.Translator.Menu;
using Spectrum.Menu.UI;

namespace Spectrum.Menu.Menus
{
    public enum Language
    {
        English,
        French,
        German,
        Japanese,
        Chinese,
        Spanish
    }

    public class LanguageSettingsMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => LanguageKeys.PLUGIN_MENU_TITLE;
        public override string Name_ => LanguageKeys.PLUGIN_MENU_NAME;

        public override bool DisplayInMenu(bool isPauseMenu) => true;

        public KeyValuePair<string, Language>[] displayNames =
            new KeyValuePair<string, Language>[] { KVP<string,Language>("English",Language.English)
                                                 , KVP<string,Language>("Français",Language.French)
                                                 , KVP<string,Language>("Deutsch",Language.German)
                                                 , KVP<string,Language>("日本語",Language.Japanese)
                                                 , KVP<string,Language>("中文",Language.Chinese)
                                                 , KVP<string,Language>("Español",Language.Spanish)
                                                 };

        public override void InitializeVirtual()
        {
            TweakEnum<Language>(LanguageKeys.PLUGIN_MENU_LANGUAGE
                               , () => Language.English
                               , (lang) => { }
                               , LanguageKeys.PLUGIN_MENU_LANGUAGE_DESCRIPTION
                               , displayNames);
            TweakBool(LanguageKeys.PLUGIN_MENU_RAINBOWMODE, SharedSettings.RAINBOW_MODE, (bool value) => { SharedSettings.RAINBOW_MODE = value; IPCAntenna.SendSetting("DistanceTranslator", "config.rainbow", value); }, LanguageKeys.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);


        }

        public override void OnPanelPop()
        {

        }
    }
}
