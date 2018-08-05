﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class SubmenuOptions : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Submenu Options";

        public void Run()
        {
            string PathPrefix = "";
            Scene scene = SceneManager.GetActiveScene();
            switch (scene.name)
            {
                case "MainMenu":
                    PathPrefix = "MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable";
                    break;
                case "GameMode":
                    PathPrefix = "PauseMenuRoot/Panel - Main/OptionsButtonsPanel/OptionsButtons";
                    break;
            }

            if (GameObject.Find(PathPrefix) != null)
            {
                GameObject.Find(PathPrefix + "/Audio/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO;
                GameObject.Find(PathPrefix + "/General/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL;
                GameObject.Find(PathPrefix + "/Controls/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS;
                GameObject.Find(PathPrefix + "/Graphics/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS;
                GameObject.Find(PathPrefix + "/Profiles/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES;
                GameObject.Find(PathPrefix + "/VR Options/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_VR;
                GameObject.Find(PathPrefix + "/Replay/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_REPLAY;
                GameObject.Find(PathPrefix + "/Cheats/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_CHEATS;

                GameObject.Find(PathPrefix + "/Language/UILabel").GetComponent<UILabel>().text = Language.PLUGIN_MENU_NAME;

                CanRun = false;
            }
        }
    }
}