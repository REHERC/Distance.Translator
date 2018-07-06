using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Configuration;
using Spectrum.API.Logging;
using Spectrum.API.Storage;

namespace Distance.Translator.OptionsMenu
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
