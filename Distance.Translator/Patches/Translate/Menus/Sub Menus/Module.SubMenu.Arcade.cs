using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class SubmenuArcade : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Submenu Arcade";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons") != null)
                {
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons/Sprint/UILabel").GetComponent<UILabel>().text = Language.ARCADE_SPRINT;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons/Sprint").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ARCADE_SPRINT_DESCRIPTION);
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons/Challenge/UILabel").GetComponent<UILabel>().text = Language.ARCADE_CHALLENGE;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons/Challenge").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ARCADE_CHALLENGE_DESCRIPTION);
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons/Stunt/UILabel").GetComponent<UILabel>().text = Language.ARCADE_STUNT;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons/Stunt").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ARCADE_STUNT_DESCRIPTION);
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons/Trackmogrify/UILabel").GetComponent<UILabel>().text = Language.ARCADE_TRACKMOGRIFY;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons/Trackmogrify").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ARCADE_TRACKMOGRIFY_DESCRIPTION);

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