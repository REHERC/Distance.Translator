using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsTextureQualityModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Texture Quality Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "LOW":
                    instance.text = Language.GetLine("settings.graphics.advanced.texturequality.low");
                    break;
                case "MEDIUM":
                    instance.text = Language.GetLine("settings.graphics.advanced.texturequality.medium");
                    break;
                case "HIGH":
                    instance.text = Language.GetLine("settings.graphics.advanced.texturequality.high");
                    break;
                case "ULTRA":
                    instance.text = Language.GetLine("settings.graphics.advanced.texturequality.ultra");
                    break;
            }

            return true;
        }
    }
}