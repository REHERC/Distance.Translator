using Events.Audio;
using Harmony;
using System;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(LoadingCustomMusic), "OnEventCustomMusicScanComplete")]
    public class LoadingCustomMusic__OnEventCustomMusicScanComplete__Patch
    {
        static void Postfix(LoadingCustomMusic __instance, CustomMusicScanComplete.Data data)
        {

        }
    }
}