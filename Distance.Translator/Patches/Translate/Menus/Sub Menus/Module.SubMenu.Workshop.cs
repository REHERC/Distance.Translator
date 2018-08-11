using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class SubmenuWorkshop : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Submenu Workshop";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons") != null)
                {
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons/Final Buttons/VisitWorkshop/UILabel").GetComponent<UILabel>().text = Language.WORKSHOP_VISIT;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons/Final Buttons/VisitWorkshop").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.WORKSHOP_VISIT_DESCRIPTION);
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons/Final Buttons/ScanForNewLevels/UILabel").GetComponent<UILabel>().text = Language.WORKSHOP_DOWNLOAD;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons/Final Buttons/ScanForNewLevels").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.WORKSHOP_DOWNLOAD_DESCRIPTION);
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons/Final Buttons/RefreshAll/UILabel").GetComponent<UILabel>().text = Language.WORKSHOP_UPDATE;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons/Final Buttons/RefreshAll").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.WORKSHOP_UPDATE_DESCRIPTION);
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons/Final Buttons/UnsubscribeAll/UILabel").GetComponent<UILabel>().text = Language.WORKSHOP_UNSUBSCRIBE;
                    GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/WorkshopButtonsPanel/WorkshopButtons/Final Buttons/UnsubscribeAll").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.WORKSHOP_UNSUBSCRIBE_DESCRIPTION);

                    CanRun = false;
                }
            }
            else
            {
                CanRun = false;
            }
        }
    }
}