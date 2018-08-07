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
            TranslationManager.Run();

            /*
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
                            foreach (ProfilesMenuProfileButton Profile in ProfileTable.GetComponent<ProfilesMenuProfileButton>())
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
                            // Set the current profile name on the edit header
                            GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - EditProfile/EditSelectedProfileLabel").GetComponent<UILabel>().text = "[c][848484]" + String.Format(Language.OPTIONS_PROFILES_EDIT, "[-][/c]" + G.Sys.ProfileManager_.CurrentProfile_.Name_);
                        }
                    } catch (Exception ONION) { }
                    try
                    {
                        GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Controls/Panel - MenuTitle/UILabel - Description").GetComponent<UILabel>().text = String.Format(Language.OPTIONS_CONTROLS_SUBTITLE, G.Sys.ProfileManager_.CurrentProfile_.Name_);
                    } catch (Exception ONION) { }
                    //try
                    //{
                    //    GameObject MENUTITLE_GO = GameObject.Find("Panel - Main/DistanceTitle");
                    //    if (MENUTITLE_GO != null)
                    //    {
                    //        Transform MENUTITLE_TR = MENUTITLE_GO.GetComponent<Transform>();
                    //        if (MENUTITLE_TR != null)
                    //        {
                    //            //MENUTITLE_TR.RotateAround(MENUTITLE_TR.position, Vector3.forward, 20 * Time.fixedDeltaTime);
                    //            MENUTITLE_TR.eulerAngles = new Vector3(0,0,0);
                    //        }
                    //    }
                    //} finally { }
                    try
                    {
                        GameObject WORKSHOP_HIGHLIGHT_GO = GameObject.Find("MainMenuFrontRoot/UI Root/Panel - Main/Window Content - Workshop/Header Label");
                        if (WORKSHOP_HIGHLIGHT_GO != null && WORKSHOP_HIGHLIGHT_GO.HasComponent<UILabel>())
                        {
                            UILabel WORKSHOP_HIGHLIGHT = WORKSHOP_HIGHLIGHT_GO.GetComponent<UILabel>();
                            if (WORKSHOP_HIGHLIGHT != null)
                            {
                                Translate.WorkshopHighlight(ref WORKSHOP_HIGHLIGHT);
                            }
                        }
                    } finally { }
                    break;
            }
            */
        }
    }
}
