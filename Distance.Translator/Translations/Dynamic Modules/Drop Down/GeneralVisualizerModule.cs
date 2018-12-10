using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GeneralVisualizerModule : DynamicTranslateModule
    {
        public override string Name => "General Settings Car Screen Visualizer Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
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
