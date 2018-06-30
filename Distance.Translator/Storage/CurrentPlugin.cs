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
            Lang = new Settings(Config.GetItem<String>("LanguageFile"));
            if (Config.GetItem<bool>("Dump"))
            {
                LangDump = new Settings("EN-en");
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

        public static Logger Log;
        public static Settings Config;
        public static Settings Lang;
        public static Settings LangDump;
    }
}
