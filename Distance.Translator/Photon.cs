using static Distance.Translator.CurrentPlugin;
using System;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Harmony;
using System.Reflection;
using Spectrum.API.GUI.Data;
using Spectrum.API.GUI.Controls;

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
            Log.Success("Initialization done!");
            Log.Info(PluginLogo.GetText());
            try
            {
                Log.Info("Instantiating Harmony Patcher ...");
                HarmonyInstance Harmony = HarmonyInstance.Create("com.REHERC.DistanceTranslator");
                Log.Success("Harmony patcher instantiated!");
                Log.Info("Patching assemblies ...");
                Harmony.PatchAll(Assembly.GetExecutingAssembly());
                Log.Success("Assemblies patched!");
            }
            catch (Exception Archaic)
            {
                Log.Error("Failed to patch the assemblies!");
                Log.Exception(Archaic);
            }

            if (Configuration["Debug"] is true)
            {
                Log.Info("Binding hotkeys actions ...");
                manager.Hotkeys.Bind(Configuration.GetItem<string>("ReloadHotkey"), () => {
                    Language.Reload();
                });
                Log.Success("Hotkeys actions added!");
            }

            MenuTree SettingsMenu = new MenuTree("distancetranslator.main", "LANGUAGE SETTINGS");

            SettingsMenu.Add(new ListBox<string>(MenuDisplayMode.Both, "distancetranslator.main.interfacelanguage", "INTERFACE LANGUAGE")
                .WithGetter(() => Configuration["InterfaceLanguage"].ToString())
                .WithSetter((value) =>
                {
                    Configuration["InterfaceLanguage"] = value;
                    Configuration.Save();
                    Language.Reload();
                })
                .WithEntries(LanguageFiles)
            );

            SettingsMenu.Add(new ListBox<string>(MenuDisplayMode.Both, "distancetranslator.main.subtitleslanguage", "SUBTITLES LANGUAGE")
                .WithGetter(() => Configuration["SubtitlesLanguage"].ToString())
                .WithSetter((value) =>
                {
                    Configuration["SubtitlesLanguage"] = value;
                    Configuration.Save();
                    Language.Reload();
                })
                .WithEntries(LanguageFiles)
            );

            manager.Menus.AddMenu(MenuDisplayMode.Both, SettingsMenu);

            //"I love me a good toggle" ~ torcht 2018
        }
        
        public void Update()
        {
            ModuleManager.UpdateAll();
        }
    }
}
