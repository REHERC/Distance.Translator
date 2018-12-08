using static Distance.Translator.Extensions.StringExtensions;
using System;
using UnityEngine;

namespace Distance.Translator.Modules
{
    class GeneralVisualizerDropDownModule : DynamicTranslateModule
    {
        public override string Name => "General Settings Car Screen Visualizer Drop-Down";

        public override bool Run(ref UILabel instance)
        {
            try
            {
                switch (instance.text.UP())
                {
                    case "OFF":
                        instance.text = Language.GetLine("settings.general.visualizer.off");
                        break;
                    case "CIRCLE":
                        instance.text = Language.GetLine("settings.general.visualizer.circle");
                        break;
                    case "BARS":
                        instance.text = Language.GetLine("settings.general.visualizer.bars");
                        break;
                }
                return true;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception PolygonFace) { return false; }
#pragma warning restore CS0168 // Variable is declared but never used
        }

        public override void Reset(ref UILabel instance)
        {
            GameObject go = instance.transform.parent.parent.gameObject;
            UIExPopupList list = go.GetComponent<UIExPopupList>();
            if (list != null)
            {
                instance.text = list.value;
            }
        }
    }
}
