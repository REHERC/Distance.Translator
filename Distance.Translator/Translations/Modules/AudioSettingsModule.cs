using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class AudioSettingsModule : TranslateModule
    {
        public static string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Audio/Anchor - Center";
            return "OptionsFrontRoot(Clone)/Panel - Options/Panel - Audio/Anchor - Center";
        }

        public static string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Audio/MenuTitleTemplate";
            return "OptionsFrontRoot(Clone)/Panel - Options/Panel - Audio/MenuTitleTemplate";
        }

        public override string Name => "Audio Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode");
        }

        public override void Run()
        {
            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Title").GetComponent<UILabel>().text = Language.GetLine("settings.audio.title");

            GameObject.Find($"{Root()}/Left - VolumeOptions/Master/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.master").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Car/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.car").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Environment/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.environment").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Obstacles/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.obstacles").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Menus/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.menus").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Music/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.music").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Announcer/Announcer Slider/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.announcer").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Announcer/Announcer Options/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.announcer.options").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Announcer/Announcer Tricks/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.announcer.tricks").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Announcer/Announcer Death/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.announcer.death").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Announcer/Announcer Checkpoints/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.announcer.checkpoints").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Announcer/Announcer Mode/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.announcer.mode").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Subtitles/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.subtitles").UP();
            GameObject.Find($"{Root()}/Left - VolumeOptions/Subtitles Options/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.subtitles.size").UP();
            GameObject.Find($"{Root()}/Right - CustomMusic/Custom Music Group/EnableCustomMusic/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.custommusic.enable").UP();
            GameObject.Find($"{Root()}/Right - CustomMusic/Custom Music Group/UIPanel - CustomMusicPanel/CustomMusicPath/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.custommusic.folder").UP();
            GameObject.Find($"{Root()}/Right - CustomMusic/Custom Music Group/UIPanel - CustomMusicPanel/CustomMusicPath").GetComponent<UIExInput>().defaultText = Language.GetLine("settings.audio.custommusic.folder.type");
            GameObject.Find($"{Root()}/Right - CustomMusic/Custom Music Group/UIPanel - CustomMusicPanel/Subdirectories/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.custommusic.subdirectories").UP();
            GameObject.Find($"{Root()}/Right - CustomMusic/Custom Music Group/UIPanel - CustomMusicPanel/SelectATrack/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.custommusic.selecttrack").UP();
            GameObject.Find($"{Root()}/Right - CustomMusic/Custom Music Group/UIPanel - CustomMusicPanel/Shuffle/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.custommusic.shuffle").UP();
            GameObject.Find($"{Root()}/Right - CustomMusic/Custom Music Group/UIPanel - CustomMusicPanel/Loop/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.custommusic.loop").UP();

            Disable();
        }
    }
}
