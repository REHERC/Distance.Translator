using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using Spectrum.API;
using Spectrum.API.Configuration;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Logging;
using UnityEngine;
using UnityEngine.UI;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(UIWidget), "Update")]
        internal class UIWidget_Update_Patch : UIWidget
        {
            public static void Postfix(UIWidget __instance)
            {
                if (__instance.gameObject.HasComponent<UIExPopupList>()) {
                    UIExPopupList popup = __instance.gameObject.GetComponentsInChildren<UIExPopupList>()[0];
                    switch (__instance.gameObject.name)
                    {
                        case "Announcer Options":
                            switch (popup.value.ToUpper())
                            {
                                case "ALL MODES":
                                    popup.value = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_ALLMODES;
                                    break;
                                case "ARCADE ONLY":
                                    popup.value = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_ARCADEONLY;
                                    break;
                                case "STUNT ONLY":
                                    popup.value = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_STUNTONLY;
                                    break;
                                case "DISABLED":
                                    popup.value = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_DISABLED;
                                    break;
                            }
                            popup.items[0] = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_ALLMODES;
                            popup.items[1] = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_ARCADEONLY;
                            popup.items[2] = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_STUNTONLY;
                            popup.items[3] = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS_DISABLED;
                            break;
                        case "GHOSTS IN ARCADE TYPE":
                            switch (popup.value.ToUpper())
                            {
                                case "DISABLED":
                                    popup.value = Language.OPTIONS_REPLAYS_TYPE_DISABLED;
                                    break;
                                case "LOCAL":
                                    popup.value = Language.OPTIONS_REPLAYS_TYPE_LOCAL;
                                    break;
                                case "FRIENDS":
                                    popup.value = Language.OPTIONS_REPLAYS_TYPE_FRIENDS;
                                    break;
                                case "NEAR MY RANKING":
                                    popup.value = Language.OPTIONS_REPLAYS_TYPE_NEARMYRANKING;
                                    break;
                                case "GLOBAL BEST":
                                    popup.value = Language.OPTIONS_REPLAYS_TYPE_GLOBALBEST;
                                    break;
                            }
                            popup.items[0] = Language.OPTIONS_REPLAYS_TYPE_DISABLED;
                            popup.items[1] = Language.OPTIONS_REPLAYS_TYPE_LOCAL;
                            popup.items[2] = Language.OPTIONS_REPLAYS_TYPE_FRIENDS;
                            popup.items[3] = Language.OPTIONS_REPLAYS_TYPE_NEARMYRANKING;
                            popup.items[4] = Language.OPTIONS_REPLAYS_TYPE_GLOBALBEST;
                            break;
                    }
                }
            }
        }
    }
}