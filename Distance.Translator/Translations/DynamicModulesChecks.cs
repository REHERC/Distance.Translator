using static Distance.Translator.Extensions.StringExtensions;
using System.Collections.Generic;

namespace Distance.Translator.Modules
{
    public static partial class ModuleChecks
    {
        public static DynamicTranslateModule General_Units_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "UNITS"))
            {
                return new GeneralUnitsModule();
            }
            return null;
        }

        public static DynamicTranslateModule General_Visualizer_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "CAR SCREEN VISUALIZER"))
            {
                return new GeneralVisualizerModule();
            }
            return null;
        }

        public static DynamicTranslateModule General_CameraSplit_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "SPLIT-SCREEN CAMERA SPLIT"))
            {
                return new GeneralCameraSplitModule();
            }
            return null;
        }

        public static DynamicTranslateModule General_Title(ref UILabel instance)
        {
            if (IsParentableTo(Util.GameObjectPath(instance.transform), GetRoot(new Dictionary<string, string>(){
                {"default", "OptionsFrontRoot/Panel - Options/General/MenuTitleTemplate"},
                {"mainmenu", "OptionsFrontRoot/Panel - Options/General/MenuTitleTemplate"}
            }
            )))
            {
                System.Console.WriteLine(Util.GameObjectPath(instance.transform));
                if (instance.transform.name == "UILabel - Title")
                {
                    return new GeneralTitleModule();
                }
            }
            return null;
        }

        public static DynamicTranslateModule Replay_Title(ref UILabel instance)
        {
            if (IsParentableTo(Util.GameObjectPath(instance.transform), GetRoot(new Dictionary<string, string>(){
                {"default", "OptionsFrontRoot/Panel - Options/Replay/MenuTitleTemplate"},
                {"mainmenu", "OptionsFrontRoot/Panel - Options/Replay/MenuTitleTemplate"}
            }
            )))
            {
                System.Console.WriteLine(Util.GameObjectPath(instance.transform));
                if (instance.transform.name == "UILabel - Title")
                {
                    return new ReplayTitleModule();
                }
            }
            return null;
        }
    }
}
