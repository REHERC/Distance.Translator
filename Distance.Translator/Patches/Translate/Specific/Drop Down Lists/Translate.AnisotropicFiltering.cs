namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void AbnisotropicFiltering(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "OFF":
                    label.text = Language.OPTIONS_GRAPHICS_ANISOTROPICFILTERING_OFF;
                    break;
                case "PARTIAL":
                    label.text = Language.OPTIONS_GRAPHICS_ANISOTROPICFILTERING_PARTIAL;
                    break;
                case "FULL":
                    label.text = Language.OPTIONS_GRAPHICS_ANISOTROPICFILTERING_FULL;
                    break;
            }
        }
    }
}