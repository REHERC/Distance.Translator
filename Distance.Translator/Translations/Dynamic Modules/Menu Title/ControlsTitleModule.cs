using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class ControlsTitleModule : DynamicTranslateModule
    {
        public override string Name => "Controls Settings Title";

        public override bool Run(ref UILabel instance)
        {
            instance.text = string.Format(Language.GetLine("settings.controls.description"), G.Sys.ProfileManager_.CurrentProfile_.Name_);
            return true;
        }
    }
}
