using System;
using Harmony;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(UILabel), "Update")]
        internal class UILabel_Update_Patch : UILabel
        {
            public static void Postfix(UILabel __instance)
            {
                try
                {
                    Scene scene = SceneManager.GetActiveScene();
                    if (scene.name == "MainMenu" || scene.name == "GameMode" || !Game.isInEditor)
                    {
                        Translate.DropDown(ref __instance);
                        Translate.ControlsListingTable(ref __instance);
                        Translate.MenuTitles(ref __instance);
                    }
                }
                catch (Exception BEARD)
                {
                    
                }
                
            }
        }
    }
}