using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class AudioAnnouncerSettingsModule : DynamicTranslateModule
    {
        public override string Name => "Audio Settings Announcer Settings Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "ALL MODES":
                    instance.text = Language.GetLine("settings.audio.announcer.options.all");
                    break;
                case "ARCADE ONLY":
                    instance.text = Language.GetLine("settings.audio.announcer.options.arcade");
                    break;
                case "STUNT ONLY":
                    instance.text = Language.GetLine("settings.audio.announcer.options.stunt");
                    break;
                case "DISABLED":
                    instance.text = Language.GetLine("settings.audio.announcer.options.disabled");
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
