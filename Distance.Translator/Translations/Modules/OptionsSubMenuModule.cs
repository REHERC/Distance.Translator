using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    public partial class OptionsSubMenuModule : TranslateModule
    {
        string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                return "MainMenuFrontRoot/UI Root/Panel - Main/OptionsButtonsPanel/OptionsButtonsTable";
            }
            return "PauseMenuRoot/Panel - Main/NewOptionsButtonsPanel/NewOptionsButtons";
        }

        public override string Name => "Options Sub Menu";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode") && GameObject.Find($"{Root()}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root()}/Audio/UILabel").GetComponent<UILabel>().text = Language.GetLine("options.audio");
            GameObject.Find($"{Root()}/General/UILabel").GetComponent<UILabel>().text = Language.GetLine("options.general");
            GameObject.Find($"{Root()}/Controls/UILabel").GetComponent<UILabel>().text = Language.GetLine("options.controls");
            GameObject.Find($"{Root()}/Graphics/UILabel").GetComponent<UILabel>().text = Language.GetLine("options.graphics");
            GameObject.Find($"{Root()}/Replay/UILabel").GetComponent<UILabel>().text = Language.GetLine("options.replay");
            GameObject.Find($"{Root()}/Cheats/UILabel").GetComponent<UILabel>().text = Language.GetLine("options.cheats");

            if (GameObject.Find($"{Root()}/Profiles") != null)
            {
                GameObject.Find($"{Root()}/Profiles/UILabel").GetComponent<UILabel>().text = Language.GetLine("options.profiles");
            }

            if (GameObject.Find($"{Root()}/VR Options") != null)
            {
                GameObject.Find($"{Root()}/VR Options/UILabel").GetComponent<UILabel>().text = Language.GetLine("options.vr");
            }
            Disable();
        }
    }
}
