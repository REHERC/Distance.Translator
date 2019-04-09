using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class VRSettingsModule : TranslateModule
    {
        public static string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/VR Options/Options/OptionsTable";
            return "OptionsFrontRoot(Clone)/Panel - Options/VR Options/Options/OptionsTable";
        }

        public static string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/VR Options/MenuTitleTemplate";
            return "OptionsFrontRoot(Clone)/Panel - Options/VR Options/MenuTitleTemplate";
        }

        public override string Name => "VR Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode" || scene.name == "LevelEditor");
        }

        public override void Run()
        {
            GameObject.Find($"{Root()}/Enable VR/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.enable").UP();
            GameObject.Find($"{Root()}/Enable VR").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.enable.description"));
            GameObject.Find($"{Root()}/Camera Shake/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.camerashake").UP();
            GameObject.Find($"{Root()}/Camera Shake").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.camerashake.description"));
            GameObject.Find($"{Root()}/Neck Spring/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.neckspring").UP();
            GameObject.Find($"{Root()}/Neck Spring").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.neckspring.description"));
            GameObject.Find($"{Root()}/Render Scale/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.renderscale").UP();
            GameObject.Find($"{Root()}/Render Scale").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.renderscale.description"));
            GameObject.Find($"{Root()}/Steer Dampening/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.steerdampening").UP();
            GameObject.Find($"{Root()}/Steer Dampening").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.steerdampening.description"));
            GameObject.Find($"{Root()}/Incline Camera Rotation/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.inclinecamera").UP();
            GameObject.Find($"{Root()}/Incline Camera Rotation").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.inclinecamera.description"));
            GameObject.Find($"{Root()}/World Scale/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.worldscale").UP();
            GameObject.Find($"{Root()}/World Scale").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.worldscale.description"));
            GameObject.Find($"{Root()}/3rd Person Camera (Intense)/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.thirdpersoncamera").UP();
            GameObject.Find($"{Root()}/3rd Person Camera (Intense)").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.thirdpersoncamera.description"));
            GameObject.Find($"{Root()}/3rd Person Scalar/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.vr.thirdpersonscalar").UP();
            GameObject.Find($"{Root()}/3rd Person Scalar").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.vr.thirdpersonscalar.description"));

            Disable();
        }
    }
}
