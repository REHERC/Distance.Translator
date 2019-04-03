using Events.Audio;
using Harmony;
using System;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(LoadingCustomMusic), "OnEventCustomMusicScanStarted")]
    public class LoadingCustomMusic__OnEventCustomMusicScanStarted__Patch
    {
        static void Postfix(LoadingCustomMusic __instance, CustomMusicScanStarted.Data data)
        {

        }
    }
}