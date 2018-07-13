using System;
using System.Collections.Generic;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;
using Spectrum.Menu;
using Spectrum.Menu.Menus;
using UnityEngine;

namespace Distance.Translator.Menu
{
    public partial class Photon : IPlugin, IIPCEnabled
    {
        public void HandleIPCData(IPCData data)
        {
            IPCAntenna.RecieveData(data);
        }

        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine($"Initializing ... ({ipcIdentifier})");
            CurrentPlugin.Initialize(manager);
            LanguageManager.InitLanguages();
            IPCAntenna.initialize(manager, ipcIdentifier);
            CurrentPlugin.Log.Info("Initialization done!");
            CurrentPlugin.Log.Info("Subscribing to Events ...");
            
            CurrentPlugin.Log.Info("Subscribed to Events!");
            CurrentPlugin.Log.Info("Starting IPC ...");
            IPCAntenna.SendAwake("DistanceTranslator");
            CurrentPlugin.Log.Info("IPC done!");
        }
    }
}
