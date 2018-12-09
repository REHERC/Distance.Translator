using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GeneralVisualizerModule : DynamicTranslateModule
    {
        public override string Name => "General Settings Car Screen Visualizer Drop-Down";

        public override bool Run(ref UILabel instance)
        {
            switch (instance.text.UP())
            {
                case "OFF":
                    instance.text = Language.GetLine("settings.general.visualizer.off");
                    break;
                case "CIRCLE":
                    instance.text = Language.GetLine("settings.general.visualizer.circle");
                    break;
                case "BARS":
                    instance.text = Language.GetLine("settings.general.visualizer.bars");
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
