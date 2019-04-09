using static Distance.Translator.CurrentPlugin;
using Distance.Translator.Modules;
using System;
using System.Collections.Generic;

namespace Distance.Translator
{
    public static partial class ModuleManager
    {
        public static List<TranslateModule> Modules;
        
        public static Dictionary<string, Func<UILabel, DynamicTranslateModule>> DynamicChecks;

#pragma warning disable CA1009
        public static event Action OnResetAll;
#pragma warning restore CA1009

        public static void Initialize()
        {
            Modules = new List<TranslateModule>
            {
                new MainMenuModule(),
                new PauseMenuModule(),
                new IdleMenuModule(),

                new ArcadeSubMenuModule(),

                new TrackmogrifyPanelModule(),
                new MultiplayerSubMenuModule(),
                new WorkshopSubMenuModule(),
                new OptionsSubMenuModule(),

                new AudioSettingsModule(),
                new GeneralSettingsModule(),
                new GraphicsSettingsModule(),
                new ProfileSettingsModule(),
                new VRSettingsModule(),
                new ReplaySettingsModule()
            };

            DynamicChecks = new Dictionary<string, Func<UILabel, DynamicTranslateModule>>() {
                {"Audio Settings Announcer Drop-Down", (UILabel instance) => { return ModuleChecks.Audio_Announcer_DropDown(ref instance); }},
                {"Audio Settings Subtitles Drop-Down", (UILabel instance) => { return ModuleChecks.Audio_Subtitles_DropDown(ref instance); }},

                {"General Settings Units Drop-Down", (UILabel instance) => { return ModuleChecks.General_Units_DropDown(ref instance); }},
                {"General Settings Car Screen Visualizer Drop-Down", (UILabel instance) => { return ModuleChecks.General_Visualizer_DropDown(ref instance); }},
                {"General Settings Split-Screen Camera Split Drop-Down", (UILabel instance) => { return ModuleChecks.General_CameraSplit_DropDown(ref instance); }},

                {"Replay Settings Ghost Type Drop-Down", (UILabel instance) => { return ModuleChecks.Replay_GhostType_DropDown(ref instance); }},

                {"Graphics Settings Fullscreen Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_Fullscreen_DropDown(ref instance); }},
                {"Graphics Settings Vsync Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_VSync_DropDown(ref instance); }},
                {"Graphics Settings Cinematic Letterbox Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_Letterbox_DropDown(ref instance); }},
                {"Graphics Settings Bloom Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_Bloom_DropDown(ref instance); }},
                {"Graphics Settings Film Grain Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_FilmGrain_DropDown(ref instance); }},
                {"Graphics Settings Vignetting Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_Vignetting_DropDown(ref instance); }},
                {"Graphics Settings Radial Blur Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_RadialBlur_DropDown(ref instance); }},
                {"Graphics Settings Sun Shafts Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_SunShafts_DropDown(ref instance); }},
                {"Graphics Settings Real-Time Reflections Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_Reflections_DropDown(ref instance); }},
                {"Graphics Settings Anisotropic Filtering Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_Anisotropic_DropDown(ref instance); }},
                {"Graphics Settings Particles Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_Particles_DropDown(ref instance); }},
                {"Graphics Settings Texture Quality Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_TextureQuality_DropDown(ref instance); }},
                {"Graphics Settings Anti-Aliasing Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_AntiAliasing_DropDown(ref instance); }},
                {"Graphics Settings Draw Distance Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_DrawDistance_DropDown(ref instance); }},
                {"Graphics Settings Shadow Quality Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_ShadowQuality_DropDown(ref instance); }},
                {"Graphics Settings Motion Blur Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_MotionBlur_DropDown(ref instance); }},
                {"Graphics Settings Car Dents Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_CarDents_DropDown(ref instance); }},
                {"Graphics Settings Detailed Lighting Drop-Down", (UILabel instance) => { return ModuleChecks.Graphics_Lighting_DropDown(ref instance); }},

                {"Profile Settings Edit Header", (UILabel instance) => { return ModuleChecks.Profile_Edit_Header(ref instance); }},
                
                {"General Settings Title", (UILabel instance) => { return ModuleChecks.General_Title(ref instance); }},
                {"Replay Settings Title", (UILabel instance) => { return ModuleChecks.Replay_Title(ref instance); }},
                {"VR Settings Title", (UILabel instance) => { return ModuleChecks.VR_Title(ref instance); }},

                {"Audio Custom Music Loading Label", (UILabel instance) => { return ModuleChecks.Audio_LoadingMusic_Label(ref instance); }}
            };
            
            if (Configuration["Debug"] is true)
                ListModules();
        }

        private static void ListModules()
        {
            Log.SuccessColor = ConsoleColor.Cyan;
            Log.Warning($"Currently loaded elements : {Modules.Count + DynamicChecks.Count}");
            Log.Warning($"  {Modules.Count} Class modules (static) :");
            foreach (TranslateModule Module in Modules)
            {
                Log.Success($"   - \"{Module.Name}\"");
                //Log.Info($"{Module.GetType().FullName}");
            }
            Log.Warning($"  {DynamicChecks.Count} Type reference modules (dynamic) :");
            foreach (var Check in DynamicChecks)
            {
                Log.Success($"   - \"{Check.Key}\"");
                //Log.Info($"{Check.Value.Method.ReflectedType.FullName}.{Check.Value.Method.Name}");
            }
            Log.SuccessColor = ConsoleColor.Green;
        }

        public static void ResetAll()
        {
            try
            {
                OnResetAll();
            }
            catch (Exception) { }
            if (Modules != null) foreach (TranslateModule Module in Modules)
            {
                Module.Initialize();
                Module.Enable();
            }
            if (ResetModules != null) foreach (Action ResetModule in ResetModules)
                try
                {
                    ResetModule();
                }
                catch (Exception) { }
        }

        public static void UpdateAll()
        {
            foreach(TranslateModule Module in Modules)
            {
                if (Module.IsEnabled())
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
