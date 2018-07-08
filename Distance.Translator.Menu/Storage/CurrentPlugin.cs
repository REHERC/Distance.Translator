using Spectrum.API.Logging;

namespace Distance.Translator.Menu
{
    public static class CurrentPlugin
    {
        public static void initialize()
        {
            Log = new Logger("Distance.Translator.OptionsMenu.log");
            Log.WriteToConsole = true;
        }

        public static Logger Log;
    }
}
