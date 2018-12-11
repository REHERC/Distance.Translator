using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsAntiAliasingModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Anti-Aliasing Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.advanced.antialiasing.off");
                    break;
                case "FXAA FAST":
                    instance.text = Language.GetLine("settings.graphics.advanced.antialiasing.fxaa_fast");
                    break;
                case "FXAA QUALITY":
                    instance.text = Language.GetLine("settings.graphics.advanced.antialiasing.fxaa_quality");
                    break;
            }

            return true;
        }
    }
}