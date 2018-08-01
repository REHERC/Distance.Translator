using System;
using UnityEngine;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void UIPanel(UIPanel __instance)
        {
            try
            {
                if (__instance.name == Language.PLUGIN_MENU_NAME)
                {
                    GameObject.Find("Options/DescriptionArea/Title").GetComponentsInChildren<UILabel>()[0].text = Language.HEADER_DESCRIPTION;
                }
                switch (__instance.name)
                {
                    /*
                    case "Panel - Audio":
                        
                        break;
                    case "General":
                        
                        break;
                    case "Panel - Controls":
                        
                        break;
                    case "Panel - Graphics":
                        
                        
                        break;
                        */
                    case "Panel - Profiles":
                        
                        break;
                    case "Replay":
                        
                        break;
                    case "Panel - Idle":
                        //GameObject.Find("UIPanel - DistanceTitle/UILabel - DistanceTitle").GetComponentsInChildren<UILabel>()[0].text = "GAME TITLE HERE TO MAKE SILLY THINGS (USE 2 SPACES BETWEEN LETTERS)";
                        GameObject.Find("UIPanel - PressAnyButton/UILabel - PressAnyButton").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_PRESSKEY;
                        break;
                    case "MainButtons":
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
                            Translate.OptionsPanelButtons(label);
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
                        GameObject.Find("BackButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_BACK.ToUpperInvariant();
                        break;
                    case "BottomRightText":
                        GameObject.Find("CancelButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_BACK.ToUpperInvariant();
                        GameObject.Find("ConfirmButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_APPLY.ToUpperInvariant();
                        //GameObject.Find("DeleteButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_DELETE.ToUpperInvariant();
                        //GameObject.Find("StartButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_START.ToUpperInvariant();
                        break;
                    case "UIPanel - PressAnyButton":
                        //GameObject.Find("UILabel - DistanceTitle").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_GAMETITLEIDLE;
                        GameObject.Find("UILabel - PressAnyButton").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_PRESSKEY;
                        break;
                }
                //ObjectManager.AddPanel(__instance);
            }
            catch (Exception SWOOSHYBOI)
            {

            }
        }
    }
}