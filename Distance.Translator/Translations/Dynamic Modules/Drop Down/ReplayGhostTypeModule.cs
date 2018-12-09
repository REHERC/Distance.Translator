using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class ReplayGhostTypeModule : DynamicTranslateModule
    {
        public override string Name => "Replay Settings Ghost Type Drop-Down";

        public override bool Run(ref UILabel instance)
        {
            switch (instance.text.UP())
            {
                case "DISABLED":
                    instance.text = Language.GetLine("settings.replay.type.disabled");
                    break;
                case "LOCAL":
                    instance.text = Language.GetLine("settings.replay.type.local");
                    break;
                case "FRIENDS":
                    instance.text = Language.GetLine("settings.replay.type.friends");
                    break;
                case "NEAR MY RANKING":
                    instance.text = Language.GetLine("settings.replay.type.ranking");
                    break;
                case "GLOBAL BEST":
                    instance.text = Language.GetLine("settings.replay.type.best");
                    break;
            }
            return true;
        }

        public override void Reset(ref UILabel instance)
        {
            ResetDropDown(ref instance);
        }
    }
}
