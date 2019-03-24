using Harmony;
using UnityEngine;

namespace Distance.Translator.Harmony
{
    //[HarmonyPatch(typeof(SubtitleLogic), "Update")]
    public class SubtitleLogic__Update__Patch
    {
        static string current = "";
        static string last = "";

        static void Prefix(SubtitleLogic __instance)
        {
            current = GetEventId(__instance);
        }

        static void Postfix(SubtitleLogic __instance)
        {
            if (current != last)

            last = GetEventId(__instance);
        }

        static string GetEventId(SubtitleLogic __instance)
        {
            return $"{__instance.currentEmitter_.event_}_{__instance.currentEmitter_.currentPlayingID_}";
        }
    }
}
