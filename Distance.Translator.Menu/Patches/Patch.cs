using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Harmony;

namespace Distance.Translator.Menu
{
    public static class Patcher
    {
        public static void Patch()
        {
            try
            {
                CurrentPlugin.Log.Info("Instantiating Harmony Patcher ...");
                var Harmony = HarmonyInstance.Create("com.REHERC.DistanceTranslatorMenu");
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
        }
    }
}
