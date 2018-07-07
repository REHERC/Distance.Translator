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

        public int langID = 0;

        public KeyValuePair<string,LanguageInfo>[] LanguageEntries()
        {
            return LanguageManager.Languages.ToArray();
        }

        public override void InitializeVirtual()
        {
            TweakBool(Language.PLUGIN_MENU_RAINBOWMODE,SharedSettings.RAINBOW_MODE,(bool value) => { SharedSettings.RAINBOW_MODE = value; IPCAntenna.SendSetting("DistanceTranslator", "config.rainbow", value); }, Language.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);
            

            //TweakEnum<int>("Language", () => { return langID; }, x => langID = x, "Some language", new KeyValuePair<String, int>[] { new KeyValuePair<string, int>("FR", 0), new KeyValuePair<string, int>("EN", 1) });
            
        }
    }
}
