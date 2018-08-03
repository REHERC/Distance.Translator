using UnityEngine;

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

        public string Name => "Mainmenu Language";

        public void Run()
        {
            if (GameObject.Find("OptionsFrontRoot/Panel - Options/Language/Options") != null)
            {
                GameObject.Find("OptionsFrontRoot/Panel - Options/Language/MenuTitleTemplate/UILabel - Title").GetComponent<UILabel>().text = Language.PLUGIN_MENU_TITLE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Language/Options/OptionsTable/PLUGIN MENU LANGUAGE/NameLabel").GetComponent<UILabel>().text = Language.PLUGIN_MENU_LANGUAGE;
                
                CanRun = false;
            }
        }
    }
}