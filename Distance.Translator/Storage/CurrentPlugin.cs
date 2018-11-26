using Spectrum.API.Configuration;
using Spectrum.API.Logging;

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

            Gui_Language = new Settings("Languages/En-en");
            Subtitles_Language = new Settings("Languages/En-en");
        }
    }
}
