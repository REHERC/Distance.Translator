using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class MainmenuProfilesRefresh : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Profiles Settings Refresh";

        public void Run()
        {
            string PathPrefix = "";
            Scene scene = SceneManager.GetActiveScene();
            switch (scene.name)
            {
                case "MainMenu":
                    PathPrefix = "OptionsFrontRoot";
                    break;
                default:
                    CanRun = false;
                    return;
            }

            if (GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/") != null)
            {
                GameObject ProfileTable = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - SelectProfile/Profile List/SubPanel/Profile Table/");
                if (ProfileTable != null)
                {
                    // Add the "(selected)" suffix on the currently selected profile item in the list
                    foreach (ProfilesMenuProfileButton Profile in ProfileTable.GetComponentsInChildren<ProfilesMenuProfileButton>())
                    {
                        if (!(Profile.transform.name == "ProfileButtonBlueprint"))
                        {
                            UILabel Item = Profile.gameObject.GetComponentInChildren<UILabel>();
                            if (Item.text.EndsWith("[444444](selected)") && Item.text.Contains(G.Sys.ProfileManager_.CurrentProfile_.Name_))
                            {
                                string ProfileName = Item.text.Substring(0, Item.text.Length - 10);
                                Item.text = ProfileName + Language.OPTIONS_PROFILES_SELECTED;
                            }
                        }
                    }

                    GameObject.Find(PathPrefix + "/Panel - Options/Panel - Profiles/Anchor - Center/Panel - EditProfile/EditSelectedProfileLabel").GetComponentsInChildren<UILabel>()[0].text = "[c][848484]" + String.Format(Language.OPTIONS_PROFILES_EDIT, "[-][/c]" + G.Sys.ProfileManager_.CurrentProfile_.Name_);
                }
            }
        }
    }
}