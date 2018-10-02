using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class GeneralSettingsModule : TranslateModule
    {
        string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                return "OptionsFrontRoot/Panel - Options/General/Options/OptionsTable";
            }
            return "OptionsFrontRoot/Panel - Options/General/Options/OptionsTable";
        }

        string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                return "OptionsFrontRoot/Panel - Options/General/MenuTitleTemplate";
            }
            return "OptionsFrontRoot/Panel - Options/General/MenuTitleTemplate";
        }

        public override string Name => "Audio Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode");
        }

        public override void Run()
        {
            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Title").GetComponent<UILabel>().text = Language.GetLine("settings.general.title"); // Can't patch here, use harmony instead

            GameObject.Find($"{Root()}/UNITS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.units");
            GameObject.Find($"{Root()}/WORKSHOP RATING PRIVACY MODE/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.ratingprivacy");
            GameObject.Find($"{Root()}/WORKSHOP LEVEL AUTO-DOWNLOAD/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.autodownload");
            GameObject.Find($"{Root()}/ENABLE MENU ANIMATIONS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.menuanimations");
            GameObject.Find($"{Root()}/SHUFFLE LEVELS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.shufflelevels");
            GameObject.Find($"{Root()}/SHOW TRICK TEXT/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.showtricktext");
            GameObject.Find($"{Root()}/SPLIT-SCREEN CAMERA SPLIT/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.camerasplit");
            
            Disable();
        }
    }
}
