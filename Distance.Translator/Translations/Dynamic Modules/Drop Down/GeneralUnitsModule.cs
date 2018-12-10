using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GeneralUnitsModule : DynamicTranslateModule
    {
        public override string Name => "General Settings Units Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "IMPERIAL":
                    instance.text = Language.GetLine("settings.general.units.imperial");
                    break;
                case "METRIC":
                    instance.text = Language.GetLine("settings.general.units.metric");
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
