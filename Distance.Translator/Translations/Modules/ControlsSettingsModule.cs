using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class ControlsSettingsModule : TranslateModule
    {
        public static string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel";
            return "OptionsFrontRoot(Clone)/Panel - Options/Panel - Controls/MenuPanel";
        }

        public static string BasicOptions()
        {
            return $"{Root()}/BasicOptions/BasicOptionsButtons";
        }
        
        public static string ControlsDefinitions()
        {
            return $"{Root()}/BasicOptions/ControlsDefinitions";
        }

        public static string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Controls/MenuTitleTemplate";
            return "OptionsFrontRoot(Clone)/Panel - Options/Panel - Controls/MenuTitleTemplate";
        }

        public override string Name => "Controls Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode" || scene.name == "LevelEditor");
        }

        public override void Run()
        {
            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Title").GetComponent<UILabel>().text = Language.GetLine("settings.controls.title");
            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Description").GetComponent<UILabel>().text = string.Format(Language.GetLine("settings.controls.description"), G.Sys.ProfileManager_.CurrentProfile_.Name_);
            
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/Device Scheme Options/DevicePopup/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.device").UP();
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/Device Scheme Options/SchemePopup/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme").UP();

            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/SchemeButtonRow/EditSchemeButton/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme.edit").UP();
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/SchemeButtonRow/DeleteSchemeButton/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme.delete").UP();
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/SchemeButtonRow/DuplicateSchemeButton/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme.duplicate").UP();
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/SchemeButtonRow/RenameSchemeButton/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme.rename").UP();
            
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/InvertYAxis/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.inverty").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/UpsideDownSelfRighting/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.selfrighting").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlightLandingAssist/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.landingassist").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlightLandingAssist/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.landingassist").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlisgtStabilization/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.stabilization").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/InvertBoost/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.invertboost").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/RumbleIntensity/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.rumbleintensity").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/SteeringIntensity/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.steeringintensity").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlightSensitivityX/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.yawsensitivity").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlightSensitivityY/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.pitchsensitivity").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/Digital Input Smoothing/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.inputsmoothing").UP();
            
            GameObject.Find($"{ControlsDefinitions()}/TopTabs/ControlPageTabSubPanel/PageTabsTable/1000/Name").GetComponent<UILabel>().text = Language.GetLine("settings.controls.tabs.basic");
            GameObject.Find($"{ControlsDefinitions()}/TopTabs/ControlPageTabSubPanel/PageTabsTable/1001/Name").GetComponent<UILabel>().text = Language.GetLine("settings.controls.tabs.flight");
            GameObject.Find($"{ControlsDefinitions()}/TopTabs/ControlPageTabSubPanel/PageTabsTable/1002/Name").GetComponent<UILabel>().text = Language.GetLine("settings.controls.tabs.camera");
            GameObject.Find($"{ControlsDefinitions()}/TopTabs/ControlPageTabSubPanel/PageTabsTable/1003/Name").GetComponent<UILabel>().text = Language.GetLine("settings.controls.tabs.menu");

            GameObject.Find($"{ControlsDefinitions()}/EditAreaButton/BottomThingy/UILabel - CurrentSchemeName").GetComponent<UILabel>().text = string.Format(Language.GetLine("settings.controls.info.help"), G.Sys.ProfileManager_.CurrentProfile_.Name_, G.Sys.PlayerManager_.Current_.InputDevice_.Scheme_.name_);
            GameObject.Find($"{ControlsDefinitions()}/EditAreaButton/BottomThingy/HelpLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.info.help");

            Disable();
        }
    }
}
