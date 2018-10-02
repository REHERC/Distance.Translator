using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    public partial class WorkshopSubMenuModule : TranslateModule
    {
        const string Root = "MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons";

        public override string Name => "Workshop Sub Menu";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return scene.name == "MainMenu" && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root}/Final Buttons/VisitWorkshop/UILabel").GetComponent<UILabel>().text = Language.GetLine("workshop.visit");
            GameObject.Find($"{Root}/Final Buttons/VisitWorkshop").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("workshop.visit.description"));
            GameObject.Find($"{Root}/Final Buttons/ScanForNewLevels/UILabel").GetComponent<UILabel>().text = Language.GetLine("workshop.downloadnew");
            GameObject.Find($"{Root}/Final Buttons/ScanForNewLevels").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("workshop.downloadnew.description"));
            GameObject.Find($"{Root}/Final Buttons/RefreshAll/UILabel").GetComponent<UILabel>().text = Language.GetLine("workshop.updateall");
            GameObject.Find($"{Root}/Final Buttons/RefreshAll").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("workshop.updateall.description"));
            GameObject.Find($"{Root}/Final Buttons/UnsubscribeAll/UILabel").GetComponent<UILabel>().text = Language.GetLine("workshop.unsubscribeall");
            GameObject.Find($"{Root}/Final Buttons/UnsubscribeAll").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("workshop.unsubscribeall.description"));

            Disable();
        }
    }
}
