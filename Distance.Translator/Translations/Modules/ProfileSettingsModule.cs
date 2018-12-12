using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class ProfileSettingsModule : TranslateModule
    {
        public static string Root()
        {
            return "OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center";
        }

        public static string MenuTitleTemplate()
        {
            return "OptionsFrontRoot/Panel - Options/Panel - Profiles/MenuTitleTemplate";
        }

        public override string Name => "Profile Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu");
        }

        public override void Run()
        {
            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Title").GetComponent<UILabel>().text = Language.GetLine("settings.profiles.title");

            GameObject.Find($"{Root()}/Panel - EditProfile/Rename Profile/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.profiles.edit.rename").UP();
            GameObject.Find($"{Root()}/Panel - EditProfile/Delete Profile/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.profiles.edit.delete").UP();

            GameObject.Find($"{Root()}/Panel - SelectProfile/SelectPrimaryProfileLabel").GetComponent<UILabel>().text = Language.GetLine("settings.profiles.select.title").UP();
            
            GameObject.Find($"{Root()}/Panel - CreateProfile/UILabel - Create A New Profile").GetComponent<UILabel>().text = Language.GetLine("settings.profiles.create.title").UP();
            GameObject.Find($"{Root()}/Panel - CreateProfile/Add Profile Name Input").GetComponent<UIExInput>().defaultText = Language.GetLine("settings.profiles.create.entername");
            GameObject.Find($"{Root()}/Panel - CreateProfile/Add Profile/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.profiles.create.add").UP();
            GameObject.Find($"{Root()}/Panel - CreateProfile/ErrorMessage").GetComponent<UILabel>().text = Language.GetLine("settings.profiles.create.entername.warning").UP();
            
            Disable();
        }
    }
}
