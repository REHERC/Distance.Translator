using Events.Audio;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(SubtitleLogic), "OnSubtitleEvent")]
    public class SubtitleLogic__OnSubtitleEvent__Patch
    {
        static void Postfix(SubtitleLogic __instance, SubtitleEvent.Data data)
        {
            __instance.CheckCameraDistance(data.emitter_);
            string event_name = $"subtitles.{Minify(data.emitter_.event_)}_{Minify(data.strLabel_)}_{data.markerID_}_{data.emitter_.currentPlayingID_}";
            if ((data.emitter_.playState_ == AmbientAudioObject.PlayState.Play || data.forceString_) && __instance.distanceToCurrentEmitter_ <= data.emitter_.maxAttenuationSq_)
            {
                Flags.subtitle_id = __instance.timer_ <= 0 ? "subtitles.empty" : event_name;
                Events.Plugins.SubtitleEvent.Broadcast(Flags.subtitle_id);
            }
        }

        static string Minify(string input)
        {
            string output = input.Replace("-", " ");
            while (output.Contains("  "))
                output = output.Replace("  ", " ");
            return output.Replace(" ", "_").ToLowerInvariant();
        }
    }
}
