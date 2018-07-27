namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void GhostTypeTranslate(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "DISABLED":
                    label.text = Language.OPTIONS_REPLAYS_TYPE_DISABLED;
                    break;
                case "LOCAL":
                    label.text = Language.OPTIONS_REPLAYS_TYPE_LOCAL;
                    break;
                case "FRIENDS":
                    label.text = Language.OPTIONS_REPLAYS_TYPE_FRIENDS;
                    break;
                case "NEAR MY RANKING":
                    label.text = Language.OPTIONS_REPLAYS_TYPE_NEARMYRANKING;
                    break;
                case "GLOBAL BEST":
                    label.text = Language.OPTIONS_REPLAYS_TYPE_GLOBALBEST;
                    break;
            }
        }
    }
}
