using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class GeneralSettingsModule : TranslateModule
    {
        public static string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/General/Options/OptionsTable";
            return "OptionsFrontRoot(Clone)/Panel - Options/General/Options/OptionsTable";
        }

        public override string Name => "General Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode");
        }

        public override void Run()
        {
            GameObject.Find($"{Root()}/UNITS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.units").UP();
            GameObject.Find($"{Root()}/WORKSHOP RATING PRIVACY MODE/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.ratingprivacy").UP();
            GameObject.Find($"{Root()}/WORKSHOP LEVEL AUTO-DOWNLOAD/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.autodownload").UP();
            GameObject.Find($"{Root()}/ENABLE MENU ANIMATIONS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.menuanimations").UP();
            GameObject.Find($"{Root()}/ENABLE BOOMBOX MODE/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.boombox").UP();
            GameObject.Find($"{Root()}/BOOMBOX BLOOM INTENSITY/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.boomboxbloom").UP();
            GameObject.Find($"{Root()}/BOOMBOX SHAKE INTENSITY/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.boomboxshake").UP();
            GameObject.Find($"{Root()}/CAR SCREEN VISUALIZER/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.visualizer").UP();
            GameObject.Find($"{Root()}/SHUFFLE LEVELS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.shufflelevels").UP();
            GameObject.Find($"{Root()}/SHOW TRICK TEXT/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.showtricktext").UP();
            GameObject.Find($"{Root()}/SPLIT-SCREEN CAMERA SPLIT/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.camerasplit").UP();
            GameObject.Find($"{Root()}/SHOW SPEEDRUN TIMER/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.speedruntimer").UP();
            GameObject.Find($"{Root()}/ENABLE SPEEDRUN OUTPUT LOG/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.speedrunlog").UP();
            GameObject.Find($"{Root()}/CONFIGURE SPECTRUM PLUGINS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.general.configureplugins").UP();
            
            Disable();
        }
    }
}
