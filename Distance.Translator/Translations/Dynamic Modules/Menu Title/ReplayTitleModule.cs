using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class ReplayTitleModule : DynamicTranslateModule
    {
        public override string Name => "Replay Settings Title";

        public override bool Run(ref UILabel instance)
        {
            instance.text = Language.GetLine("settings.replay.title");
            return true;
        }
    }
}
