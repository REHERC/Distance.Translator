using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class MainmenuIdle : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu Idle";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Idle") != null)
                {
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Idle/UIPanel - PressAnyButton/UILabel - PressAnyButton").GetComponent<UILabel>().text = Language.MAINMENU_PRESSKEY;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Idle/UIPanel - DistanceTitle/UILabel - DistanceTitle").GetComponent<UILabel>().text = Language.MAINMENU_GAMETITLE;

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