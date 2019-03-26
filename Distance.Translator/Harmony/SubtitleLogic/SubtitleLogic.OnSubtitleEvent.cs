using Events.Audio;
using Harmony;
using System;
using System.Collections.Generic;
using UnityEngine;

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

            SubtitleRes.strLabel = data.strLabel_;
            SubtitleRes.markerID = data.markerID_;
            SubtitleRes.forceString = data.forceString_;
            SubtitleRes.emitter = data.emitter_;
        }
    }

    public static class SubtitleRes
    {
        public static string strLabel = null;
        public static uint markerID = 0;
        public static bool forceString = false;
        public static AmbientAudioObject emitter;
    }

}
