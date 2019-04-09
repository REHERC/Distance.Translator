using Events.Audio;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(LoadingCustomMusic), "OnEventCustomMusicScanComplete")]
    public class LoadingCustomMusic__OnEventCustomMusicScanComplete__Patch
    {
        static void Postfix(LoadingCustomMusic __instance, CustomMusicScanComplete.Data data)
        {
            CustomMusicState.state = CustomMusicState.ScanState.Complete;
            CustomMusicState.scanningFolder = "";
            CustomMusicState.fileCount = data.fileCount_;
        }
    }
}