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
    public class Photon : IPlugin
    {
        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine("Initializing ...");
            CurrentPlugin.initialize();
            CurrentPlugin.Log.Info("Initialization done!");
            CurrentPlugin.Log.Info("Subscribing to game Events ...");
            Events.Scene.LoadFinish.Subscribe((data) =>
            {
                if (data.sceneName == "MainMenu")
                {
                    Menu.CreateMenu(manager, "LanguageSettingsObject", "OptionsFrontRoot", "MainMenuFrontRoot");
                }
            });
            CurrentPlugin.Log.Info("Subscribed to Events!");


            
        }
    }
}
