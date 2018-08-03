using UnityEngine;

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

        public string Name => "Mainmenu Audio";

        public void Run()
        {
            if (GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center") != null)
            {
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Master/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_MASTER;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Car/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CAR;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Environment/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_ENVIRONMENT;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Obstacles/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_OBSTACLES;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Menus/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_MENUS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Announcer/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_ANNOUNCER;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Music/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_MUSIC;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Announcer Options/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/EnableCustomMusic").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/CustomMusicPath").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_FOLDER;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/SelectATrack").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_TRACK;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/Shuffle").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_SHUFFLETRACKS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/Loop").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_LOOPTRACKS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/MenuTitleTemplate/UILabel - Title").GetComponent<UILabel>().text = Language.OPTIONS_AUDIO_TITLE;

                CanRun = false;
            }
        }
    }
}