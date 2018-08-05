using System;
using System.Reflection;
using Harmony;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;
using UnityEngine;

namespace Distance.Translator
{
    public partial class Photon : IPlugin,IIPCEnabled,IUpdatable
    {
        public void HandleIPCData(IPCData data)
        {
            IPCAntenna.RecieveData(data);
        }

        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine($"Initializing ... ({ipcIdentifier})");
            CurrentPlugin.Initialize();
            TranslationManager.Initialize();
            IPCAntenna.initialize(manager,ipcIdentifier);
            CurrentPlugin.Log.Info("Initialization done!");
            PrintLogo();
            
            try
            {
                CurrentPlugin.Log.Info("Instantiating Harmony Patcher ...");
                HarmonyInstance Harmony = HarmonyInstance.Create("com.REHERC.DistanceTranslator");
                CurrentPlugin.Log.Info("Harmony patcher instantiated!");
                CurrentPlugin.Log.Info("Patching assemblies ...");
                Harmony.PatchAll(Assembly.GetExecutingAssembly());
                CurrentPlugin.Log.Info("Assemblies patched!");
            }
            catch (Exception VirusSpirit)
            {
                CurrentPlugin.Log.Error("Failed to patch the assemblies!");
                CurrentPlugin.Log.Exception(VirusSpirit);
                
            }
            CurrentPlugin.Log.Info("Subscribing to Events ...");
            Events.Scene.StartLoad.Subscribe((data) =>
            {
                TranslationManager.Reset();
            });
            Events.Scene.LoadFinish.Subscribe((data) =>
            {
                TranslationManager.Reset();

                if (data.sceneName == "MainMenu")
                {
                    Spectrum.Interop.Game.Game.WatermarkText += "\n";
                }
            });
            CurrentPlugin.Log.Info("Subscribed to Events!");
        }

        public void PrintLogo()
        {
            foreach (string line in BootLogo.GetText().Split(Environment.NewLine[0]))
            {
                CurrentPlugin.Log.Info(line);
            }
        }

        public void Update()
        {
            UpdateEveryFrame.Swoosh();
        }
    }
}
