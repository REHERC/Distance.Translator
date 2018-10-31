using System;
using System.Collections.Generic;

namespace Distance.Translator
{
    public static class ModuleManager
    {
        public static List<TranslateModule> Modules;
        
        public static void Initialize()
        {
            Modules = new List<TranslateModule>();

            Modules.Add(new MainMenuModule());
            Modules.Add(new IdleMenuModule());

            Modules.Add(new ArcadeSubMenuModule());
            Modules.Add(new MultiplayerSubMenuModule());
            Modules.Add(new WorkshopSubMenuModule());
            Modules.Add(new OptionsSubMenuModule());

            Modules.Add(new AudioSettingsModule());
            Modules.Add(new GeneralSettingsModule());

            Modules.Add(new GraphicsSettingsModule());

            Modules.Add(new ReplaySettingsModule());

            ListModules();
        }

        private static void ListModules()
        {
            CurrentPlugin.Log.SuccessColor = ConsoleColor.Cyan;
            CurrentPlugin.Log.Success($"Currently loaded modules : {Modules.Count}");
            foreach (TranslateModule Module in Modules)
            {
                CurrentPlugin.Log.Success($"\"{Module.Name}\"");
            }
            CurrentPlugin.Log.SuccessColor = ConsoleColor.Green;
        }

        public static void ResetAll()
        {
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
