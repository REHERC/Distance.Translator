﻿namespace Distance.Translator
{
    public partial class Photon
    {
        // Only meant for translations purposes...
        //[HarmonyPatch(typeof(PS4GraphicsMenu))]
        //[HarmonyPatch("DisplayInMenu")]
        internal class PS4GraphicsMenu_DisplayInMenu_Patch : PS4GraphicsMenu
        {
            static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }

    }
}