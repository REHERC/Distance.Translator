using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class MainmenuGeneral : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "General Settings";

        public void Run()
        {
            string PathPrefix = "";
            Scene scene = SceneManager.GetActiveScene();
            switch (scene.name)
            {
                case "MainMenu":
                    PathPrefix = "OptionsFrontRoot";
                    break;
                case "GameMode":
                    PathPrefix = "OptionsFrontRoot(Clone)";
                    break;
                default:
                    CanRun = false;
                    return;
            }

            if (GameObject.Find(PathPrefix + "/Panel - Options/General/Options") != null)
            {
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/UNITS/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_UNITS;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/ALL ABILITIES IN ADVENTURE MODE/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_ALLABILITIES;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/WORKSHOP RATING PRIVACY MODE/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_RATINGPRIVACY;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/WORKSHOP LEVEL AUTO-DOWNLOAD/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_AUTODOWNLOAD;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/ENABLE MENU ANIMATIONS/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_MENUANIMATIONS;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/ENABLE BOOM BOX MODE/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_BOOMBOX;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/BOOM BOX BLOOM INTENSITY/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_BOOMBOX_BLOOM;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/BOOM BOX SHAKE INTENSITY/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_BOOMBOX_SHAKE;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/CAR SCREEN VISUALIZER/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_VISUALIZER;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/SHUFFLE LEVELS/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_SHUFFLELEVELS;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/SHOW TRICK TEXT/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GENERAL_SHOWTRICKTEXT;
                GameObject.Find(PathPrefix + "/Panel - Options/General/Options/OptionsTable/LANGUAGE/NameLabel").GetComponent<UILabel>().text = Language.PLUGIN_MENU_LANGUAGE;
                
                CanRun = false;
            }
        }
    }
}
