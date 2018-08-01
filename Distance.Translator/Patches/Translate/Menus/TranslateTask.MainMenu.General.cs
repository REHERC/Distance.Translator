using UnityEngine;

namespace Distance.Translator
{
    class MainmenuGeneral : TranslateTask
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu General";

        public void Run()
        {
            if (GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options") != null)
            {
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/UNITS/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_UNITS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/ALL ABILITIES IN ADVENTURE MODE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_ALLABILITIES;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/WORKSHOP RATING PRIVACY MODE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_RATINGPRIVACY;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/WORKSHOP LEVEL AUTO-DOWNLOAD/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_AUTODOWNLOAD;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/ENABLE MENU ANIMATIONS/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_MENUANIMATIONS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/ENABLE BOOM BOX MODE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_BOOMBOX;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/BOOM BOX BLOOM INTENSITY/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_BOOMBOX_BLOOM;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/BOOM BOX SHAKE INTENSITY/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_BOOMBOX_SHAKE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/CAR SCREEN VISUALIZER/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_VISUALIZER;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/SHUFFLE LEVELS/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_SHUFFLELEVELS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/Options/OptionsTable/SHOW TRICK TEXT/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_SHOWTRICKTEXT;
                GameObject.Find("OptionsFrontRoot/Panel - Options/General/MenuTitleTemplate/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GENERAL_TITLE;

                CanRun = false;
            }
        }
    }
}
