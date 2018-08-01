using UnityEngine;

namespace Distance.Translator
{
    class MainmenuControls : TranslateTask
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu Controls";

        public void Run()
        {
            if (GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel") != null)
            {
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/Device Scheme Options/DevicePopup/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_DEVICE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/Device Scheme Options/SchemePopup/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_SELECTED;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/EditSchemeButton/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_EDIT;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/DeleteButton/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_DELETE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/DuplicateButton/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_DUPLICATE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SchemeButtonRow/RenameButton/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SCHEME_RENAME;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/InvertYAxis/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_INVERTY;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/UpsideDownSelfRighting/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_SELFRIGHTING;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/FlightLandingAssist/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_LANDINGASSIST;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/RumbleIntensity/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_RUMBLEINTENSITY;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/SteeringSensitivity/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_STEERINGSENSITIVITY;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/FlightSensitivity/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_FLIGHTSENSITIVITY;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/BasicOptions/BasicOptionsAreaButton/Digital Input Smoothing/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_INPUTSMOOTHING;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1000").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TAB_BASIC;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1001").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TAB_FLIGHT;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1002").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TAB_CAMERA;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/MenuPanel/ControlsDefinitions/TopTabs/ControlPageTabSubPanel/PageTabsTable/1003").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TAB_MENU;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/Panel - MenuTitle/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_CONTROLS_TITLE;

                CanRun = false;
            }
        }
    }
}