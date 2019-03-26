using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(SubtitleLogic), "Update")]
    public class SubtitleLogic__Update__Patch
    {
        static void Postfix(SubtitleLogic __instance)
        {
            if (__instance.timer_ > 0)
            {
                string subtitle_csv_id = $"{SubtitleRes.strLabel}/{SubtitleRes.markerID}";
                T4.GeneratedDictionaries.SubtitleBindings.TryGetValue(subtitle_csv_id, out string subtitle_json_id);
                __instance.label_.text = Language.GetLine(subtitle_json_id);
            }
        }
    }
}
