using static Distance.Translator.Extensions.GeneralMenuExtensions;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(GeneralMenu), "InitializeVirtual")]
    public class GeneralMenu__InitializeVirtual__Patch
    {
        static void Postfix(GeneralMenu __instance)
        {
            __instance.CreateLanguageDropdown();
        }
    }
}
