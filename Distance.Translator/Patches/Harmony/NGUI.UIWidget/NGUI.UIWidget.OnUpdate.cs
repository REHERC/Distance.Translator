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
                    switch (Util.GameObjectPath(__instance.transform))
                    {
                        case "BackButton/Panel/BackButton":
                            __instance.width = 128;
                            __instance.rightAnchor.absolute = (int)((__instance.width + 12) / 2);
                            break;
                    }
                }
            }
        }
    }
}