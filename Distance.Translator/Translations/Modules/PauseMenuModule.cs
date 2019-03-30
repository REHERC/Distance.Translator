using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class PauseMenuModule : TranslateModule
    {
        const string Root = "MainMenuFrontRoot/UI Root/Panel - Main/MainButtonsPanel/MainButtons";

        public override string Name => "Pause Menu";
        
        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return scene.name == "GameMode" && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {


            Disable();
        }
    }
}
