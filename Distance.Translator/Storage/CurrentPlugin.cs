using System.Collections.Generic;
using System.IO;
using Spectrum.API.Configuration;
using Spectrum.API.Logging;
using Spectrum.API.Storage;

namespace Distance.Translator
{
    public static class CurrentPlugin
    {
        public static void Initialize()
        {
            Log = new Logger("Distance.Translator.log");
            Log.WriteToConsole = true;
            Config = new Settings("Config");
            InitConfig();
            
            if (Config.GetItem<bool>("Dump"))
            {
                LangDump = new Settings("Language-defaults");
                LangDump.Save();
            }
            
            Language.Initialize();
            SaveDump();
        }

        public static void SaveDump()
        {
            if (CurrentPlugin.Config.GetItem<bool>("Dump"))
            {
                CurrentPlugin.LangDump.Save();
                CurrentPlugin.Config["Dump"] = false;
                CurrentPlugin.Config.Save();
            }
        }

        public static void InitConfig()
        {
            var DefaultConfig = new Dictionary<string, object>
            {
                {"LanguageFile", ":default:"},
                {"Rainbow", false},
                {"Dump", false}
            };

            foreach (var entry in DefaultConfig)
            {
                if (!Config.ContainsKey(entry.Key))
                {
                    Config.Add(entry.Key, entry.Value);
                }
            }

            FileSystem Files = new FileSystem();
            string Lang = Config.GetItem<string>("LanguageFile");
            if (!DefaultLanguages.Contains(Lang) && !File.Exists($@"{Files.RootDirectory}\Settings\Languages\{Lang}.json"))
            {
                Config["LanguageFile"] = ":default:";
            }

            Config.Save();
        }

        public static List<string> DefaultLanguages = new List<string>() {
            ":default:",
            ":debug:"
        };

        public static Logger Log;
        public static Settings Config;
        public static Settings Lang;
        public static Settings LangDump;
    }
}
