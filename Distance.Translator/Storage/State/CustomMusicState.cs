using System;

namespace Distance.Translator
{
    public static class CustomMusicState
    {
        public static ScanState state = ScanState.Complete;
        public static ErrorState error = ErrorState.NoFolderSpecified;
        public static string scanningFolder = "";
        public static int fileCount = 0;

        [Flags]
        public enum ScanState
        {
            Started,
            Running,
            Complete
        }

        [Flags]
        public enum ErrorState
        {
            NoFolderSpecified,
            FolderNotFound,
            NoTracksFound,
            Ok
        }
    }
}
