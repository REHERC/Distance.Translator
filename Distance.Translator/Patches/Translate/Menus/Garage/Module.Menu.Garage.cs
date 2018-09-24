using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class GarageMenu : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Customization Menu";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car") != null)
                {
                    GameObject.Find("CustomizeMenuFrontRoot/BottomRightText/ConfirmButton/NameLabel").GetComponent<UILabel>().text = Language.BUTTON_APPLY.ToUpperInvariant();
                    GameObject.Find("CustomizeMenuFrontRoot/BottomRightText/CancelButton/NameLabel").GetComponent<UILabel>().text = Language.BUTTON_BACK.ToUpperInvariant();
                    GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car/CustomizeCar/Choose Color Presets/Edit Colors/NameLabel").GetComponent<UILabel>().text = Language.GARAGE_CUSTOMIZECAR_EDITCOLORS;
                    GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car/CustomizeCar/Choose Color Presets/Randomize/NameLabel").GetComponent<UILabel>().text = Language.GARAGE_CUSTOMIZECAR_RANDOMIZE; 
                    GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car/CustomizeCar/Choose Color Presets/Save as Preset/NameLabel").GetComponent<UILabel>().text = Language.GARAGE_CUSTOMIZECAR_SAVEPRESET;
                    GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car/Top/CustomizeCarButton/NameLabel").GetComponent<UILabel>().text = Language.GARAGE_CUSTOMIZECAR_TAB;
                    GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car/Top/GlobalStatsButton/NameLabel").GetComponent<UILabel>().text = Language.GARAGE_GLOBALSTATS_TAB;
                    GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car/Top/TricksButton/NameLabel").GetComponent<UILabel>().text = Language.GARAGE_TRICKS_TAB;
                    GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car/Top/MenuLevelButton/NameLabel").GetComponent<UILabel>().text = Language.GARAGE_MENULEVEL_TAB;
                    GameObject.Find("CustomizeMenuFrontRoot/Panel - Color Presets and Choose Car/MenuTitleTemplate/UILabel - Title").GetComponent<UILabel>().text = Language.GARAGE_TITLE;

                    CanRun = false;
                }
            }
        }
    }
}