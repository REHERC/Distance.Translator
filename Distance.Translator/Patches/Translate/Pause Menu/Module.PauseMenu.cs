using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class PauseMenu : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Pause Menu";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "GameMode" || (scene.name == "LevelEditor" && !Game.isInEditor))
            {
                if (GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons") != null)
                {
                    GameObject.Find("PauseMenuRoot/Panel - Main/Paused/UILabel - Paused").GetComponent<UILabel>().text = "paused";

                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/Resume/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_RESUME;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/BackToEditor/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_GOEDITOR;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/BackToLobby/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_GOLOBBY;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/Spectate/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_SPECTATE;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/Restart/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_RESTART;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/Next Track/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_NEXTLEVEL;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/MainMenu/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_GOMENU;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/Report Bug/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_BUGREPORT;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/Tricks/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_TRICKS;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/Options/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_OPTIONS;
                    GameObject.Find("PauseMenuRoot/Panel - Main/MainButtonsPanel/MainButtons/Quit/UILabel").GetComponent<UILabel>().text = Language.MENUBUTTON_QUIT;
                    
                    CanRun = false;
                }
            }
            else
            {
                CanRun = false;
            }
        }
    }
}