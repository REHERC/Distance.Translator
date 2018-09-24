using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        // Only meant for translations purposes...
        //[HarmonyPatch(typeof(VROptionsMenu))]
        //[HarmonyPatch("DisplayInMenu")]
        internal class VROptionsMenu_DisplayInMenu_Patch : VROptionsMenu
        {
            static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }

        //[HarmonyPatch(typeof(VRSettings))]
        //[HarmonyPatch("EnableVR_", PropertyMethod.Getter)]
        internal class VRSettings_EnabledInThisBuild_Getter : VRSettings
        {
            static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }

    }
}