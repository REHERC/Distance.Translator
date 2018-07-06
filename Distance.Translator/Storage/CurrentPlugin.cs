using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Configuration;
using Spectrum.API.Logging;
using Spectrum.API.Storage;

namespace Distance.Translator
{
    public static class CurrentPlugin
    {
        public static void initialize()
        {
            Log = new Logger("Distance.Translator.log");
            Log.WriteToConsole = true;
            Config = new Settings("Config");
            InitConfig();


            Lang = new Settings("Languages/" + Config.GetItem<String>("LanguageFile"));
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
                {"LanguageFile", "nothing"},
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
            Config.Save();
        }

        public static Logger Log;
        public static Settings Config;
        public static Settings Lang;
        public static Settings LangDump;
    }
}
