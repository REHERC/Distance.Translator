using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsShadowQualityModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Shadow Quality Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.advanced.shadowquality.off");
                    break;
                case "LOW":
                    instance.text = Language.GetLine("settings.graphics.advanced.shadowquality.low");
                    break;
                case "MEDIUM":
                    instance.text = Language.GetLine("settings.graphics.advanced.shadowquality.medium");
                    break;
                case "HIGH":
                    instance.text = Language.GetLine("settings.graphics.advanced.shadowquality.high");
                    break;
                case "ULTRA":
                    instance.text = Language.GetLine("settings.graphics.advanced.shadowquality.ultra");
                    break;
            }

            return true;
        }
    }
}