using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class ReplaySettingsModule : TranslateModule
    {
        public static string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Replay/Options/OptionsTable";
            return "OptionsFrontRoot(Clone)/Panel - Options/Replay/Options/OptionsTable";
        }

        public static string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Replay/MenuTitleTemplate";
            return "OptionsFrontRoot(Clone)/Panel - Options/Replay/MenuTitleTemplate";
        }

        public override string Name => "Replay Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode");
        }

        public override void Run()
        {
            //GameObject.Find($"{MenuTitleTemplate()}/UILabel - Title").GetComponent<UILabel>().text = Language.GetLine("settings.replay.title"); // Can't patch here, use harmony instead

            GameObject.Find($"{Root()}/GHOSTS IN ARCADE TYPE/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.replay.type").UP();
            GameObject.Find($"{Root()}/GHOSTS IN ARCADE COUNT/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.replay.count").UP();
            GameObject.Find($"{Root()}/GHOST BRIGHTNESS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.replay.brightness").UP();
            GameObject.Find($"{Root()}/GHOST NAMES VISIBLE/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.replay.namesvisible").UP();
            GameObject.Find($"{Root()}/PLAYBACK SPEED AFFECTS MUSIC/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.replay.playbackspeed").UP();

            Disable();
        }
    }
}
