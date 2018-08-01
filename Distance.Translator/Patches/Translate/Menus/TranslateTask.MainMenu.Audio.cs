using UnityEngine;

namespace Distance.Translator
{
    class MainmenuAudio : TranslateTask
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
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Master").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_MASTER;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Car").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CAR;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Environment").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_ENVIRONMENT;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Obstacles").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_OBSTACLES;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Menus").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_MENUS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Announcer").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_ANNOUNCER;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Music").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_MUSIC;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Announcer Options").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_ANNOUNCERSETTINGS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/EnableCustomMusic").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/CustomMusicPath").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_FOLDER;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/SelectATrack").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_TRACK;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/Shuffle").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_SHUFFLETRACKS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center/VolumeOptions/Custom Music Group/UIPanel - CustomMusicPanel/Loop").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_CUSTOMMUSIC_LOOPTRACKS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Audio/MenuTitleTemplate/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_AUDIO_TITLE;

                CanRun = false;
            }
        }
    }
}