using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsReflectionsModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Real-Time Reflections Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.advanced.reflections.off");
                    break;
                case "LOW":
                    instance.text = Language.GetLine("settings.graphics.advanced.reflections.low");
                    break;
                case "MEDIUM":
                    instance.text = Language.GetLine("settings.graphics.advanced.reflections.medium");
                    break;
                case "HIGH":
                    instance.text = Language.GetLine("settings.graphics.advanced.reflections.high");
                    break;
                case "ULTRA":
                    instance.text = Language.GetLine("settings.graphics.advanced.reflections.ultra");
                    break;
            }

            return true;
        }
    }
}