using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Configuration;
using Spectrum.API.Storage;

namespace Options.Menu
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
