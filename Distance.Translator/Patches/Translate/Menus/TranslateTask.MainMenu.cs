using UnityEngine;

namespace Distance.Translator
{
    class Mainmenu : TranslateTask
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu";

        public void Run()
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

                CanRun = false;
            }
        }
    }
}