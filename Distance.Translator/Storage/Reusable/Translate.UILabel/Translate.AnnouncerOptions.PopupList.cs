using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void AnnouncerOptionsTranslate(ref UILabel label)
        {
            switch (label.text.ToUpper())
            {
                case "ALL MODES":
                    label.text = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_ALLMODES;
                    break;
                case "ARCADE ONLY":
                    label.text = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_ARCADEONLY;
                    break;
                case "STUNT ONLY":
                    label.text = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_STUNTONLY;
                    break;
                case "DISABLED":
                    label.text = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_DISABLED;
                    break;
            }
        }
    }
}
