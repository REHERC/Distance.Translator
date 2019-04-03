using Events.Audio;
using Harmony;
using System;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(LoadingCustomMusic), "OnEventLoadingCustomMusic")]
    public class LoadingCustomMusic__OnEventLoadingCustomMusic__Patch
    {
        static void Postfix(LoadingCustomMusic __instance, CustomMusicScanningFolder.Data data)
        {

        }
    }
}