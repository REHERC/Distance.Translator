using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class MainmenuReplay : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Replay Settings";

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

            if (GameObject.Find(PathPrefix + "/Panel - Options/Replay/Options") != null)
            {
                GameObject.Find(PathPrefix + "/Panel - Options/Replay/Options/OptionsTable/GHOSTS IN ARCADE TYPE/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_REPLAYS_TYPE;
                GameObject.Find(PathPrefix + "/Panel - Options/Replay/Options/OptionsTable/GHOSTS IN ARCADE COUNT/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_REPLAYS_COUNT;
                GameObject.Find(PathPrefix + "/Panel - Options/Replay/Options/OptionsTable/GHOST BRIGHTNESS/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_REPLAYS_BRIGHTNESS;
                GameObject.Find(PathPrefix + "/Panel - Options/Replay/Options/OptionsTable/GHOST NAMES VISIBLE/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_REPLAYS_NAMESVISIBLE;
                GameObject.Find(PathPrefix + "/Panel - Options/Replay/Options/OptionsTable/PLAYBACK SPEED AFFECTS MUSIC/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_REPLAYS_PLAYBACKSPEED;

                CanRun = false;
            }
        }
    }
}