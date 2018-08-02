namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void RealTimeReflections(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "OFF":
                    label.text = Language.OPTIONS_GRAPHICS_REFLECTIONS_OFF;
                    break;
                case "LOW":
                    label.text = Language.OPTIONS_GRAPHICS_REFLECTIONS_LOW;
                    break;
                case "MEDIUM":
                    label.text = Language.OPTIONS_GRAPHICS_REFLECTIONS_MEDIUM;
                    break;
                case "HIGH":
                    label.text = Language.OPTIONS_GRAPHICS_REFLECTIONS_HIGH;
                    break;
                case "ULTRA":
                    label.text = Language.OPTIONS_GRAPHICS_REFLECTIONS_ULTRA;
                    break;
            }
        }
    }
}