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
        [HarmonyPatch(typeof(UIPanel), "Update")]
        internal class UIPanel_Update_Patch : UIPanel
        {
            public static void Postfix(UIPanel __instance)
            {
                Console.WriteLine("OOPDATING DA UI PANEL LOGIC DOOD !");
				switch (__instance.name)
                {
                    case "Panel - Audio":
                        GameObject.Find("VolumeOptions/Master").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_MASTER;
                        GameObject.Find("VolumeOptions/Car").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CAR;
                        GameObject.Find("VolumeOptions/Environment").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_ENVIRONMENT;
                        GameObject.Find("VolumeOptions/Obstacles").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_OBSTACLES;
                        GameObject.Find("VolumeOptions/Menus").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_MENUS;
                        GameObject.Find("VolumeOptions/Announcer").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_ANNOUNCER;
                        GameObject.Find("VolumeOptions/Music").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_MUSIC;
                        GameObject.Find("VolumeOptions/Announcer Options").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS;
                        GameObject.Find("VolumeOptions/Custom Music Group/EnableCustomMusic").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC;
                        GameObject.Find("VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/CustomMusicPath").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_FOLDER;
                        GameObject.Find("VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/SelectATrack").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_TRACK;
                        GameObject.Find("VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/Shuffle").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_SHUFFLETRACKS;
                        GameObject.Find("VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/Loop").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_LOOPTRACKS;
                        GameObject.Find("MenuTitleTemplate/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_TITLE;
                        break;
                    case "General":
                        GameObject.Find("Options/OptionsTable/UNITS/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_UNITS;
                        GameObject.Find("Options/OptionsTable/ALL ABILITIES IN ADVENTURE MODE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_ALLABILITIES;
                        GameObject.Find("Options/OptionsTable/WORKSHOP RATING PRIVACY MODE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_RATINGPRIVACY;
                        GameObject.Find("Options/OptionsTable/WORKSHOP LEVEL AUTO-DOWNLOAD/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_AUTODOWNLOAD;
                        GameObject.Find("Options/OptionsTable/ENABLE MENU ANIMATIONS/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_MENUANIMATIONS;
                        GameObject.Find("Options/OptionsTable/ENABLE BOOM BOX MODE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_BOOMBOX;
                        GameObject.Find("Options/OptionsTable/BOOM BOX BLOOM INTENSITY/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_BOOMBOX_BLOOM;
                        GameObject.Find("Options/OptionsTable/BOOM BOX SHAKE INTENSITY/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_BOOMBOX_SHAKE;
                        GameObject.Find("Options/OptionsTable/CAR SCREEN VISUALIZER/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_VISUALIZER;
                        GameObject.Find("Options/OptionsTable/SHUFFLE LEVELS/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_SHUFFLELEVELS;
                        GameObject.Find("Options/OptionsTable/SHOW TRICK TEXT/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_SHOWTRICKTEXT;
                        GameObject.Find("MenuTitleTemplate/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_TITLE;
                        break;
                    case "Panel - Controls":
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/Device Scheme Options/DevicePopup/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_DEVICE;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/Device Scheme Options/SchemePopup/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_SELECTED;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/EditSchemeButton/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_EDIT;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/DeleteButton/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_DELETE;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/DuplicateButton/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_DUPLICATE;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/RenameButton/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_RENAME;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/InvertYAxis/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_INVERTY;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/UpsideDownSelfRighting/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SELFRIGHTING;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/FlightLandingAssist/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_LANDINGASSIST;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/RumbleIntensity/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_RUMBLEINTENSITY;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/SteeringSensitivity/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_STEERINGSENSITIVITY;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/FlightSensitivity/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_FLIGHTSENSITIVITY;
                        GameObject.Find("MenuPanel/BasicOptions/BasicOptionsAreaButton/Digital Input Smoothing/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_INPUTSMOOTHING;
                        GameObject.Find("MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1000").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TAB_BASIC;
                        GameObject.Find("MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1001").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TAB_FLIGHT;
                        GameObject.Find("MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1002").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TAB_CAMERA;
                        GameObject.Find("MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1003").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TAB_MENU;
                        GameObject.Find("Panel - MenuTitle/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TITLE;
                        GameObject.Find("Panel - MenuTitle/UILabel - Description").GetComponentsInChildren<UILabel>()[0].text = String.Format(Language.OPTIONS_CONTROLS_SUBTITLE,G.Sys.ProfileManager_.CurrentProfile_.Name_);
                        break;
                    case "Replay":
                        GameObject.Find("Options/OptionsTable/GHOSTS IN ARCADE TYPE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_TYPE;
                        GameObject.Find("Options/OptionsTable/GHOSTS IN ARCADE COUNT/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_COUNT;
                        GameObject.Find("Options/OptionsTable/GHOST BRIGHTNESS/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_BRIGHTNESS;
                        GameObject.Find("Options/OptionsTable/GHOST NAMES VISIBLE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_NAMESVISIBLE;
                        GameObject.Find("Options/OptionsTable/PLAYBACK SPEED AFFECTS MUSIC/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_PLAYBACKSPEED;
                        GameObject.Find("MenuTitleTemplate/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_TITLE;
                        break;
                    case "Panel - Idle":
                        //GameObject.Find("UIPanel - DistanceTitle/UILabel - DistanceTitle").GetComponentsInChildren<UILabel>()[0].text = "GAME TITLE HERE TO MAKE SILLY THINGS (USE 2 SPACES BETWEEN LETTERS LMAO)";
                        GameObject.Find("UIPanel - PressAnyButton/UILabel - PressAnyButton").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_PRESSKEY;
                        break;
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
                        GameObject.Find("BackButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_BACK.ToUpper();
                        break;
                    case "BottomRightText":
                        GameObject.Find("CancelButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_BACK.ToUpper();
                        GameObject.Find("ConfirmButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_APPLY.ToUpper();
                        //GameObject.Find("DeleteButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_DELETE.ToUpper();
                        //GameObject.Find("StartButton").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_START.ToUpper();
                        break;
                    case "UIPanel - PressAnyButton":
                        //GameObject.Find("UILabel - DistanceTitle").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_GAMETITLEIDLE;
                        GameObject.Find("UILabel - PressAnyButton").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_PRESSKEY;
                        break;
                }
            }
        }
    }
}