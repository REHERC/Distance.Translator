using static Distance.Translator.CurrentPlugin;

namespace Distance.Translator
{
    public static class EventSubscriber
    {
        public static void Initialize()
        {
            Log.Info("Subscribing to Events ...");

            Events.Scene.StartLoad.Subscribe((data) =>
            {
                ModuleManager.ResetAll();
            });
            Events.Scene.LoadFinish.Subscribe((data) =>
            {
                ModuleManager.ResetAll();
            });
            Events.Game.LevelLoaded.Subscribe((data) =>
            {
                ModuleManager.ResetAll();
                //Flags.LevelEditor = !data.active_;
            });

            Log.Success("Subscribed to Events!");
        }
    }
}
