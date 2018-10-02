using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
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
            GameObject.Find($"{Root}/Campaign/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.campaign");
            GameObject.Find($"{Root}/Arcade/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.arcade");
            GameObject.Find($"{Root}/Multiplayer/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.multiplayer");
            GameObject.Find($"{Root}/Level Editor/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.leveleditor");
            GameObject.Find($"{Root}/Steam Workshop/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.workshop");
            GameObject.Find($"{Root}/Garage/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.garage");
            GameObject.Find($"{Root}/Options/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.options");
            GameObject.Find($"{Root}/Quit/UILabel").GetComponent<UILabel>().text = Language.GetLine("mainmenu.quit");
            
            Disable();
        }
    }
}
