namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void GenericOnOff(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "ON":
                    label.text = Language.OPTIONS_GENERIC_ON;
                    break;
                case "OFF":
                    label.text = Language.OPTIONS_GENERIC_OFF;
                    break;
            }
        }
    }
}
