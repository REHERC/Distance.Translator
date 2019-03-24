using Distance.Translator.UnityScripts;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(UILabel), "OnStart")]
    public class UILabel__OnStart__Patch
    {
        static void Postfix(UILabel __instance)
        {
            __instance.gameObject.AddComponent<Distance.Translator.UnityScripts.UILabelTranslate>();
        }
    }
}
