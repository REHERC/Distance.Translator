namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void TextureQuality(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "LOW":
                    label.text = Language.OPTIONS_GRAPHICS_TEXTUREQUALITY_LOW;
                    break;
                case "MEDIUM":
                    label.text = Language.OPTIONS_GRAPHICS_TEXTUREQUALITY_MEDIUM;
                    break;
                case "HIGH":
                    label.text = Language.OPTIONS_GRAPHICS_TEXTUREQUALITY_HIGH;
                    break;
                case "ULTRA":
                    label.text = Language.OPTIONS_GRAPHICS_TEXTUREQUALITY_ULTRA;
                    break;
            }
        }
    }
}