using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(UIPanel), "Start")]
        internal class UIPanel_Start_Patch
        {
            public static void Postfix(UIPanel __instance)
            {
                Translate.UIPanel(__instance);
            }
        }
    }
}