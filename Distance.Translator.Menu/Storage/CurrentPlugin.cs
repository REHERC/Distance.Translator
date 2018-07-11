using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Logging;

namespace Distance.Translator.Menu
{
    public static class CurrentPlugin
    {
        public static IManager _manager;

        public static void Initialize(IManager manager)
        {
            _manager = manager;
            Log = new Logger("Distance.Translator.Menu.log");
            Log.WriteToConsole = true;
        }

        public static Logger Log;
    }
}
