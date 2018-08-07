using Harmony;

namespace Distance.Translator.Menu
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(GeneralMenu), "InitializeVirtual")]
        internal class GeneralMenu_InitializeVirtual_Patch : GeneralMenu
        {
            public static void Postfix(GeneralMenu __instance)
            {
                __instance.TweakLanguage();
            }
        }
    }
}