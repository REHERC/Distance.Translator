using System;
using System.Collections.Generic;
using UnityEngine;
using Spectrum.MenuSystem;
using Spectrum.MenuSystem.UI;

namespace Options.Menu
{
    public class LanguageMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => LanguageKeys.PLUGIN_MENU_TITLE;
        public override string Name_ => LanguageKeys.PLUGIN_MENU_NAME;

        public override bool DisplayInMenu(bool isPauseMenu) => true;
        
        public override void OnPanelPop()
        {

        }

        public override void InitializeVirtual()
        {
            TweakBool(LanguageKeys.PLUGIN_MENU_RAINBOWMODE,SharedSettings.RAINBOW_MODE,(bool value) => { SharedSettings.RAINBOW_MODE = value; IPCAntenna.SendSetting("DistanceTranslator", "config.rainbow", value); }, LanguageKeys.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);
            
        }
    }
}
