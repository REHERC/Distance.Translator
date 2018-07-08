using System.Collections.Generic;

namespace Distance.Translator.Menu
{
    public class LanguageInfo
    {
        public string Name { get; }
        public string Author { get; }
        public string File { get; }

        public LanguageInfo(string name,string author,string file)
        {
            this.Name = name;
            this.Author = author;
            this.File = file;
        }
    }

    public static class LanguageManager
    {
        public static Dictionary<string, LanguageInfo> Languages;

        public static void InitLanguages()
        {
            Languages = new Dictionary<string, LanguageInfo>();
            Languages.Clear();
        }
    }
}
