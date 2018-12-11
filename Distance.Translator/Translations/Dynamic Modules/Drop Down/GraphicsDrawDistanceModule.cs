using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsDrawDistanceModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Draw Distance Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "NEAR":
                    instance.text = Language.GetLine("settings.graphics.advanced.drawdistance.near");
                    break;
                case "MEDIUM":
                    instance.text = Language.GetLine("settings.graphics.advanced.drawdistance.medium");
                    break;
                case "FAR":
                    instance.text = Language.GetLine("settings.graphics.advanced.drawdistance.far");
                    break;
            }

            return true;
        }
    }
}