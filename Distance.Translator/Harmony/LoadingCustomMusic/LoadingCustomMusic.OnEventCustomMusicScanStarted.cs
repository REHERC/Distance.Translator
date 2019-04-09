using Events.Audio;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(LoadingCustomMusic), "OnEventCustomMusicScanStarted")]
    public class LoadingCustomMusic__OnEventCustomMusicScanStarted__Patch
    {
        static void Postfix(LoadingCustomMusic __instance, CustomMusicScanStarted.Data data)
        {
            CustomMusicState.state = CustomMusicState.ScanState.Started;
            CustomMusicState.scanningFolder = "";
            CustomMusicState.fileCount = 0;
        }
    }
}