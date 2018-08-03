﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    public static class TranslationManager
    {
        public static List<TranslateModule> Modules;

        public static void Initialize()
        {
            Modules = new List<TranslateModule>();
            Modules.Clear();

            Modules.Add(new Watermark() { CanRun = true });
            Modules.Add(new WorkshopHighlight() { CanRun = true });

            Modules.Add(new Mainmenu() { CanRun = true });
            Modules.Add(new MainmenuIdle() { CanRun = true });

            Modules.Add(new SubmenuAdventure() { CanRun = true });
            Modules.Add(new SubmenuArcade() { CanRun = true });
            Modules.Add(new SubmenuMultiplayer() { CanRun = true });
            Modules.Add(new SubmenuWorkshop() { CanRun = true });
            Modules.Add(new SubmenuOptions() { CanRun = true });

            Modules.Add(new MainmenuAudio() { CanRun = true });
            Modules.Add(new MainmenuGeneral() { CanRun = true });
            Modules.Add(new MainmenuControls() { CanRun = true });
            Modules.Add(new MainmenuGraphics() { CanRun = true });
            Modules.Add(new MainmenuProfiles() { CanRun = true });
            Modules.Add(new MainmenuReplay() { CanRun = true });
            Modules.Add(new MainmenuLanguage() { CanRun = true });


            Modules.Add(new GUIBackButton() { CanRun = true });

        }

        public static void Run()
        {
            foreach (TranslateModule Module in Modules)
            {
                if (Module.CanRun)
                {
                    try
                    {
                        Module.Run();
                    }
                    catch (Exception BRUH)
                    {

                    }
                }
            }
        }

        public static void Reset()
        {
            foreach (TranslateModule Module in Modules)
            {
                Module.CanRun = true;
            }

            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("GenerateMainMenuObjects(Clone)") != null)
                {
                    GameObject.Find("GenerateMainMenuObjects(Clone)").GetComponent<GenerateMainMenuObjects>();
                }
            }
        }
    }
}
