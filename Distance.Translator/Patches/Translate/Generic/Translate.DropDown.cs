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