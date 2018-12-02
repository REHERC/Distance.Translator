using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    public partial class MultiplayerSubMenuModule : TranslateModule
    {
        const string Root = "MainMenuFrontRoot/UI Root/Panel - Main/MultiplayerButtonsPanel/ButtonsTable";

        public override string Name => "Multiplayer Sub Menu";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return scene.name == "MainMenu" && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root}/Online/UILabel").GetComponent<UILabel>().text = Language.GetLine("multiplayer.online");
            GameObject.Find($"{Root}/Split-Screen/UILabel").GetComponent<UILabel>().text = Language.GetLine("multiplayer.splitscreen");
            
            Disable();
        }
    }
}
