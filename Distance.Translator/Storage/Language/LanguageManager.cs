﻿using System.Collections.Generic;
using System.IO;
using Spectrum.API.Configuration;
using Spectrum.API.Storage;

namespace Distance.Translator
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
        public static List<LanguageInfo> Languages;

        public static void DetectLanguages()
        {
            Languages = new List<LanguageInfo>();
            Languages.Clear();

            FileSystem FS = new FileSystem();
            string PluginDir = FS.RootDirectory;
            Settings Language;

            Languages.Add(new LanguageInfo("English (default)", "Refract Studios", ":default:"));
            foreach (string LanguageFile in Directory.GetFiles(PluginDir + "\\Settings\\Languages","*.json"))
            {
                string file = LanguageFile.Split('\\').Last();
                file = file.Substring(0,file.Length - 5);
                Language = new Settings(file);
                
                string name = "language name";
                string author = "language author";
                if (Language.ContainsKey("language.name")) { name = Language.GetItem<string>("language.name"); }
                if (Language.ContainsKey("language.author")) { name = Language.GetItem<string>("language.author"); }

                Languages.Add(new LanguageInfo(name, author,file));
            }
        }

        public static void SendLanguages()
        {
            foreach (LanguageInfo language in Languages)
            {
                IPCAntenna.SendLanguageAdd("DistanceTranslatorOptionsMenu",language.Name,language.Author,language.File);
            }
        }
    }
}
