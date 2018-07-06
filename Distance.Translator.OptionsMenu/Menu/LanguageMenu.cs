using System;

namespace Distance.Translator.OptionsMenu
{
    public class LanguageMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => "Language Settings";
        public override string Name_ => "Language";

        public override bool DisplayInMenu(bool isPauseMenu) => true;

        public override void InitializeVirtual()
        {
            TweakAction("TweakAction", () => { }, "Action");
            TweakBool("TweakBool",true,(value) => { },"Boolean");
            TweakFloat("TweakFloat",0, (value) => { }, "Float");
            TweakInt("TweakInt",5,0,10,5, (value) => { }, "Integer");
        }
    }
}
