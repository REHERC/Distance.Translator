﻿using Spectrum.API.Configuration;
using Spectrum.API.Logging;
using Spectrum.API.Storage;
using System.Collections.Generic;
using System.IO;

namespace Distance.Translator
{
    public static class CurrentPlugin
    {
        public static Dictionary<string, string> LanguageFiles;

        public static FileSystem Plugin;

        public static Logger Log;
        public static Settings Configuration;

        public static Settings Gui_Language;
        public static Settings Subtitles_Language;
        
        public static void Initialize()
        {
            Plugin = new FileSystem();

            Log = new Logger("Distance Translator.log")
            {
                WriteToConsole = true
            };

            Configuration = new Settings("Config");

            Dictionary<string, object> DefaultSettings = new Dictionary<string, object>()
            {
                {"InterfaceLanguage", "EN-en"},
                {"SubtitlesLanguage", "EN-en"},
                {"Debug", false}
            };
            
            foreach (KeyValuePair<string, object> item in DefaultSettings)
                if (!Configuration.ContainsKey<string>(item.Key))
                    Configuration[item.Key] = item.Value;

            Configuration.Save();

            MakeLanguageList();

            Language.Load();
        }

        public static void MakeLanguageList()
        {
            LanguageFiles = new Dictionary<string, string>();

            string LanguageFilesPath = $@"{Plugin.RootDirectory}\Settings\Languages";
            
            foreach (string file in Directory.GetFiles(LanguageFilesPath, "*.json"))
            {
                string filename = Path.GetFileNameWithoutExtension(file);
                Settings lang = new Settings($"Languages/{filename}");

                if (lang.ContainsKey<string>("language.name") && lang.ContainsKey<string>("language.author"))
                {
                    string langname = $"{lang["language.name"].ToString()} [007d96]({lang["language.author"].ToString()})[-]";
                    LanguageFiles.Add(langname, filename);
                }
            }
        }
    }
}
