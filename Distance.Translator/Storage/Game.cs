namespace Distance.Translator
{
    public static class Game
    {
        private static bool _isInEditor = false;
        public static bool isInEditor {
            get
            {
                return _isInEditor;
            }
            set
            {
                _isInEditor = value;
            }
        }
    }
}
