using System;
using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        //[HarmonyPatch(typeof(UIPanel), "Awake")]
        internal class UIPanel_Awake_Patch : UIPanel
        {
            public static void Postfix(UIPanel __instance)
            {
                switch (Util.GameObjectPath(__instance.transform)) {
                    case "OptionsFrontRoot/Panel - Options/Language":
                        //UnityEngine.Object.DontDestroyOnLoad(__instance);
                        break;
                }
            }
        }
    }
}