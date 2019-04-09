using Events.Audio;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(LoadingCustomMusic), "OnEventLoadingCustomMusic")]
    public class LoadingCustomMusic__OnEventLoadingCustomMusic__Patch
    {
        static void Postfix(LoadingCustomMusic __instance, CustomMusicScanningFolder.Data data)
        {
            CustomMusicState.state = CustomMusicState.ScanState.Running;
            CustomMusicState.scanningFolder = data.folderName_;
            CustomMusicState.fileCount = data.fileCount_;
        }
    }
}