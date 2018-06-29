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
        [HarmonyPatch(typeof(UIWidget), "Start")]
        internal class UIWidget_Start_Patch : UIWidget
        {
            public static void Postfix(UIWidget __instance)
            {
                switch (__instance.name)
                {
                    case "MainButtons":
                        Spectrum.Interop.Game.Game.WatermarkText += "\nDISTANCE TRANSLATOR ([00DDFF]" + Language.LANGUAGE_NAME.ToUpper() + "[-] BY [FF9000]" + Language.LANGUAGE_AUTHOR.ToUpper() + "[-])";
                        GameObject.Find("Adventure").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_ADVENTURE;
                        GameObject.Find("Arcade").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_ARCADE;
                        GameObject.Find("Multiplayer").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_MULTIPLAYER;
                        GameObject.Find("Level Editor").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_LEVELEDITOR;
                        GameObject.Find("Steam Workshop").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_WORKSHOP;
                        GameObject.Find("Garage").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_GARAGE;
                        GameObject.Find("Report Bug").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_BUGREPORT;
                        GameObject.Find("Options").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_OPTIONS;
                        GameObject.Find("Quit").GetComponentsInChildren<UILabel>()[0].text = Language.MENUBUTTON_QUIT;
                        break;
                    case "AdventureButtonsPanel":
                        GameObject.Find("Campaign").GetComponentsInChildren<UILabel>()[0].text = Language.ADVENTURE_PREVIEW;
                        GameObject.Find("Campaign").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.ADVENTURE_PREVIEW_DESCRIPTION);
                        break;
                    case "SoloGameModesButtonsPanel":
                        GameObject.Find("Sprint").GetComponentsInChildren<UILabel>()[0].text = Language.ARCADE_SPRINT;
                        GameObject.Find("Sprint").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.ARCADE_SPRINT_DESCRIPTION);
                        GameObject.Find("Challenge").GetComponentsInChildren<UILabel>()[0].text = Language.ARCADE_CHALLENGE;
                        GameObject.Find("Challenge").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.ARCADE_CHALLENGE_DESCRIPTION);
                        GameObject.Find("Stunt").GetComponentsInChildren<UILabel>()[0].text = Language.ARCADE_STUNT;
                        GameObject.Find("Stunt").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.ARCADE_STUNT_DESCRIPTION);
                        GameObject.Find("Trackmogrify").GetComponentsInChildren<UILabel>()[0].text = Language.ARCADE_TRACKMOGRIFY;
                        GameObject.Find("Trackmogrify").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.ARCADE_TRACKMOGRIFY_DESCRIPTION);
                        break;
                    case "MultiplayerButtonsPanel":
                        GameObject.Find("Online").GetComponentsInChildren<UILabel>()[0].text = Language.MULTIPLAYER_ONLINE;
                        GameObject.Find("Split-Screen").GetComponentsInChildren<UILabel>()[0].text = Language.MULTIPLAYER_SPLITSCREEN;
                        break;
                    case "OptionsButtonsTable":
                        // Since for no apparent reason only the Audio button is accessible with 
                        // GameObject.Find()
                        // I use this piece of code that i'm not proud of
                        foreach (UILabel label in __instance.GetComponentsInChildren<UILabel>())
                        {
                            switch(label.text.ToUpper())
                            {
                                case "AUDIO":
                                    label.text = Language.OPTIONS_AUDIO;
                                    break;
                                case "GENERAL":
                                    label.text = Language.OPTIONS_GENERAL;
                                    break;
                                case "CONTROLS":
                                    label.text = Language.OPTIONS_CONTROLS;
                                    break;
                                case "GRAPHICS":
                                    label.text = Language.OPTIONS_GRAPHICS;
                                    break;
                                case "PROFILES":
                                    label.text = Language.OPTIONS_PROFILES;
                                    break;
                                case "REPLAY":
                                    label.text = Language.OPTIONS_REPLAY;
                                    break;
                                case "CHEATS":
                                    label.text = Language.OPTIONS_CHEATS;
                                    break;
                            }
                        }
                        break;
                    case "WorkshopButtonsPanel":
                        GameObject.Find("VisitWorkshop").GetComponentsInChildren<UILabel>()[0].text = Language.WORKSHOP_VISIT;
                        GameObject.Find("VisitWorkshop").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.WORKSHOP_VISIT_DESCRIPTION);
                        GameObject.Find("ScanForNewLevels").GetComponentsInChildren<UILabel>()[0].text = Language.WORKSHOP_DOWNLOAD;
                        GameObject.Find("ScanForNewLevels").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.WORKSHOP_DOWNLOAD_DESCRIPTION);
                        GameObject.Find("RefreshAll").GetComponentsInChildren<UILabel>()[0].text = Language.WORKSHOP_UPDATE;
                        GameObject.Find("RefreshAll").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.WORKSHOP_UPDATE_DESCRIPTION);
                        GameObject.Find("UnsubscribeAll").GetComponentsInChildren<UILabel>()[0].text = Language.WORKSHOP_UNSUBSCRIBE;
                        GameObject.Find("UnsubscribeAll").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.WORKSHOP_UNSUBSCRIBE_DESCRIPTION);
                        break;
                    case "BackButton":
                        GameObject.Find("BackButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_BACK.ToUpper();
                        break;
                    case "BottomRightText":
                        GameObject.Find("CancelButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_BACK.ToUpper();
                        GameObject.Find("ConfirmButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_APPLY.ToUpper();
                        GameObject.Find("DeleteButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_DELETE.ToUpper();
                        GameObject.Find("StartButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_START.ToUpper();
                        break;
                    case "UIPanel - PressAnyButton":
                        //GameObject.Find("UILabel - PressAnyButton").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_PRESSKEY;
                    case "UIPanel - DistanceTitle":
                        GameObject.Find("UILabel - DistanceTitle").GetComponentsInChildren<UILabel>()[0].text = Language.GetLine("nothing","D  I  S  T  A  N  C  E",true,0,true);
                        break;
                }
            }
        }
    }
}