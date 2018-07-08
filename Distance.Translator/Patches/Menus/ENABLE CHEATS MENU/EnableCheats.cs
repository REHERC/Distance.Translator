using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        // Only meant for translations purposes...
        [HarmonyPatch(typeof(CheatsManager))]
        [HarmonyPatch("EnabledInThisBuild_", PropertyMethod.Getter)]
        internal class CheatsManager_EnabledInThisBuild_Getter : CheatsManager
        {
            static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }
    }
}