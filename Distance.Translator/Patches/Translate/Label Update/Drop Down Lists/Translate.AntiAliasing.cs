namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void AntiAliasing(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "OFF":
                    label.text = Language.OPTIONS_GRAPHICS_ANTIALIASING_OFF;
                    break;
                case "FXAA FAST":
                    label.text = Language.OPTIONS_GRAPHICS_ANTIALIASING_FXAAFAST;
                    break;
                case "FXAA QUALITY":
                    label.text = Language.OPTIONS_GRAPHICS_ANTIALIASING_FXAAQUALITY;
                    break;
            }
        }
    }
}