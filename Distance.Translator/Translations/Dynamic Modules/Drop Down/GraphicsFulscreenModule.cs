using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsFullscreenModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Fullscreen Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "ON":
                    instance.text = Language.GetLine("settings.graphics.videosettings.fullscreen.on");
                    break;
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.videosettings.fullscreen.off");
                    break;
            }

            return true;
        }
    }
}