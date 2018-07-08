namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void OptionsPanelButtons(UILabel label)
        {
            switch (label.text.ToUpper())
            {
                case "AUDIO":
                    label.text = LanguageKeys.OPTIONS_AUDIO;
                    break;
                case "GENERAL":
                    label.text = LanguageKeys.OPTIONS_GENERAL;
                    break;
                case "CONTROLS":
                    label.text = LanguageKeys.OPTIONS_CONTROLS;
                    break;
                case "GRAPHICS":
                    label.text = LanguageKeys.OPTIONS_GRAPHICS;
                    break;
                case "PROFILES":
                    label.text = LanguageKeys.OPTIONS_PROFILES;
                    break;
                case "REPLAY":
                    label.text = LanguageKeys.OPTIONS_REPLAY;
                    break;
                case "CHEATS":
                    label.text = LanguageKeys.OPTIONS_CHEATS;
                    break;
                case "VR OPTIONS":
                    label.text = LanguageKeys.OPTIONS_VR;
                    break;
            }
        }
    }
}
