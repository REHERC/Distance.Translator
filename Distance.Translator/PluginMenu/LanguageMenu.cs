using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance.Translator
{
    class LanguageMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => "Translator Settings";
        public override string Name_ => "Language";
        public override bool DisplayInMenu(bool isPauseMenu) => true;

        public override void InitializeVirtual()
        {
            TweakBool("Rainbow",CurrentPlugin.Config.GetItem<bool>("Rainbow"),(bool value) => {
                CurrentPlugin.Config["Rainbow"] = value;
                CurrentPlugin.Config.Save();
                Language.Initialize();
            });
        }
    }
}
