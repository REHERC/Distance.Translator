using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class ControlsHelpModule : DynamicTranslateModule
    {
        public override string Name => "Controls Help";

        public override bool Run(ref UILabel instance)
        {
            instance.text = Language.GetLine("settings.controls.info.help");
            return true;
        }
    }
}
