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
    public class Photon : IPlugin,IIPCEnabled
    {
        public void HandleIPCData(IPCData data)
        {
            IPCAntenna.RecieveData(data);
        }

        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine("Initializing ...");
            CurrentPlugin.initialize();
            LanguageManager.InitLanguages();
            IPCAntenna.initialize(manager,ipcIdentifier);
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
            CurrentPlugin.Log.Info("Starting IPC ...");
            IPCAntenna.SendAwake("DistanceTranslator");
            CurrentPlugin.Log.Info("IPC done!");
        }
    }
}
