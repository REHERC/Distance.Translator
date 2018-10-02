using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distance.Translator
{
    public static class EventSubscriber
    {
        public static void Initialize()
        {
            CurrentPlugin.Log.Info("Subscribing to Events ...");

            Events.Scene.StartLoad.Subscribe((data) =>
            {
                ModuleManager.ResetAll();
            });
            Events.Scene.LoadFinish.Subscribe((data) =>
            {
                ModuleManager.ResetAll();
            });
            Events.LevelEditor.PlayModeActiveChanged.Subscribe((data) =>
            {
                ModuleManager.ResetAll();
                //Flags.LevelEditor = !data.active_;
            });

            CurrentPlugin.Log.Success("Subscribed to Events!");
        }
    }
}
