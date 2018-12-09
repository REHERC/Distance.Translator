using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GeneralTitleModule : DynamicTranslateModule
    {
        public override string Name => "General Settings Title";

        public override bool Run(ref UILabel instance)
        {
            instance.text = Language.GetLine("settings.general.title");
            return true;
        }
    }
}
