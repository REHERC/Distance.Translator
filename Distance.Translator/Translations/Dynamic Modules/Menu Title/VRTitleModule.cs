using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class VRTitleModule : DynamicTranslateModule
    {
        public override string Name => "VR Settings Title";

        public override bool Run(ref UILabel instance)
        {
            instance.text = Language.GetLine("settings.vr.title");
            return true;
        }
    }
}
