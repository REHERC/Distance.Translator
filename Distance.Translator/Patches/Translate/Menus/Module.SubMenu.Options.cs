using UnityEngine;
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
                    PathPrefix = "PauseMenuRoot/Panel - Main/NewOptionsButtonsPanel/NewOptionsButtons";
                    break;
                default:
                    CanRun = false;
                    return;
            }

            if (GameObject.Find(PathPrefix) != null && (scene.name == "MainMenu" ? GameObject.Find(PathPrefix + "/Language") != null : true))
            {
                GameObject.Find(PathPrefix + "/Audio/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO;
                GameObject.Find(PathPrefix + "/General/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL;
                GameObject.Find(PathPrefix + "/Controls/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS;
                GameObject.Find(PathPrefix + "/Graphics/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS;
                GameObject.Find(PathPrefix + "/VR Options/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_VR;
                GameObject.Find(PathPrefix + "/Replay/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_REPLAY;
                GameObject.Find(PathPrefix + "/Cheats/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_CHEATS;

                if (GameObject.Find(PathPrefix + "/Language") != null)
                {
                    GameObject.Find(PathPrefix + "/Language/UILabel").GetComponent<UILabel>().text = Language.PLUGIN_MENU_NAME;
                }

                if (GameObject.Find(PathPrefix + "/Profiles") != null)
                {
                    GameObject.Find(PathPrefix + "/Profiles/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES;
                }
            }
        }
    }
}