using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsVsyncModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Vsync Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "ENABLED":
                    instance.text = Language.GetLine("settings.graphics.videosettings.vsync.enabled");
                    break;
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.videosettings.vsync.off");
                    break;
            }

            return true;
        }
    }
}