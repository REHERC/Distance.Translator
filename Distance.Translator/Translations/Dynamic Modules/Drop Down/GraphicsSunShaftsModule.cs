using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsSunShaftsModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Sun Shafts Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "ON":
                    instance.text = Language.GetLine("settings.graphics.advanced.sunshafts.on");
                    break;
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.advanced.sunshafts.off");
                    break;
            }

            return true;
        }
    }
}