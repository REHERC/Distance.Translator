using System;
using Harmony;
using UnityEngine;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(UIWidget), "Update")]
        internal class UILabel_Update_Patch : UILabel
        {
            public static void Postfix(UILabel __instance)
            {
                try
                {
                    if (__instance.gameObject.HasComponent<UIEventListener>() && __instance.gameObject.transform.parent.gameObject.name == "Drop-down List")
                    {
                        GameObject MenuPanel = __instance.gameObject.transform.parent.parent.parent.gameObject;
                        switch (MenuPanel.name)
                        {
                            case "Panel - Audio":
                                Translate.AnnouncerOptionsTranslate(ref __instance);
                                break;
                            case "Panel - Options":
                                //General menu
                                Translate.UnitsTranslate(ref __instance);

                                // Replay menu
                                Translate.GhostTypeTranslate(ref __instance);
                                Translate.VisualizerTranslate(ref __instance);

                                break;
                        }
                    }
                    switch (__instance.gameObject.transform.parent.parent.gameObject.name)
                    {
                        case "Announcer Options":
                            Translate.AnnouncerOptionsTranslate(ref __instance);
                            break;
                        case "UNITS":
                            Translate.UnitsTranslate(ref __instance);
                            break;
                        case "CAR SCREEN VISUALIZER":
                            Translate.VisualizerTranslate(ref __instance);
                            break;
                        case "GHOSTS IN ARCADE TYPE":
                            Translate.GhostTypeTranslate(ref __instance);
                            break;
                    }
                }
                catch (Exception SWOOSHYBOI)
                {

                }
            }
        }
    }
}