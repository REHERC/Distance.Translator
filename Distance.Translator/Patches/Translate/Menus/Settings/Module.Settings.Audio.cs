using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class MainmenuAudio : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Audio Settings";

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

            if (GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center") != null)
            {
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Master/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_MASTER;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Car/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CAR;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Environment/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_ENVIRONMENT;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Obstacles/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_OBSTACLES;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Menus/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_MENUS;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Announcer/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_ANNOUNCER;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Music/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_MUSIC;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Announcer Options/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/EnableCustomMusic/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/CustomMusicPath/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_FOLDER;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/SelectATrack/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_TRACK;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/Shuffle/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_SHUFFLETRACKS;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/Loop/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_LOOPTRACKS;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Audio/MenuTitleTemplate/UILabel - Title").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_TITLE;

                CanRun = false;
            }
        }
    }
}