using Spectrum.API.Logging;

namespace Distance.Translator
{
    public static class CurrentPlugin
    {
        public static Logger Log;

        public static void Initialize()
        {
            Log = new Logger("Distance Translator.log");
            Log.WriteToConsole = true;
        }
    }
}
