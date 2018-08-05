using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class MainmenuProfiles : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Profiles Settings";

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

            if (GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/") != null)
            {
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/MenuTitleTemplate/UILabel - Title").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_TITLE;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/Panel - CreateProfile/Add Profile Name Input").GetComponent<UIExInput>().defaultText = Language.OPTIONS_PROFILES_ENTERNAME;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/Panel - CreateProfile/UILabel - Create A New Profile").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_CREATE;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/Panel - CreateProfile/Add Profile/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_ADD;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/Panel - EditProfile/Rename Profile/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_RENAME;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/Panel - EditProfile/Delete Profile/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_DELETE;
                GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/Panel - SelectProfile/SelectPrimaryProfileLabel").GetComponent<UILabel>().text = Language.OPTIONS_PROFILES_SELECT;

                CanRun = false;
            }
        }
    }
}