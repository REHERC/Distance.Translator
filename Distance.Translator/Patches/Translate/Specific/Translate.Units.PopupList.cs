using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void UnitsTranslate(ref UILabel label)
        {
            switch (label.text.ToUpper())
            {
                case "METRIC":
                    label.text = Language.OPTIONS_GENERAL_UNITS_METRIC;
                    break;
                case "IMPERIAL":
                    label.text = Language.OPTIONS_GENERAL_UNITS_IMPERIAL;
                    break;
            }
        }
    }
}
