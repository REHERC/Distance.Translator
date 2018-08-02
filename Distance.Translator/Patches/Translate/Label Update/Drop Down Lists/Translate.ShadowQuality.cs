namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void ShadowQuality(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "OFF":
                    label.text = Language.OPTIONS_GRAPHICS_SHADOWQUALITY_OFF;
                    break;
                case "LOW":
                    label.text = Language.OPTIONS_GRAPHICS_SHADOWQUALITY_LOW;
                    break;
                case "MEDIUM":
                    label.text = Language.OPTIONS_GRAPHICS_SHADOWQUALITY_MEDIUM;
                    break;
                case "HIGH":
                    label.text = Language.OPTIONS_GRAPHICS_SHADOWQUALITY_HIGH;
                    break;
                case "ULTRA":
                    label.text = Language.OPTIONS_GRAPHICS_SHADOWQUALITY_ULTRA;
                    break;
            }
        }
    }
}