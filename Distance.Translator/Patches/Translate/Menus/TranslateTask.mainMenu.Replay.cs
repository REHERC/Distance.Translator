using UnityEngine;

namespace Distance.Translator
{
    class MainmenuReplay : TranslateTask
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu Replay";

        public void Run()
        {
            if (GameObject.Find("OptionsFrontRoot/Panel - Options/Replay/Options") != null)
            {
                GameObject.Find("OptionsFrontRoot/Panel - Options/Replay/Options/OptionsTable/GHOSTS IN ARCADE TYPE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_TYPE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Replay/Options/OptionsTable/GHOSTS IN ARCADE COUNT/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_COUNT;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Replay/Options/OptionsTable/GHOST BRIGHTNESS/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_BRIGHTNESS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Replay/Options/OptionsTable/GHOST NAMES VISIBLE/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_NAMESVISIBLE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Replay/Options/OptionsTable/PLAYBACK SPEED AFFECTS MUSIC/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_PLAYBACKSPEED;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Replay/MenuTitleTemplate/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_REPLAYS_TITLE;

                CanRun = false;
            }
        }
    }
}