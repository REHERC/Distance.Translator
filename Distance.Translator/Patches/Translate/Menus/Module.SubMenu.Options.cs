using UnityEngine;

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
            if (GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable") != null)
            {
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/Audio/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO;
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/General/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL;
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/Controls/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS;
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/Graphics/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS;
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/Profiles/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES;
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/VR Options/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_VR;
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/Replay/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_REPLAY;
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/Cheats/UILabel").GetComponent<UILabel>().text = Language.OPTIONS_CHEATS;

                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable/Language/UILabel").GetComponent<UILabel>().text = Language.PLUGIN_MENU_NAME;

                CanRun = false;
            }
        }
    }
}