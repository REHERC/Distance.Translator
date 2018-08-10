using System;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void ControlsListingTable(ref UILabel __instance)
        {
            string path = "";

            try
            {
                string PathPrefix = "";
                Scene scene = SceneManager.GetActiveScene();
                switch (scene.name)
                {
                    case "MainMenu":
                        PathPrefix = "OptionsFrontRoot";
                        break;
                    case "GameMode":
                        PathPrefix = "OptionsFrontRoot(Clone)";
                        break;
                    default:
                        return;
                }

                path = PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/EditAreaButton/SubPanel/Controls Listing Table";
                
                if (Util.GameObjectPath(__instance.gameObject.transform.parent.parent) == path)
                {
                    switch (__instance.text.ToLowerInvariant())
                    {
                        // Basic
                        case "gas":
                            __instance.text = Language.CONTROLS_BASIC_GAS;
                            break;
                        case "brake":
                            __instance.text = Language.CONTROLS_BASIC_BRAKE;
                            break;
                        case "steer left":
                            __instance.text = Language.CONTROLS_BASIC_STEER_LEFT;
                            break;
                        case "steer right":
                            __instance.text = Language.CONTROLS_BASIC_STEER_RIGHT;
                            break; 
                        case "boost":
                            __instance.text = Language.CONTROLS_BASIC_BOOST;
                            break;
                        case "jump":
                            __instance.text = Language.CONTROLS_BASIC_JUMP;
                            break;
                        case "wings":
                            __instance.text = Language.CONTROLS_BASIC_WINGS;
                            break;
                        case "grip":
                            __instance.text = Language.CONTROLS_BASIC_GRIP;
                            break;
                        case "special":
                            __instance.text = Language.CONTROLS_BASIC_SPECIAL;
                            break;
                        case "reset":
                            __instance.text = Language.CONTROLS_BASIC_RESET;
                            break;
                        case "pause":
                            __instance.text = Language.CONTROLS_BASIC_PAUSE;
                            break;
                        case "horn":
                            __instance.text = Language.CONTROLS_BASIC_HORN;
                            break;
                        case "show score":
                            __instance.text = Language.CONTROLS_BASIC_SHOWSCORE;
                            break;
                        case "chat":
                            __instance.text = Language.CONTROLS_BASIC_CHAT;
                            break;

                        // Flight
                        case "air roll left":
                            __instance.text = Language.CONTROLS_FLIGHT_AIRROLL_LEFT;
                            break;
                        case "air roll right":
                            __instance.text = Language.CONTROLS_FLIGHT_AIRROLL_RIGHT;
                            break;
                        case "air pitch down":
                            __instance.text = Language.CONTROLS_FLIGHT_AIRPITCH_DOWN;
                            break;
                        case "air pitch up":
                            __instance.text = Language.CONTROLS_FLIGHT_AIRPITCH_UP;
                            break;
                        case "wing yaw left":
                            __instance.text = Language.CONTROLS_FLIGHT_WINGYAW_LEFT;
                            break;
                        case "wing yaw right":
                            __instance.text = Language.CONTROLS_FLIGHT_WINGYAW_RIGHT;
                            break;
                        case "wing pitch down":
                            __instance.text = Language.CONTROLS_FLIGHT_WINGPITCH_DOWN;
                            break;
                        case "wing pitch up":
                            __instance.text = Language.CONTROLS_FLIGHT_WINGPITCH_UP;
                            break;
                        case "jet roll left":
                            __instance.text = Language.CONTROLS_FLIGHT_JETROLL_LEFT;
                            break;
                        case "jet roll right":
                            __instance.text = Language.CONTROLS_FLIGHT_JETROLL_RIGHT;
                            break;
                        case "jet pitch down":
                            __instance.text = Language.CONTROLS_FLIGHT_JETPITCH_DOWN;
                            break;
                        case "jet pitch up":
                            __instance.text = Language.CONTROLS_FLIGHT_JETPITCH_UP;
                            break;
                        case "wing roll left":
                            __instance.text = Language.CONTROLS_FLIGHT_WINGROLL_LEFT;
                            break;
                        case "wing roll right":
                            __instance.text = Language.CONTROLS_FLIGHT_WINGROLL_RIGHT;
                            break;

                        // Camera
                        case "center camera":
                            __instance.text = Language.CONTROLS_CAMERA_CENTER;
                            break;
                        case "camera look behind":
                            __instance.text = Language.CONTROLS_CAMERA_LOOKBEHIND;
                            break;
                        case "camera yaw left":
                            __instance.text = Language.CONTROLS_CAMERA_YAW_LEFT;
                            break;
                        case "camera yaw right":
                            __instance.text = Language.CONTROLS_CAMERA_YAW_RIGHT;
                            break;
                        case "camera pitch down":
                            __instance.text = Language.CONTROLS_CAMERA_PITCH_DOWN;
                            break;
                        case "camera pitch up":
                            __instance.text = Language.CONTROLS_CAMERA_PITCH_UP;
                            break;
                        case "change camera view":
                            __instance.text = Language.CONTROLS_CAMERA_CHANGEVIEW;
                            break;
                        case "spectate next player":
                            __instance.text = Language.CONTROLS_CAMERA_NEXTPLAYER;
                            break;

                        // Menu
                        case "menu confirm":
                            __instance.text = Language.CONTROLS_MENU_CONFIRM;
                            break;
                        case "menu cancel":
                            __instance.text = Language.CONTROLS_MENU_CANCEL;
                            break;
                        case "menu left":
                            __instance.text = Language.CONTROLS_MENU_LEFT;
                            break;
                        case "menu right":
                            __instance.text = Language.CONTROLS_MENU_RIGHT;
                            break;
                        case "menu down":
                            __instance.text = Language.CONTROLS_MENU_DOWN;
                            break;
                        case "menu up":
                            __instance.text = Language.CONTROLS_MENU_UP;
                            break;
                        case "menu start":
                            __instance.text = Language.CONTROLS_MENU_START;
                            break;
                        case "menu page left":
                            __instance.text = Language.CONTROLS_MENU_PAGE_LEFT;
                            break;
                        case "menu page right":
                            __instance.text = Language.CONTROLS_MENU_PAGE_RIGHT;
                            break;
                        case "menu page down":
                            __instance.text = Language.CONTROLS_MENU_PAGE_DOWN;
                            break;
                        case "menu page up":
                            __instance.text = Language.CONTROLS_MENU_PAGE_UP;
                            break;
                        case "menu delete":
                            __instance.text = Language.CONTROLS_MENU_DELETE;
                            break;
                        case "menu create playlist":
                            __instance.text = Language.CONTROLS_MENU_CREATEPLAYLIST;
                            break;
                        case "menu rate level":
                            __instance.text = Language.CONTROLS_MENU_RATELEVEL;
                            break;
                        case "menu sorting":
                            __instance.text = Language.CONTROLS_MENU_SORTING;
                            break;
                        case "toggle menu visibility":
                            __instance.text = Language.CONTROLS_MENU_TOGGLEVISIBILITY;
                            break;
                    }
                }
                else if (Util.GameObjectPath(__instance.gameObject.transform.parent.parent.parent) == path)
                {
                    switch (__instance.text.ToLowerInvariant())
                    {
                        // Control key not set
                        case "(not set)":
                            __instance.text = Language.CONTROLS_NOTSET;
                            break;
                    }
                }

                path = PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/EditAreaButton/BottomThingy";
                if (__instance != null && Util.GameObjectPath(__instance.gameObject.transform.parent) == path)
                {
                    switch (__instance.name)
                    {
                        case "HelpLabel":
                            __instance.text = Language.OPTIONS_CONTROLS_HELPTEXT;
                            break;
                    }
                }
            }
            catch (Exception SWOOSHYBOI)
            {
                
            }
        }
    }
}