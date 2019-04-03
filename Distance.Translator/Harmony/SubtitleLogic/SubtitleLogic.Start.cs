using static Distance.Translator.CurrentPlugin;
using Distance.Translator.Extensions;
using Harmony;
using Spectrum.API.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(SubtitleLogic), "Start")]
    public class SubtitleLogic__Start__Patch
    {
        static void Postfix(SubtitleLogic __instance)
        {
            SubtitleState.subtitlesDefaultScale = __instance.label_.defaultFontSize;

            if (Configuration["Debug"] is true && new List<string>(from argument in Environment.GetCommandLineArgs() select argument.DOWN()).Contains("-extract-subtitles"))
            {
                Settings settings = new Settings("subtitles_extracted");
                settings.Clear();
                foreach (var subtitle_entry in __instance.subtitles_)
                {
                    settings.Add(subtitle_entry.Key, subtitle_entry.Value);
                }
                settings.Save();

                try
                {
                    settings = new Settings("subtitles_defaults");
                    settings.Clear();
                    foreach (string key in __instance.subtitles_.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value).Keys)
                    {
                        foreach (uint marker in __instance.subtitles_[key].Keys)
                        {
                            string value = __instance.subtitles_[key][marker];
                            string csv_id = $"{key}/{marker}";
                            Distance.Translator.T4.GeneratedDictionaries.SubtitleBindings.TryGetValue(csv_id, out string json_id);

                            if (!settings.ContainsKey(json_id ?? csv_id))
                                settings.Add(json_id ?? csv_id, value);
                            else
                                Console.WriteLine(json_id ?? csv_id);
                        }
                    }
                    settings.Save();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}