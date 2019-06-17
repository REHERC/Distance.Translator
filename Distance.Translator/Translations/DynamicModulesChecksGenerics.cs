using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    public static partial class ModuleChecks
    {
        private static bool _DropDown(Transform tr, string name)
        {
            UIExPopupList list = tr.parent.parent.gameObject.GetComponent<UIExPopupList>();
            return list.name.UP() == name.UP();
        }

        private static DropDownMode _DropDown(ref UILabel instance)
        {
            GameObject go = instance.gameObject;
            if (go.HasComponent<UIEventListener>() && go.transform.parent.name == "Drop-down List")
                return DropDownMode.Context;
            if (go.transform.parent.parent.HasComponent<UIExPopupList>() && go.name == "PopupLabel")
                return DropDownMode.List;
            return DropDownMode.None;
        }

        public static bool DropDown(ref UILabel instance, string name)
        {
            switch (_DropDown(ref instance))
            {
                case DropDownMode.List:
                    return _DropDown(instance.transform, name.UP());
                case DropDownMode.Context:
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
            return tr.DOWN().StartsWith(path.DOWN());
        }

        public static string GetRoot(Dictionary<string,string> values)
        {
            Scene scene = SceneManager.GetActiveScene();
            
            if (values.ContainsKey(scene.name.DOWN()))
                return values[scene.name.DOWN()];
            if (values.ContainsKey("default"))
                return values["default"];
            return "";
        }
    }
}
