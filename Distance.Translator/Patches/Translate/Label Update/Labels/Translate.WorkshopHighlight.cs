using System;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void WorkshopHighlight(ref UILabel label)
        {
            if (label.text == "LOADING...")
            {
                label.text = Language.MAINMENU_WORKSHOP_HIGHLIGHT_LOADING;
            }
            else if (label.text.Length > 52 && label.text.StartsWith("[96B0FF]WORKSHOP HIGHLIGHT[-] - "))
            {
                string levelcount = label.text.Substring(32);
                levelcount = levelcount.Substring(0, levelcount.Length - 20);
                label.text = String.Format(Language.MAINMENU_WORKSHOP_HIGHLIGHT,levelcount);
            }
        }
    }
}