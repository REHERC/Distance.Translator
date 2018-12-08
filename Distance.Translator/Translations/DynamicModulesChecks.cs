using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    public static partial class ModuleChecks
    {
        public static DynamicTranslateModule General_Units_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "UNITS"))
            {
                return new GeneralUnitsDropDownModule();
            }
            return null;
        }

        public static DynamicTranslateModule General_Visualizer_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "CAR SCREEN VISUALIZER"))
            {
                return new GeneralVisualizerDropDownModule();
            }
            return null;
        }

        public static DynamicTranslateModule General_CameraSplit_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "SPLIT-SCREEN CAMERA SPLIT"))
            {
                return new GeneralCameraSplitDropDownModule();
            }
            return null;
        }
    }
}
