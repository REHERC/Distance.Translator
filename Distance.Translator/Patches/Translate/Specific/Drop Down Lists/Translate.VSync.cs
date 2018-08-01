namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void VSync(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "ENABLED":
                    label.text = Language.OPTIONS_GENERIC_ENABLED;
                    break;
                case "OFF":
                    label.text = Language.OPTIONS_GENERIC_OFF;
                    break;
            }
        }
    }
}