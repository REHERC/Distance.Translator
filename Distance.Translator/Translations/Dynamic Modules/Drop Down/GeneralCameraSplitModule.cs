using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GeneralCameraSplitModule : DynamicTranslateModule
    {
        public override string Name => "General Settings Split-Screen Camera Split Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "VERTICAL":
                    instance.text = Language.GetLine("settings.general.camerasplit.vertical");
                    break;
                case "HORIZONTAL":
                    instance.text = Language.GetLine("settings.general.camerasplit.horizontal");
                    break;
            }
            return true;
        }

        public override void Reset(ref UILabel instance)
        {
            ResetDropDown(ref instance);
        }
    }
}
