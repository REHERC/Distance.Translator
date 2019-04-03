using Events.Audio;
using Harmony;
using System;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(SubtitleLogic), "OnSubtitleEvent")]
    public class SubtitleLogic__OnSubtitleEvent__Patch
    {
        static bool Prefix(SubtitleLogic __instance, SubtitleEvent.Data data)
        {
            if (__instance.currentEmitter_ != null && data.emitter_ != __instance.currentEmitter_ && __instance.recentCarCam_ != null && (__instance.recentCarCam_.transform.position - data.emitter_.transform.position).sqrMagnitude > __instance.distanceToCurrentEmitter_)
                return false;
            __instance.CheckCameraDistance(data.emitter_);
            if (__instance.distanceToCurrentEmitter_ > data.emitter_.MaxAttenuationSq_)
                return false;

            __instance.currentEmitter_ = data.emitter_;
            __instance.timer_ = __instance.timeOut_;
            
            Postfix(__instance, data);
            return false;
        }
        
        static void Postfix(SubtitleLogic __instance, SubtitleEvent.Data data)
        {
            if (__instance.currentEmitter_ is null || data.emitter_ is null)
                return;
            __instance.CheckCameraDistance(data.emitter_);
            if (__instance.distanceToCurrentEmitter_ > data.emitter_.MaxAttenuationSq_)
                return;

            SubtitleState.strLabel = data.strLabel_;
            SubtitleState.markerID = data.markerID_;
            SubtitleState.forceString = data.forceString_;
            SubtitleState.emitter = data.emitter_;

            if (G.Sys.GameManager_.ModeID_ != GameModeID.Adventure)
                return;

            AdventureMode mode = G.Sys.GameManager_.Mode_ as AdventureMode;
            TimeSpan countdown = TimeSpan.FromSeconds(mode.GetCountdownTime());

            SubtitleState.countdownHours = countdown.Hours;
            SubtitleState.countdownMinutes = countdown.Minutes;
            SubtitleState.countdownSeconds = countdown.Seconds;
        }
    }
}
