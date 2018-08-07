using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class Mainmenu : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Main Menu";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Adventure") != null)
                {
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Adventure").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_ADVENTURE;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Arcade").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_ARCADE;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Multiplayer").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_MULTIPLAYER;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Level Editor").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_LEVELEDITOR;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Steam Workshop").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_WORKSHOP;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Garage").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_GARAGE;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Report Bug").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_BUGREPORT;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Options").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_OPTIONS;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Quit").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_QUIT;

                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons/Quit").GetComponentInChildren<UILabel>().text = Language.MENUBUTTON_QUIT;

                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/DistanceTitle").GetComponent<UILabel>().text = Language.MAINMENU_GAMETITLE;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/DistanceTitle/BetaTag").GetComponent<UILabel>().text = Language.MAINMENU_BETATAG;
                    
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