namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void GhostTypeTranslate(ref UILabel label)
        {
            switch (label.text.ToUpper())
            {
                case "DISABLED":
                    label.text = LanguageKeys.OPTIONS_REPLAYS_TYPE_DISABLED;
                    break;
                case "LOCAL":
                    label.text = LanguageKeys.OPTIONS_REPLAYS_TYPE_LOCAL;
                    break;
                case "FRIENDS":
                    label.text = LanguageKeys.OPTIONS_REPLAYS_TYPE_FRIENDS;
                    break;
                case "NEAR MY RANKING":
                    label.text = LanguageKeys.OPTIONS_REPLAYS_TYPE_NEARMYRANKING;
                    break;
                case "GLOBAL BEST":
                    label.text = LanguageKeys.OPTIONS_REPLAYS_TYPE_GLOBALBEST;
                    break;
            }
        }
    }
}
