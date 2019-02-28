using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    public partial class MainMenuModule : TranslateModule
    {
        const string Root = "MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons";

        public override string Name => "Main Menu";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return scene.name == "MainMenu" && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root}/Campaign/UILabel").GetComponent<UILabel>().text = G.Sys.OptionsManager_.CheatSettings_.SettingsFlags_.IsSet(ECheat.CampaignPlus) ? Language.GetLine("mainmenu.campaignplus").UP() : Language.GetLine("mainmenu.campaign").UP();
            GameObject.Find($"{Root}/Arcade/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.arcade").UP();
            GameObject.Find($"{Root}/Multiplayer/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.multiplayer").UP();
            GameObject.Find($"{Root}/Level Editor/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.leveleditor").UP();
            if (G.Sys.GameManager_.IsSteamBuild_)
                GameObject.Find($"{Root}/Steam Workshop/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.workshop").UP();
            GameObject.Find($"{Root}/Garage/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.garage").UP();
            GameObject.Find($"{Root}/Options/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.options").UP();
            GameObject.Find($"{Root}/Quit/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.quit").UP();
            
            Disable();
        }
    }
}
