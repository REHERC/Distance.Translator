using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using Spectrum.API;
using Spectrum.API.Configuration;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Logging;
using UnityEngine;
using UnityEngine.UI;

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
