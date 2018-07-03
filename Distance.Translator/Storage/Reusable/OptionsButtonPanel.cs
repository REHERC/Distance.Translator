using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance.Translator
{
    public static partial class Translate
    {
        public static void OptionsPanelButtons(UILabel label)
        {
            switch (label.text.ToUpper())
            {
                case "AUDIO":
                    label.text = Language.OPTIONS_AUDIO;
                    break;
                case "GENERAL":
                    label.text = Language.OPTIONS_GENERAL;
                    break;
                case "CONTROLS":
                    label.text = Language.OPTIONS_CONTROLS;
                    break;
                case "GRAPHICS":
                    label.text = Language.OPTIONS_GRAPHICS;
                    break;
                case "PROFILES":
                    label.text = Language.OPTIONS_PROFILES;
                    break;
                case "REPLAY":
                    label.text = Language.OPTIONS_REPLAY;
                    break;
                case "CHEATS":
                    label.text = Language.OPTIONS_CHEATS;
                    break;
            }
        }

        public static void ReplaysPanelButtons(UILabel label)
        {
            switch (label.gameObject.name.ToUpper())
            {
                case "GHOSTS IN ARCADE TYPE":
                    label.text = Language.OPTIONS_REPLAYS_TYPE;
                    break;
                case "GHOSTS IN ARCADE COUNT":
                    label.text = Language.OPTIONS_REPLAYS_COUNT;
                    break;
                case "GHOSTS BRIGHTNESS":
                    label.text = Language.OPTIONS_REPLAYS_BRIGHTNESS;
                    break;
                case "GHOSTS NAMES VISIBLE":
                    label.text = Language.OPTIONS_REPLAYS_NAMESVISIBLE;
                    break;
                case "PLAYBACK SPEED AFFECTS MUSIC":
                    label.text = Language.OPTIONS_REPLAYS_PLAYBACKSPEED;
                    break;
            }
        }
    }
}
