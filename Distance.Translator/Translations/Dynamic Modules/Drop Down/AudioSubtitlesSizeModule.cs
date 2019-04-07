using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class AudioSubtitlesSizeModule : DynamicTranslateModule
    {
        public override string Name => "Audio Settings Subtitles Size Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "SMALL":
                    instance.text = Language.GetLine("settings.audio.subtitles.size.small");
                    break;
                case "DEFAULT":
                    instance.text = Language.GetLine("settings.audio.subtitles.size.default");
                    break;
                case "LARGE":
                    instance.text = Language.GetLine("settings.audio.subtitles.size.large");
                    break;
                case "EXTRA LARGE":
                    instance.text = Language.GetLine("settings.audio.subtitles.size.extra");
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
