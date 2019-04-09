using Harmony;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(AudioManager), "GetFilesInDirectory")]
    public class AudioManager__GetFilesInDirectory__Patch
    {
        static void Postfix(AudioManager __instance, ref string root)
        {
            if (string.IsNullOrEmpty(root))    
            {
                CustomMusicState.error = CustomMusicState.ErrorState.NoFolderSpecified;
                return;
            }
            DirectoryInfo directoryInfo = DirectoryEx.GetDirectoryInfo(root);
            if (!directoryInfo.Exists)
            {
                CustomMusicState.error = CustomMusicState.ErrorState.NoFolderSpecified;
                return;
            }
            try
            {
                List<string> files = new List<string>(from s in Directory.GetFiles(root, "*.*", SearchOption.TopDirectoryOnly)
                                                      where s.EndsWith(".mp3") || s.EndsWith(".wav") || s.EndsWith(".aiff")
                                                      select s);
                if (files.Count < 1)
                {
                    CustomMusicState.error = CustomMusicState.ErrorState.NoTracksFound;
                    return;
                }
            }
            catch (Exception)
            {
                CustomMusicState.error = CustomMusicState.ErrorState.NoTracksFound;
                return;
            }
            CustomMusicState.error = CustomMusicState.ErrorState.Ok;
        }
    }
}