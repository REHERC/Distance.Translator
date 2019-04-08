using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(VROptionsMenu), "DisplayInMenu")]
    public class VROptionsMenu__DisplayInMenu__Patch
    {
        static void Postfix(VROptionsMenu __instance, ref bool __result)
        {
            __result = true;
        }
    }
}
