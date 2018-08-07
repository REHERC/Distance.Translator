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
                    DropDown(ref __instance, UIPopupList.current.name);
                }
                if (__instance.transform.parent.parent.HasComponent<UIExPopupList>() && __instance.gameObject.name == "PopupLabel")
                {
                    // This code is here so when the language is changed, the general menu dropdown selected items gets updated

                    GameObject Popup = __instance.transform.parent.parent.gameObject;
                    string currentValue = Popup.GetComponent<UIExPopupList>().value;
                    __instance.text = currentValue;
                    
                    DropDown(ref __instance, __instance.transform.parent.parent.name);
                }
            }
            catch (Exception SWOOSHYBOI)
            {
                
            }
        }

        private static void DropDown(ref UILabel __instance,string name)
        {
            switch (name)
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
                case "Fullscreen":
                case "StylizedOutlines":
                case "FilmNoir":
                case "CinematicLetterbox":
                case "Bloom":
                case "FilmGrain":
                case "Vignetting":
                case "RadialBlur":
                case "SunShafts":
                case "DepthOfField":
                case "Particles":
                case "MotionBlur":
                case "CarDents":
                case "Detailed Lighting":
                    Translate.GenericOnOff(ref __instance);
                    break;
                case "AnisotropicFiltering":
                    Translate.AbnisotropicFiltering(ref __instance);
                    break;
                case "DrawDistance":
                    Translate.DrawDistance(ref __instance);
                    break;
                case "RealTimeReflections":
                    Translate.RealTimeReflections(ref __instance);
                    break;
                case "ShadowQuality":
                    Translate.ShadowQuality(ref __instance);
                    break;
                case "TextureQuality":
                    Translate.TextureQuality(ref __instance);
                    break;
                case "AntiAliasing":
                    Translate.AntiAliasing(ref __instance);
                    break;
                case "VSync":
                    Translate.VSync(ref __instance);
                    break;
            }
        }
    }
}