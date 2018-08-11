using UnityEngine;

namespace Distance.Translator
{
    public static partial class UpdateEveryFrame
    {
        public static int FrameCount = 0;
        private const int UpdateEveryNFrames = 2;
        private static int Counter = 0;

        public static void Swoosh()
        {
            Counter++;
            if (Counter == UpdateEveryNFrames || Counter > UpdateEveryNFrames)
            {
                Counter = 0;
                Bois();
            }
        }

        private static void Bois() {
            TranslationManager.Run();
            
            FrameCount++;
        }
    }
}
