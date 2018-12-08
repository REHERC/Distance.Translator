using static Distance.Translator.CurrentPlugin;
using Distance.Translator.Modules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Distance.Translator
{
    public static class ModuleManager
    {
        public static List<TranslateModule> Modules;

        public static Dictionary<string, Type> DynamicModules;
        public static Dictionary<string, Func<UILabel, DynamicTranslateModule>> DynamicChecks;

        public static event Action OnResetAll;

        public static void Initialize()
        {
            Modules = new List<TranslateModule>
            {
                new MainMenuModule(),
                new IdleMenuModule(),

                new ArcadeSubMenuModule(),

                new TrackmogrifyPanelModule(),
                new MultiplayerSubMenuModule(),
                new WorkshopSubMenuModule(),
                new OptionsSubMenuModule(),

                new AudioSettingsModule(),
                new GeneralSettingsModule(),

                new GraphicsSettingsModule(),

                new ReplaySettingsModule()
            };

            DynamicModules = new Dictionary<string, Type>();

            foreach (var module in from module in new List<Type>() {
                typeof(GeneralUnitsDropDownModule),
                typeof(GeneralVisualizerDropDownModule),
                typeof(GeneralCameraSplitDropDownModule)
            } where module.IsSubclassOf(typeof(DynamicTranslateModule)) select module) {
                DynamicTranslateModule module_instance = Activator.CreateInstance(module) as DynamicTranslateModule;
                DynamicModules.Add(module_instance.Name, module);
            }

            DynamicChecks = new Dictionary<string, Func<UILabel, DynamicTranslateModule>>() {
                {"General Settings Units Drop-Down", (UILabel instance) => { return ModuleChecks.General_Units_DropDown(ref instance); }},
                {"General Settings Car Screen Visualizer Drop-Down", (UILabel instance) => { return ModuleChecks.General_Visualizer_DropDown(ref instance); }},
                {"General Settings Split-Screen Camera Split Drop-Down", (UILabel instance) => { return ModuleChecks.General_CameraSplit_DropDown(ref instance); }}
            };
            
            ListModules();
        }

        private static void ListModules()
        {
            Log.SuccessColor = ConsoleColor.Cyan;
            Log.Warning($"Currently loaded elements : {Modules.Count + DynamicModules.Count + DynamicChecks.Count}");
            Log.Warning($"  {Modules.Count} Class modules (static) :");
            foreach (TranslateModule Module in Modules)
            {
                Log.Success($"   - \"{Module.Name}\"");
                if (Configuration["Debug"] is true)
                {
                    Log.Info($"{Module.GetType().FullName}");
                    Console.WriteLine();
                }
            }
            Log.Warning($"  {DynamicModules.Count} Type reference modules (dynamic) :");
            foreach (var Module in DynamicModules)
            {
                Log.Success($"   - \"{Module.Key}\"");
                if (Configuration["Debug"] is true)
                {
                    Log.Info($"{Module.Value.FullName}");
                    Console.WriteLine();
                }
            }
            Log.Warning($"  {DynamicChecks.Count} Dynamic modules context checks :");
            foreach (var Check in DynamicChecks)
            {
                Log.Success($"   - \"{Check.Key} (Check function)\"");
                if (Configuration["Debug"] is true)
                {
                    Log.Info($"{Check.Value.Method.Name}");
                    Log.Info($"{Check.Value.Method.ReflectedType.FullName}");
                    Console.WriteLine();
                }
            }
            Log.SuccessColor = ConsoleColor.Green;
        }

        public static void ResetAll()
        {
            OnResetAll();
            foreach (TranslateModule Module in Modules)
            {
                Module.Initialize();
                Module.Enable();
            }
        }

        public static void UpdateAll()
        {
            foreach(TranslateModule Module in Modules)
            {
                if (Module.IsEnabled())
                {
                    try
                    {
                        Module.Run();
                    }
#pragma warning disable CS0168 // Variable is declared but never used
                    catch (Exception ThatsTooBad) { }
#pragma warning restore CS0168 // Variable is declared but never used
                }
            }
        }
    }
}
