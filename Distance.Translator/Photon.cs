﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Harmony;
using Spectrum.API;
using Spectrum.API.Configuration;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;
using Spectrum.API.Logging;

namespace Distance.Translator
{
    public partial class Photon : IPlugin,IIPCEnabled
    {
        public void HandleIPCData(IPCData data)
        {
            IPCAntenna.RecieveData(data);
        }

        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine("Initializing ...");
            CurrentPlugin.initialize();
            IPCAntenna.initialize(manager,ipcIdentifier);
            CurrentPlugin.Log.Info("Initialization done!");
            PrintLogo();
            CurrentPlugin.Log.Warning("Currently using \"" + CurrentPlugin.Config.GetItem<string>("LanguageFile") + ".json\"");
            CurrentPlugin.Log.Warning(Language.LANGUAGE_NAME + " by " + Language.LANGUAGE_AUTHOR);
            try
            {
                CurrentPlugin.Log.Info("Instantiating Harmony Patcher ...");
                var Harmony = HarmonyInstance.Create("com.REHERC.DistanceTranslator");
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
            //LanguageManager.DetectLanguages();
            //LanguageManager.SendLanguageList();
        }
        
        public void PrintLogo()
        {
            foreach(string line in BootLogo.GetText().Split(Environment.NewLine[0]))
            {
                CurrentPlugin.Log.Info(line);
            }
        }
    }
}
