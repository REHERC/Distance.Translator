using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;

namespace Distance.Translator.OptionsMenu
{
    class Photon : IPlugin
    {
        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine("Initializing ... Options Menu");
            CurrentPlugin.initialize();
        }
    }
}
