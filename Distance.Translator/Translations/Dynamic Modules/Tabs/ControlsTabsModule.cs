using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class ControlsTabsModule : DynamicTranslateModule
    {
        public override string Name => "Controls Tabs";

        public override bool Run(ref UILabel instance)
        {
            switch (instance.transform.parent.gameObject.name.UP())
            {
                case "0000":
                    instance.text = Language.GetLine("settings.controls.tabs.basic");
                    break;
                case "0001":
                    instance.text = Language.GetLine("settings.controls.tabs.flight");
                    break;
                case "0002":
                    instance.text = Language.GetLine("settings.controls.tabs.camera");
                    break;
                case "0003":
                    instance.text = Language.GetLine("settings.controls.tabs.menu");
                    break;
            }
            return true;
        }
    }
}
