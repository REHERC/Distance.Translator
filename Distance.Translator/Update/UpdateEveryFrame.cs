using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    public static partial class UpdateEveryFrame
    {
        private const int UpdateEveryNFrames = 2;
        private static int Counter = 0;

        public static void Swoosh()
        {
            Counter++;
            if (Counter == UpdateEveryNFrames || Counter > UpdateEveryNFrames)
            {
                Counter = 0;
                Bois();
            }
        }

        private static void Bois() {
            Scene scene = SceneManager.GetActiveScene();
            switch (scene.name)
            {
                case "MainMenu":
                    try
                    {
                        // If profile table is found (not equal to null) then we are in the profile options menu
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
                            
                            GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - EditProfile/EditSelectedProfileLabel").GetComponentsInChildren<UILabel>()[0].text = "[c][848484]" + String.Format(Language.OPTIONS_PROFILES_EDIT, "[-][/c]" + G.Sys.ProfileManager_.CurrentProfile_.Name_);
                        }
                    } finally { /* Meh it's just so the compiler doesn't complain that there's no catch () {} or finally {} and i didn't wanted to make the same "catch (Exception SWOOSHYBOI) { }" joke ._. */ }
                    break;
            }
        }
    }
}
