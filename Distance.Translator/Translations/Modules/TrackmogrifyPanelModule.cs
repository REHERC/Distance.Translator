using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    public partial class TrackmogrifyPanelModule : TranslateModule
    {
        string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                return "TrackmogrifyInputMenu/Panel(16:9)/Create a Profile Input";
            }
            return "TrackmogrifyInputMenu/Panel(16:9)/Create a Profile Input";
        }

        public override string Name => "Trackmogrify Panel";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode");
        }

        public override void Run()
        {
            GameObject.Find($"{Root()}/UILabel - Message").GetComponent<UILabel>().text = Language.GetLine("trackmogrify.seed").UP();
            GameObject.Find($"{Root()}/Track Name Input").GetComponent<UIExInput>().defaultText = Language.GetLine("trackmogrify.seed.placeholder");
            GameObject.Find($"{Root()}/RecentSeedsPanel/UILabel - Recent Seeds Header").GetComponent<UILabel>().text = Language.GetLine("trackmogrify.recent").UP();
            GameObject.Find($"{Root()}/PopularSeedsPanel/UILabel - Popular Seeds Header").GetComponent<UILabel>().text = Language.GetLine("trackmogrify.recent").UP();
            
            Disable();
        }
    }
}