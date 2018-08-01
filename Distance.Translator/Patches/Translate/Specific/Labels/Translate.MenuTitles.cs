using System;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void MenuTitles(ref UILabel label)
        {
            switch (label.transform.parent.parent.name)
            {
                case "General":
                    label.text = Language.OPTIONS_GENERAL_TITLE;
                    break;
                case "Replay":
                    label.text = Language.OPTIONS_REPLAYS_TITLE;
                    break;
            }
        }
    }
}