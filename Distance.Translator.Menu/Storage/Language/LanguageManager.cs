using System.Collections.Generic;

namespace Distance.Translator.Menu
{
    public static class LanguageManager
    {
        public static List<KeyValuePair<string, string>> Languages;

        public static void InitLanguages()
        {
            Languages = new List<KeyValuePair<string, string>>();
            Languages.Clear();
        }
    }
}
