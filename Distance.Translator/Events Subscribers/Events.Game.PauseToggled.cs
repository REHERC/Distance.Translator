namespace Distance.Translator
{
    static partial class EventListeners
    {
        public static void Game_PauseToggled(Events.Game.PauseToggled.Data data)
        {
            if (data.paused_)
            {
                // Nothing to see here (will be deleted in the future)
            }
        }
    }
}
