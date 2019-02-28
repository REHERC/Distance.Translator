using static Distance.Translator.CurrentPlugin;
using System;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Harmony;
using System.Reflection;

namespace Distance.Translator
{
    public class Photon : IPlugin,IUpdatable
    {
        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine($"Initializing ... ({ipcIdentifier})");
            CurrentPlugin.Initialize();
            EventSubscriber.Initialize();
            Flags.Initialize();
            ModuleManager.Initialize();
            CurrentPlugin.Log.Success("Initialization done!");
            CurrentPlugin.Log.Info(PluginLogo.GetText());
            try
            {
                CurrentPlugin.Log.Info("Instantiating Harmony Patcher ...");
                HarmonyInstance Harmony = HarmonyInstance.Create("com.REHERC.DistanceTranslator");
                CurrentPlugin.Log.Success("Harmony patcher instantiated!");
                CurrentPlugin.Log.Info("Patching assemblies ...");
                Harmony.PatchAll(Assembly.GetExecutingAssembly());
                CurrentPlugin.Log.Success("Assemblies patched!");
            }
            catch (Exception Archaic)
            {
                CurrentPlugin.Log.Error("Failed to patch the assemblies!");
                CurrentPlugin.Log.Exception(Archaic);
            }

            if (Configuration["Debug"] is true)
            {
                CurrentPlugin.Log.Info("Binding hotkeys actions ...");
                manager.Hotkeys.Bind(Configuration.GetItem<string>("ReloadHotkey"), () => {
                    Language.Reload();
                });
                CurrentPlugin.Log.Success("Hotkeys actions added!");
            }
            //"I love me a good toggle" ~ torcht 2018
        }
        
        public void Update()
        {
            ModuleManager.UpdateAll();
        }
    }
}
