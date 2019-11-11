using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    public partial class OnlineMultiplayerSubMenuModule : TranslateModule
    {
        const string Root = "MainMenuFrontRoot/UI Root/Panel - Main/OnlineFeaturesButtonsPanel/OnlineFeaturesButtons";

        public override string Name => "Online Multiplayer Sub Menu";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return scene.name == "MainMenu" && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root}/Quick Join/UILabel").GetComponent<UILabel>().text = Language.GetLine("multiplayer.online.quickjoin");
            GameObject.Find($"{Root}/Browse/UILabel").GetComponent<UILabel>().text = Language.GetLine("multiplayer.online.browse");
            GameObject.Find($"{Root}/Host/UILabel").GetComponent<UILabel>().text = Language.GetLine("multiplayer.online.host");
            
            Disable();
        }
    }
}
