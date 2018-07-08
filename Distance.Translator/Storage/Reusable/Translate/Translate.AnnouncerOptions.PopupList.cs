namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void AnnouncerOptionsTranslate(ref UILabel label)
        {
            switch (label.text.ToUpper())
            {
                case "ALL MODES":
                    label.text = LanguageKeys.OPTIONS_AUDIO_ANNOUNCERSETTINGS_ALLMODES;
                    break;
                case "ARCADE ONLY":
                    label.text = LanguageKeys.OPTIONS_AUDIO_ANNOUNCERSETTINGS_ARCADEONLY;
                    break;
                case "STUNT ONLY":
                    label.text = LanguageKeys.OPTIONS_AUDIO_ANNOUNCERSETTINGS_STUNTONLY;
                    break;
                case "DISABLED":
                    label.text = LanguageKeys.OPTIONS_AUDIO_ANNOUNCERSETTINGS_DISABLED;
                    break;
            }
        }
    }
}
