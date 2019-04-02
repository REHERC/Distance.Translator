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
                    ScanForCountdownSubtitle(ref csv_id, ref display, ref json_id);
                }

                if (Language.GetBool("subtitles#override.font.scale"))
                    SetFontSize(ref __instance, json_id);
                if (json_id != "" && json_id.Length > 0 && json_id != string.Empty && json_id != null)
                    __instance.label_.text = display;
            }
        }

        static void ScanForCountdownSubtitle(ref string csv_id, ref string display, ref string json_id)
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

            json_id = line;
            display = string.Format(Language.GetLine(line), SubtitleRes.countdownHours, SubtitleRes.countdownMinutes, SubtitleRes.countdownSeconds);
        }

        static void SetFontSize(ref SubtitleLogic __instance, string json_id)
        {
            AudioSettings audio = G.Sys.OptionsManager_.Audio_;
            float num = 1f;
            switch (audio.SubtitlesFontSize_)
            {
                case SubtitlesFontSize.Small:
                    num = 0.75f;
                    break;
                case SubtitlesFontSize.Large:
                    num = 1.5f;
                    break;
                case SubtitlesFontSize.ExtraLarge:
                    num = 2f;
                    break;
            }
            __instance.label_.fontSize = (int)Math.Round((double)SubtitleRes.subtitlesDefaultScale * (double)num * (double)Language.GetFloat($"{json_id}#font.scale"));
        }
    } 
}
