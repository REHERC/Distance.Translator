using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Configuration;
using Spectrum.API.Logging;

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
            Language.Initialize();
        }

        public static Logger Log;
        public static Settings Config;
        public static Settings Lang;
    }
}
