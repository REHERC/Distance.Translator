using System;
using UnityEngine;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void DropDown(ref UILabel __instance)
        {
            try
            {
                if (__instance.gameObject.HasComponent<UIEventListener>() && __instance.gameObject.transform.parent.gameObject.name == "Drop-down List")
                {
                    // Translate dropdown currently selected item
                    switch (__instance.gameObject.transform.parent.parent.parent.gameObject.name)
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
                    /*switch (__instance.gameObject.transform.parent.parent.parent.parent.gameObject.name)
                    {
                        case "Panel - Graphics":

                            //TODO: Add a switch case for the graphics options menu and select the dropdown name to avoid conficts
                            break;
                    }*/
                    // Translate dropdown items

                }

                switch (__instance.gameObject.transform.parent.parent.name)
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