using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class ControlsSettingsModule : TranslateModule
    {
        public static string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel";
            return "OptionsFrontRoot(Clone)/Panel - Options/Panel - Controls/MenuPanel";
        }

        public static string BasicOptions()
        {
            return $"{Root()}/BasicOptions/BasicOptionsButtons";
        }

        public static string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Controls/MenuTitleTemplate";
            return "OptionsFrontRoot(Clone)/Panel - Options/Panel - Controls/MenuTitleTemplate";
        }

        public override string Name => "Controls Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode" || scene.name == "LevelEditor");
        }

        public override void Run()
        {
            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Title").GetComponent<UILabel>().text = Language.GetLine("settings.controls.title");
            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Description").GetComponent<UILabel>().text = string.Format(Language.GetLine("settings.controls.description"), G.Sys.ProfileManager_.CurrentProfile_.Name_);
            
            GameObject.Find($"{BasicOptions()}/").GetComponent<UILabel>().text = Language.GetLine("settings.controls.description");



            //GameObject.Find($"{Root()}/Left - VolumeOptions/Master/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.audio.master").UP();

            Disable();
        }
    }
}
