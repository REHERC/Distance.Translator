using UnityEngine;

namespace Distance.Translator
{
    class SubmenuAdventure : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Submenu Adventure";

        public void Run()
        {
            if (GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/AdventureButtonsPanel/AdventureButtons") != null)
            {
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/AdventureButtonsPanel/AdventureButtons/Final Buttons/Campaign/UILabel").GetComponent<UILabel>().text = Language.ADVENTURE_PREVIEW;
                GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/AdventureButtonsPanel/AdventureButtons/Final Buttons/Campaign").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.ADVENTURE_PREVIEW_DESCRIPTION);

                CanRun = false;
            }
        }
    }
}