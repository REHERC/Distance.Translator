using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class WorkshopHighlight : TranslateModule
    {
        private string WorkshopCount = "#WORKSHOPCOUNT";

        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu Audio";

        public void Run()
        {
            if (GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/Window Content - Workshop") != null)
            {
                UILabel label = GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/Window Content - Workshop/Header Label").GetComponent<UILabel>();
                if (label.text == "LOADING...")
                {
                    label.text = Language.MAINMENU_WORKSHOP_HIGHLIGHT_LOADING;
                }
                else if (label.text.Length > 52 && label.text.StartsWith("[96B0FF]WORKSHOP HIGHLIGHT[-] - "))
                {
                    string levelcount = label.text.Substring(32);
                    levelcount = levelcount.Substring(0, levelcount.Length - 20);
                    WorkshopCount = levelcount;
                    label.text = String.Format(Language.MAINMENU_WORKSHOP_HIGHLIGHT, WorkshopCount);
                }
                else
                {
                    label.text = String.Format(Language.MAINMENU_WORKSHOP_HIGHLIGHT, WorkshopCount);
                }
            }
        }
    }
}