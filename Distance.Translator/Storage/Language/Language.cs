using static Distance.Translator.CurrentPlugin;
using Spectrum.API.Configuration;
using System;
using System.IO;

namespace Distance.Translator
{
    public static class Language
    {
        public static string GetLine(string key)
        {
            bool issubtitle = key.StartsWith("subtitles");

            Settings source = issubtitle ? Subtitles_Language : Gui_Language;

            return source.ContainsKey(key) ? source.GetItem<string>(key) : $"{key}";
        }

        public static bool GetBool(string key, bool default_value = false)
        {
            bool issubtitle = key.StartsWith("subtitles");

            Settings source = issubtitle ? Subtitles_Language : Gui_Language;

            return source.ContainsKey(key) ? source.GetItem<bool>(key) : default_value;
        }

        public static float GetFloat(string key, float default_value = 1.0f)
        {
            bool issubtitle = key.StartsWith("subtitles");

            Settings source = issubtitle ? Subtitles_Language : Gui_Language;

            return source.ContainsKey(key) ? source.GetItem<float>(key) : default_value;
        }

        public static void Reload()
        {
            Load();
            ModuleManager.ResetAll();
        }

        public static void Load()
        {
            if (Configuration["Debug"] is true)
                Log.Info("Loading languages");

            Gui_Language = new Settings($"Languages/{Configuration["InterfaceLanguage"].ToString()}");
            Subtitles_Language = new Settings($"Languages/{Configuration["SubtitlesLanguage"].ToString()}");
        }

        public static FileSystemWatcher FileWatch;

        public static void InitWatcher()
        {
            FileWatch = new FileSystemWatcher
            {
                Path = LanguageFilesPath
            };

            FileWatch.Changed += new FileSystemEventHandler(LanguageFileUpdated);

            FileWatch.EnableRaisingEvents = true;
        }

        public static void LanguageFileUpdated(object source, FileSystemEventArgs e)
        {
            string InterfaceLanguagePath = $@"{LanguageFilesPath}\{Configuration.GetItem<string>("InterfaceLanguage")}.json";
            string SubtitlesLanguagePath = $@"{LanguageFilesPath}\{Configuration.GetItem<string>("SubtitlesLanguage")}.json";
            
            if (e.FullPath == InterfaceLanguagePath
            ||  e.FullPath == SubtitlesLanguagePath)
            {
                if (Configuration["Debug"] is true)
                    Log.Warning("Language file modification detected !");
                Reload();
            }
        }
    }
}
