using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    public partial class ArcadeSubMenuModule : TranslateModule
    {
        const string Root = "MainMenuFrontRoot/UI Root/Panel - Main/SoloGameModesButtonsPanel/SoloGameModesButtons";

        public override string Name => "Arcade Sub Menu";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return scene.name == "MainMenu" && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root}/Sprint/UILabel").GetComponent<UILabel>().text = Language.GetLine("gamemode.sprint");
            GameObject.Find($"{Root}/Sprint").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("gamemode.sprint.description"));
            GameObject.Find($"{Root}/Challenge/UILabel").GetComponent<UILabel>().text = Language.GetLine("gamemode.challenge");
            GameObject.Find($"{Root}/Challenge").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("gamemode.challenge.description"));
            GameObject.Find($"{Root}/Stunt/UILabel").GetComponent<UILabel>().text = Language.GetLine("gamemode.stunt");
            GameObject.Find($"{Root}/Stunt").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("gamemode.stunt"));
            GameObject.Find($"{Root}/Trackmogrify/UILabel").GetComponent<UILabel>().text = Language.GetLine("gamemode.trackmogrify.description");
            GameObject.Find($"{Root}/Trackmogrify").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("gamemode.trackmogrify.description"));

            Disable();
        }
    }
}
