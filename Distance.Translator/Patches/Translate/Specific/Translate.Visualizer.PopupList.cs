namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void VisualizerTranslate(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "OFF":
                    label.text = Language.OPTIONS_GENERAL_VISUALIZER_OFF;
                    break;
                case "CIRCLE":
                    label.text = Language.OPTIONS_GENERAL_VISUALIZER_CIRCLE;
                    break;
                case "BARS":
                    label.text = Language.OPTIONS_GENERAL_VISUALIZER_BARS;
                    break;
            }
        }
    }
}
