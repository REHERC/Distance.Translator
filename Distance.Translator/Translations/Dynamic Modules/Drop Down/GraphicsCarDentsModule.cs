using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsCarDentsModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Car DentsDrop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "ON":
                    instance.text = Language.GetLine("settings.graphics.advanced.cardents.on");
                    break;
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.advanced.cardents.off");
                    break;
            }

            return true;
        }
    }
}