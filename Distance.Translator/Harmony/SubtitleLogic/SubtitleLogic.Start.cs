using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(SubtitleLogic), "Start")]
    public class SubtitleLogic__Start__Patch
    {
        static void Postfix(SubtitleLogic __instance)
        {
            SubtitleRes.subtitlesDefaultScale = __instance.label_.defaultFontSize;
        }
    }
}