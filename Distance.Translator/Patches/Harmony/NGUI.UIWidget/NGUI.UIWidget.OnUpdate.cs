using System;
using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(UIWidget), "OnUpdate")]
        internal class UIWidget_OnUpdate_Patch : UIWidget
        {
            public static void Postfix(UIWidget __instance)
            {
                if (__instance != null)
                {
                    int AddedSize = 0;
                    switch (Util.GameObjectPath(__instance.transform))
                    {
                        case "BackButton/Panel/BackButton":
                            AddedSize = 22;
                            __instance.leftAnchor.absolute = -165 + AddedSize;
                            __instance.width = 106 + AddedSize;
                            break;
                        case "OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/Mode":
                            AddedSize = 24;
                            __instance.width = 39 + AddedSize;
                            
                            //Console.WriteLine($"{__instance.leftAnchor.absolute} | {__instance.width} | {__instance.rightAnchor.absolute}");
                            break;
                        case "OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/Ping":
                            AddedSize = 8;
                            __instance.width = 33 + AddedSize;
                            break;
                    }
                }
            }
        }
    }
}