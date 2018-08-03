using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class SubmenuMultiplayer : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Submenu Multiplayer";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MultiplayerButtonsPanel/ButtonsTable") != null)
                {
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MultiplayerButtonsPanel/ButtonsTable/Online/UILabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/MultiplayerButtonsPanel/ButtonsTable/Split-Screen/UILabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_SPLITSCREEN;

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