namespace Distance.Translator
{
    public partial class Photon
    {
        // Only meant for translations purposes...
        //[HarmonyPatch(typeof(ExperimentalMenu))]
        //[HarmonyPatch("DisplayInMenu")]
        internal class ExperimentalMenu_DisplayInMenu_Patch : ExperimentalMenu
        {
            static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }

    }
}