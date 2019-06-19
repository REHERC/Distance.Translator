using System.Linq;
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
            Events.Cheats.CampaignPlusChanged.Subscribe((data) =>
            {
                foreach (var module in from item in ModuleManager.Modules where item.Name is "Main Menu" && item.IsValidContext() select item)
                    module.Enable();
            });

            Log.Success("Subscribed to Events!");
        }
    }
}
