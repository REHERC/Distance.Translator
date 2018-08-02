using System;
using UnityEngine;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void UIPanel(UIPanel __instance)
        {
        }


        public static void UIPanel_DEPRECATED(UIPanel __instance)
        {
            try
            {
                if (__instance.name == Language.PLUGIN_MENU_NAME)
                {
                    GameObject.Find("Options/DescriptionArea/Title").GetComponent<UILabel>().text = Language.HEADER_DESCRIPTION;
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
                        //GameObject.Find("UIPanel - DistanceTitle/UILabel - DistanceTitle").GetComponent<UILabel>().text = "GAME TITLE HERE TO MAKE SILLY THINGS (USE 2 SPACES BETWEEN LETTERS)";
                        GameObject.Find("UIPanel - PressAnyButton/UILabel - PressAnyButton").GetComponent<UILabel>().text = Language.MAINMENU_PRESSKEY;
                        break;
                    case "MainButtons":
                        /*
                        GameObject.Find("Adventure").GetComponent<UILabel>().text = Language.MENUBUTTON_ADVENTURE;
                        GameObject.Find("Arcade").GetComponent<UILabel>().text = Language.MENUBUTTON_ARCADE;
                        GameObject.Find("Multiplayer").GetComponent<UILabel>().text = Language.MENUBUTTON_MULTIPLAYER;
                        GameObject.Find("Level Editor").GetComponent<UILabel>().text = Language.MENUBUTTON_LEVELEDITOR;
                        GameObject.Find("Steam Workshop").GetComponent<UILabel>().text = Language.MENUBUTTON_WORKSHOP;
                        GameObject.Find("Garage").GetComponent<UILabel>().text = Language.MENUBUTTON_GARAGE;
                        GameObject.Find("Report Bug").GetComponent<UILabel>().text = Language.MENUBUTTON_BUGREPORT;
                        GameObject.Find("Options").GetComponent<UILabel>().text = Language.MENUBUTTON_OPTIONS;
                        GameObject.Find("Quit").GetComponent<UILabel>().text = Language.MENUBUTTON_QUIT;
                        */
                        break;
                    case "AdventureButtonsPanel":
                        GameObject.Find("Campaign").GetComponent<UILabel>().text = Language.ADVENTURE_PREVIEW;
                        GameObject.Find("Campaign").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ADVENTURE_PREVIEW_DESCRIPTION);
                        break;
                    case "SoloGameModesButtonsPanel":
                        GameObject.Find("Sprint").GetComponent<UILabel>().text = Language.ARCADE_SPRINT;
                        GameObject.Find("Sprint").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ARCADE_SPRINT_DESCRIPTION);
                        GameObject.Find("Challenge").GetComponent<UILabel>().text = Language.ARCADE_CHALLENGE;
                        GameObject.Find("Challenge").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ARCADE_CHALLENGE_DESCRIPTION);
                        GameObject.Find("Stunt").GetComponent<UILabel>().text = Language.ARCADE_STUNT;
                        GameObject.Find("Stunt").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ARCADE_STUNT_DESCRIPTION);
                        GameObject.Find("Trackmogrify").GetComponent<UILabel>().text = Language.ARCADE_TRACKMOGRIFY;
                        GameObject.Find("Trackmogrify").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ARCADE_TRACKMOGRIFY_DESCRIPTION);
                        break;
                    case "MultiplayerButtonsPanel":
                        GameObject.Find("Online").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE;
                        GameObject.Find("Split-Screen").GetComponent<UILabel>().text = Language.MULTIPLAYER_SPLITSCREEN;
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
                        GameObject.Find("VisitWorkshop").GetComponent<UILabel>().text = Language.WORKSHOP_VISIT;
                        GameObject.Find("VisitWorkshop").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.WORKSHOP_VISIT_DESCRIPTION);
                        GameObject.Find("ScanForNewLevels").GetComponent<UILabel>().text = Language.WORKSHOP_DOWNLOAD;
                        GameObject.Find("ScanForNewLevels").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.WORKSHOP_DOWNLOAD_DESCRIPTION);
                        GameObject.Find("RefreshAll").GetComponent<UILabel>().text = Language.WORKSHOP_UPDATE;
                        GameObject.Find("RefreshAll").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.WORKSHOP_UPDATE_DESCRIPTION);
                        GameObject.Find("UnsubscribeAll").GetComponent<UILabel>().text = Language.WORKSHOP_UNSUBSCRIBE;
                        GameObject.Find("UnsubscribeAll").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.WORKSHOP_UNSUBSCRIBE_DESCRIPTION);
                        break;
                    case "BackButton":
                        GameObject.Find("BackButton").GetComponent<UILabel>().text = Language.BUTTON_BACK.ToUpperInvariant();
                        break;
                    case "BottomRightText":
                        GameObject.Find("CancelButton").GetComponent<UILabel>().text = Language.BUTTON_BACK.ToUpperInvariant();
                        GameObject.Find("ConfirmButton").GetComponent<UILabel>().text = Language.BUTTON_APPLY.ToUpperInvariant();
                        //GameObject.Find("DeleteButton").GetComponent<UILabel>().text = Language.BUTTON_DELETE.ToUpperInvariant();
                        //GameObject.Find("StartButton").GetComponent<UILabel>().text = Language.BUTTON_START.ToUpperInvariant();
                        break;
                    case "UIPanel - PressAnyButton":
                        //GameObject.Find("UILabel - DistanceTitle").GetComponent<UILabel>().text = Language.MAINMENU_GAMETITLEIDLE;
                        GameObject.Find("UILabel - PressAnyButton").GetComponent<UILabel>().text = Language.MAINMENU_PRESSKEY;
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