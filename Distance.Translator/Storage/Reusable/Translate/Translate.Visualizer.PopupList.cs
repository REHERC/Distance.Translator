namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void VisualizerTranslate(ref UILabel label)
        {
            switch (label.text.ToUpper())
            {
                case "OFF":
                    label.text = LanguageKeys.OPTIONS_GENERAL_VISUALIZER_OFF;
                    break;
                case "CIRCLE":
                    label.text = LanguageKeys.OPTIONS_GENERAL_VISUALIZER_CIRCLE;
                    break;
                case "BARS":
                    label.text = LanguageKeys.OPTIONS_GENERAL_VISUALIZER_BARS;
                    break;
            }
        }
    }
}
