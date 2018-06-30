using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void OptionsPanelButtons(UILabel label)
        {
            switch (label.text.ToUpper())
            {
                case "AUDIO":
                    label.text = Language.OPTIONS_AUDIO;
                    break;
                case "GENERAL":
                    label.text = Language.OPTIONS_GENERAL;
                    break;
                case "CONTROLS":
                    label.text = Language.OPTIONS_CONTROLS;
                    break;
                case "GRAPHICS":
                    label.text = Language.OPTIONS_GRAPHICS;
                    break;
                case "PROFILES":
                    label.text = Language.OPTIONS_PROFILES;
                    break;
                case "REPLAY":
                    label.text = Language.OPTIONS_REPLAY;
                    break;
                case "CHEATS":
                    label.text = Language.OPTIONS_CHEATS;
                    break;
            }
        }
    }
}
