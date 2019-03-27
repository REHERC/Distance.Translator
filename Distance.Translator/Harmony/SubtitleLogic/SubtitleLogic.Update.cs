using Harmony;
using System;
using Distance.Translator.T4;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(SubtitleLogic), "Update")]
    public class SubtitleLogic__Update__Patch
    {
        static void Postfix(SubtitleLogic __instance)
        {
            if (__instance.timer_ > 0)
            {
                string display, csv_id, json_id;
                display = csv_id = json_id = "";

                csv_id = $"{SubtitleRes.strLabel}/{SubtitleRes.markerID}";

                if (GeneratedDictionaries.SubtitleBindings.ContainsKey(csv_id))
                {
                    GeneratedDictionaries.SubtitleBindings.TryGetValue(csv_id, out json_id);
                    display = Language.GetLine(json_id);
                }
                else
                {
                    csv_id = csv_id.Substring(0, csv_id.Length - 2);
                    ScanForCountdownSubtitle(ref csv_id, ref display);
                }
                __instance.label_.text = display;
            }
        }

        static void ScanForCountdownSubtitle(ref string csv_id, ref string display)
        {
            if (G.Sys.GameManager_.ModeID_ != GameModeID.Adventure)
                return;

            bool hours = csv_id.ToLowerInvariant().Contains($"{SubtitleRes.countdownHours} hours");
            bool minutes = csv_id.ToLowerInvariant().Contains($"{SubtitleRes.countdownMinutes} minutes");
            bool seconds = csv_id.ToLowerInvariant().Contains($"{SubtitleRes.countdownSeconds} seconds");

            string line = "subtitles.cb_time"
                        + (hours ? "_hours" : string.Empty)
                        + (minutes ? "_minutes" : string.Empty)
                        + (seconds ? "_seconds" : string.Empty);

            if (hours is false && minutes is false && seconds is false)
                return;
            
            display = string.Format(Language.GetLine(line), SubtitleRes.countdownHours, SubtitleRes.countdownMinutes, SubtitleRes.countdownSeconds);
        }
    } 
}
