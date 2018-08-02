using UnityEngine;

namespace Distance.Translator
{
    class MainmenuProfiles : TranslateTask
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu Profiles";

        public void Run()
        {
            if (GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/") != null)
            {
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/MenuTitleTemplate/UILabel - Title").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_TITLE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - CreateProfile/Add Profile Name Input").GetComponent<UIExInput>().defaultText = Language.OPTIONS_PROFILES_ENTERNAME;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - CreateProfile/UILabel - Create A New Profile").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_CREATE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - CreateProfile/Add Profile/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_ADD;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - EditProfile/Rename Profile/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_RENAME;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - EditProfile/Delete Profile/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_DELETE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - SelectProfile/SelectPrimaryProfileLabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_SELECT;

                CanRun = false;
            }
        }
    }
}