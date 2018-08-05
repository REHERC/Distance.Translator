using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class MainmenuLanguage : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Language Settings";

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

            if (GameObject.Find(PathPrefix + "/Panel - Options/Language/Options") != null)
            {
                GameObject.Find(PathPrefix + "/Panel - Options/Language/MenuTitleTemplate/UILabel - Title").GetComponent<UILabel>().text = Language.PLUGIN_MENU_TITLE;
                GameObject.Find(PathPrefix + "/Panel - Options/Language/Options/OptionsTable/PLUGIN MENU LANGUAGE/NameLabel").GetComponent<UILabel>().text = Language.PLUGIN_MENU_LANGUAGE;
                
                CanRun = false;
            }
        }
    }
}