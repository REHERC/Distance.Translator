using Spectrum.API.Configuration;
using Spectrum.API.Logging;
using System.Collections.Generic;

namespace Distance.Translator
{
    public static class CurrentPlugin
    {
        public static Logger Log;
        public static Settings Configuration;

        public static Settings Gui_Language;
        public static Settings Subtitles_Language;


        public static void Initialize()
        {
            Log = new Logger("Distance Translator.log")
            {
                WriteToConsole = true
            };

            Configuration = new Settings("Config");

            Dictionary<string, object> DefaultSettings = new Dictionary<string, object>()
            {
                {"InterfaceLanguage", ":default:"},
                {"SubtitlesLanguage", ":default:"},
                {"Debug", false}
            };
            
            foreach (KeyValuePair<string, object> item in DefaultSettings)
            {
                if (!Configuration.ContainsKey<string>(item.Key))
                {
                    Configuration[item.Key] = item.Value;
                }
            }

            Configuration.Save();

            Gui_Language = new Settings("Languages/En-en");
            Subtitles_Language = new Settings("Languages/En-en");
        }
    }
}
