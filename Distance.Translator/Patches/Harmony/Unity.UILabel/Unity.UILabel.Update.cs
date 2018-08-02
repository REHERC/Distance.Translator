using System;
using Harmony;

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
                    Translate.DropDown(ref __instance);
                    Translate.ControlsListingTable(ref __instance);
                    Translate.MenuTitles(ref __instance);
                }
                catch (Exception BEARD)
                {
                    
                }
                
            }
        }
    }
}