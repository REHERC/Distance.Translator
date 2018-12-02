using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    public partial class WorkshopSubMenuModule : TranslateModule
    {
        const string Root = "MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons";

        public override string Name => "Workshop Sub Menu";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return G.Sys.GameManager_.IsSteamBuild_ && scene.name == "MainMenu" && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root}/Final Buttons/VisitWorkshop/UILabel").GetComponent<UILabel>().text = Language.GetLine("workshop.visit");
            GameObject.Find($"{Root}/Final Buttons/VisitWorkshop").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("workshop.visit.description"));
            GameObject.Find($"{Root}/Final Buttons/ScanForNewLevels/UILabel").GetComponent<UILabel>().text = Language.GetLine("workshop.download");
            GameObject.Find($"{Root}/Final Buttons/ScanForNewLevels").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("workshop.download.description"));
            GameObject.Find($"{Root}/Final Buttons/RefreshAll/UILabel").GetComponent<UILabel>().text = Language.GetLine("workshop.update");
            GameObject.Find($"{Root}/Final Buttons/RefreshAll").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("workshop.update.description"));
            GameObject.Find($"{Root}/Final Buttons/UnsubscribeAll/UILabel").GetComponent<UILabel>().text = Language.GetLine("workshop.unsubscribe");
            GameObject.Find($"{Root}/Final Buttons/UnsubscribeAll").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("workshop.unsubscribe.description"));

            Disable();
        }
    }
}
