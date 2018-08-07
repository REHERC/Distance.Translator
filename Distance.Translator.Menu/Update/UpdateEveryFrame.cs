namespace Distance.Translator.Menu
{
    public static partial class UpdateEveryFrame
    {
        private const int UpdateEveryNFrames = 2;
        private static int Counter = 0;

        public static bool MenuCreated = false;

        public static void Swoosh()
        {
            Counter++;
            if (Counter == UpdateEveryNFrames || Counter > UpdateEveryNFrames)
            {
                Counter = 0;
                Bois();
            }
        }

        private static void Bois()
        {
            
        }
    }
}