using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using System;

namespace Distance.Translator.Modules
{
    public static partial class ModuleChecks
    {
        private static bool _DropDown(Transform tr, string name)
        {
            UIExPopupList list = tr.parent.parent.gameObject.GetComponent<UIExPopupList>();
            if (list.name.UP() == name.UP())
                return true;
            return false;
        }

        private static DropDownMode _DropDown(ref UILabel instance)
        {
            GameObject go = instance.gameObject;
            if (go.HasComponent<UIEventListener>() && go.transform.parent.name == "Drop-down List")
            {
                return DropDownMode.Context;
            }
            if (go.transform.parent.parent.HasComponent<UIExPopupList>() && go.name == "PopupLabel")
            {
                return DropDownMode.List;
            }
            return DropDownMode.None;
        }

        public static bool DropDown(ref UILabel instance, string name)
        {
            switch (_DropDown(ref instance))
            {
                case DropDownMode.List:
                    Console.WriteLine("LIST");
                    return _DropDown(instance.transform, name.UP());
                case DropDownMode.Context:
                    Console.WriteLine("CONTEXT");
                    return UIPopupList.current.name.UP() == name.UP();
            }
            return false;
        }

        public enum DropDownMode
        {
            None = 1,
            List = 2,
            Context = 4
        }

        public static bool IsParentableTo(string tr, string path)
        {
            if (tr.StartsWith(path))
                return true;
            return false;
        }
    }
}
