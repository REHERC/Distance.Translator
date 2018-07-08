using System;
using System.Collections.Generic;
using UnityEngine;

namespace Distance.Translator.OptionsMenu
{
    public class LanguageMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => Language.PLUGIN_MENU_TITLE;
        public override string Name_ => Language.PLUGIN_MENU_NAME;

        public override bool DisplayInMenu(bool isPauseMenu) => true;
        
        public override void OnPanelPop()
        {

        }

        public override void InitializeVirtual()
        {
            TweakBool(Language.PLUGIN_MENU_RAINBOWMODE,SharedSettings.RAINBOW_MODE,(bool value) => { SharedSettings.RAINBOW_MODE = value; IPCAntenna.SendSetting("DistanceTranslator", "config.rainbow", value); }, Language.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);

            TweakEnum<Languages>("Language"
                                , () => Languages.English
                                , (units) => { }
                                , displayNames);
        }


        public KeyValuePair<string, Languages>[] displayNames =
 new KeyValuePair<string, Languages>[] { KVP<string,Languages>("English",Languages.English)
                                                  , KVP<string,Languages>("Français",Languages.French)
                                                  , KVP<string,Languages>("Deutsch",Languages.German)
                                                  , KVP<string,Languages>("日本語",Languages.Japanese)
                                                  , KVP<string,Languages>("中文",Languages.Chinese)
                                                  };
    }

    public enum Languages
    {
        English,
        French,
        German,
        Japanese,
        Chinese
    }
}
