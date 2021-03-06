﻿using Harmony;
using System;
using Distance.Translator.T4;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(SubtitleLogic), "Update")]
    public class SubtitleLogic__Update__Patch
    {
        static void Postfix(SubtitleLogic __instance)
        {
            string display, csv_id, json_id;
            display = csv_id = json_id = "";

            csv_id = $"{SubtitleState.strLabel}/{SubtitleState.markerID}";
            
            if (__instance.timer_ > 0)
            {
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
                
                if (json_id != "" && json_id.Length > 0 && json_id != string.Empty && json_id != null)
                    __instance.label_.text = display;
            }
        }

        static void ScanForCountdownSubtitle(ref string csv_id, ref string display, ref string json_id)
        {
            if (G.Sys.GameManager_.ModeID_ != GameModeID.Adventure) 
                return;

            bool hours = csv_id.ToLowerInvariant().Contains($"{SubtitleState.countdownHours} hours");
            bool minutes = csv_id.ToLowerInvariant().Contains($"{SubtitleState.countdownMinutes} minutes");
            bool seconds = csv_id.ToLowerInvariant().Contains($"{SubtitleState.countdownSeconds} seconds");

            string line = "subtitles.cb_time"
                        + (hours ? "_hours" : string.Empty)
                        + (minutes ? "_minutes" : string.Empty)
                        + (seconds ? "_seconds" : string.Empty);

            if (hours is false && minutes is false && seconds is false)
                return;

            json_id = line;
            display = string.Format(Language.GetLine(line), SubtitleState.countdownHours, SubtitleState.countdownMinutes, SubtitleState.countdownSeconds);
        }
    } 
}
