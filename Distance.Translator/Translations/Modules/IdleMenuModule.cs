using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    public partial class IdleMenuModule : TranslateModule
    {
        const string Root = "MainMenuFrontRoot/UI Root/Panel - Idle";

        public override string Name => "Idle Menu";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return scene.name == "MainMenu" && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root}/UIPanel - PressAnyButton/UILabel - PressAnyButton").GetComponent<UILabel>().text = Language.GetLine("mainmenu.pressanybutton");

            Disable();
        }
    }
}
