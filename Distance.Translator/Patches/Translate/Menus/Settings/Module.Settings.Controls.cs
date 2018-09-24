﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class MainmenuControls : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Controls Settings";

        public void Run()
        {
            string PathPrefix = "";
            Scene scene = SceneManager.GetActiveScene();
            switch (scene.name)
            {
                case "MainMenu":
                    PathPrefix = "OptionsFrontRoot";
                    break;
                case "GameMode":
                    PathPrefix = "OptionsFrontRoot(Clone)";
                    break;
                default:
                    CanRun = false;
                    return;
            }

            if (GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel") != null)
            {
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/Device Scheme Options/DevicePopup/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_DEVICE;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/Device Scheme Options/SchemePopup/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_SCHEME_SELECTED;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/EditSchemeButton/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_SCHEME_EDIT;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/DeleteButton/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_SCHEME_DELETE;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/DuplicateButton/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_SCHEME_DUPLICATE;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/RenameButton/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_SCHEME_RENAME;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/InvertYAxis/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_INVERTY;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/UpsideDownSelfRighting/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_SELFRIGHTING;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/FlightLandingAssist/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_LANDINGASSIST;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/RumbleIntensity/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_RUMBLEINTENSITY;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SteeringSensitivity/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_STEERINGSENSITIVITY;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/FlightSensitivity/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_FLIGHTSENSITIVITY;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/Digital Input Smoothing/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_INPUTSMOOTHING;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1000").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_TAB_BASIC;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1001").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_TAB_FLIGHT;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1002").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_TAB_CAMERA;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1003").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_TAB_MENU;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Controls/Panel - MenuTitle/UILabel - Title").GetComponent<UILabel>().text = Language.OPTIONS_CONTROLS_TITLE;

                CanRun = false;
            }
        }
    }
}