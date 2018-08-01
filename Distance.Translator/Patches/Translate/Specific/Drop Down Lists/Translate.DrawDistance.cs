namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void DrawDistance(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "NEAR":
                    label.text = Language.OPTIONS_GRAPHICS_DRAWDISTANCE_NEAR;
                    break;
                case "MEDIUM":
                    label.text = Language.OPTIONS_GRAPHICS_DRAWDISTANCE_MEDIUM;
                    break;
                case "FAR":
                    label.text = Language.OPTIONS_GRAPHICS_DRAWDISTANCE_FAR;
                    break;
            }
        }
    }
}