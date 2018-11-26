using static Distance.Translator.Extensions.AudioMenuExtensions;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(AudioMenu), "InitializeVirtual")]
    public class AudioMenu__InitializeVirtual__Patch
    {
        static void Postfix(AudioMenu __instance)
        {
            __instance.CreateLanguageDropdown();
        }
    }
}
