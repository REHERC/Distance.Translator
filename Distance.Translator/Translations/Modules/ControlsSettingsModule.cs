﻿using static Distance.Translator.Extensions.StringExtensions;
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
            return $"{Root()}/ControlsDefinitions";
        }

        public static string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Controls/Panel - MenuTitle";
            return "OptionsFrontRoot(Clone)/Panel - Options/Panel - Controls/Panel - MenuTitle";
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
            
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/Device Scheme Options/DevicePopup/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.device").UP();
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/Device Scheme Options/SchemePopup/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme").UP();

            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/SchemeButtonRow/EditSchemeButton/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme.edit").UP();
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/SchemeButtonRow/DeleteButton/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme.delete").UP();
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/SchemeButtonRow/DuplicateButton/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme.duplicate").UP();
            GameObject.Find($"{BasicOptions()}/DeviceAndSchemeOptions/SchemeButtonRow/RenameButton/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.scheme.rename").UP();
            
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/InvertYAxis/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.inverty").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/UpsideDownSelfRighting/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.selfrighting").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlightLandingAssist/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.landingassist").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlightStabilization/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.stabilization").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/InvertBoost/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.invertboost").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/RumbleIntensity/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.rumbleintensity").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/SteeringSensitivity/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.steeringintensity").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlightSensitivityX/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.yawsensitivity").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/FlightSensitivityY/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.pitchsensitivity").UP();
            GameObject.Find($"{BasicOptions()}/TogglesAndSliders/Digital Input Smoothing/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.controls.general.inputsmoothing").UP();
            
            Disable();
        }
    }
}
