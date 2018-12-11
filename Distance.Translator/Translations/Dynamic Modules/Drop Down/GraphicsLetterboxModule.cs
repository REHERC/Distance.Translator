using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsLetterboxModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Cinematic Letterbox Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.bonuseffects.letterbox.off");
                    break;
                case "21 : 9":
                    instance.text = Language.GetLine("settings.graphics.bonuseffects.letterbox.21_9");
                    break;
                case "16 : 9":
                    instance.text = Language.GetLine("settings.graphics.bonuseffects.letterbox.16_9");
                    break;
            }

            return true;
        }
    }
}