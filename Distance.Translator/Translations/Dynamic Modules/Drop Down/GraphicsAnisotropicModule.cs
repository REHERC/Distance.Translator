using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsAnisotropicModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Anisotropic Filtering Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.advanced.anisotropic.off");
                    break;
                case "PARTIAL":
                    instance.text = Language.GetLine("settings.graphics.advanced.anisotropic.partial");
                    break;
                case "FULL":
                    instance.text = Language.GetLine("settings.graphics.advanced.anisotropic.full");
                    break;
            }

            return true;
        }
    }
}