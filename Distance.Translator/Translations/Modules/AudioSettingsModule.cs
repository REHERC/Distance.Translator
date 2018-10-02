using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class AudioSettingsModule : TranslateModule
    {
        string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                return "OptionsFrontRoot/Panel - Options/Audio/Options/OptionsTable";
            }
            return "OptionsFrontRoot/Panel - Options/Audio/Options/OptionsTable";
        }

        string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                return "OptionsFrontRoot/Panel - Options/Audio/MenuTitleTemplate";
            }
            return "OptionsFrontRoot/Panel - Options/Audio/MenuTitleTemplate";
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

            GameObject.Find($"{Root()}/MASTER/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.master");
            GameObject.Find($"{Root()}/CAR/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.car");
            GameObject.Find($"{Root()}/ENVIRONMENT/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.environment");
            GameObject.Find($"{Root()}/OBSTACLES/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.obstacles");
            GameObject.Find($"{Root()}/MENUS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.menus");
            GameObject.Find($"{Root()}/MUSIC/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.music");
            GameObject.Find($"{Root()}/ANNOUNCER/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.announcer");
            GameObject.Find($"{Root()}/ANNOUNCER SETTINGS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.announcersettings");
            GameObject.Find($"{Root()}/SUBTITLES/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.subtitles");
            GameObject.Find($"{Root()}/SUBTITLES SIZE/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.subtitlessize");
            
            Disable();
        }
    }
}
