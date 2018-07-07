using System;

namespace Distance.Translator.OptionsMenu
{
    public class LanguageMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => Language.PLUGIN_MENU_TITLE;
        public override string Name_ => Language.PLUGIN_MENU_NAME;

        public override bool DisplayInMenu(bool isPauseMenu) => true;

        public override void InitializeVirtual()
        {
            TweakBool(Language.PLUGIN_MENU_RAINBOWMODE,true,(bool value) => { Console.WriteLine("RAINBOW MODE : " + value); }, Language.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);

            base.InitializeVirtual();
        }

        public override void OnPanelPop()
        {
            base.OnPanelPop();
        }
    }
}
