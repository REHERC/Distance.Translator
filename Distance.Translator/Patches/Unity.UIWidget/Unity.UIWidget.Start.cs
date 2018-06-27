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

                        GameObject.Find("Adventure").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_ADVENTURE;
                        GameObject.Find("Arcade").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_ARCADE;
                        GameObject.Find("Multiplayer").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_MULTIPLAYER;
                        GameObject.Find("Level Editor").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_LEVELEDITOR;
                        GameObject.Find("Steam Workshop").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_WORKSHOP;
                        GameObject.Find("Garage").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_GARAGE;
                        GameObject.Find("Report Bug").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_BUGREPORT;
                        GameObject.Find("Options").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_OPTIONS;
                        GameObject.Find("Quit").GetComponentsInChildren<UILabel>()[0].text = Language.MAINMENU_QUIT;
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
                        
                        GameObject.Find("Audio").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO;
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


                        /*
                        GameObject.Find("General").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL;
                        GameObject.Find("Controls").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS;
                        GameObject.Find("Graphics").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS;
                        GameObject.Find("Replay").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_PROFILES;
                        GameObject.Find("Profiles").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS;
                        GameObject.Find("Cheats").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CHEATS;
                        */
                        break;
                }
            }
        }
    }
}