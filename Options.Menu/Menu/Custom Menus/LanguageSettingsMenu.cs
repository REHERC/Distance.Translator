using Spectrum.MenuSystem.UI;
using System.Collections.Generic;

namespace Options.Menu
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

    public class SpectrumSettingsMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => "Spectrum Extension System";
        public override string Name_ => "Spectrum";

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
            TweakEnum<Language>("Language"
                               , () => Language.English
                               , (lang) => { }
                               , displayNames);

        }

        public override void OnPanelPop()
        {

        }
    }
}
//TweakBool(LanguageKeys.PLUGIN_MENU_RAINBOWMODE, SharedSettings.RAINBOW_MODE, (bool value) => { SharedSettings.RAINBOW_MODE = value; IPCAntenna.SendSetting("DistanceTranslator", "config.rainbow", value); }, LanguageKeys.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);
