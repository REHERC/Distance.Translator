using Distance.Translator.UnityScripts;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(ControlsMenuActionEntry), "Init")]
    public class ControlsMenuActionEntry__Init__Patch
    {
        static void Postfix(ControlsMenuActionEntry __instance)
        {
            __instance.gameObject.AddComponent<UpdateActionEntry>();
        }
    }
}