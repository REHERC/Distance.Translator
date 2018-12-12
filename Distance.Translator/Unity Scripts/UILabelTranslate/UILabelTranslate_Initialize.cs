using static Distance.Translator.ModuleManager;
using UnityEngine;
using Distance.Translator.Modules;
using System.Collections.Generic;

namespace Distance.Translator.UnityScripts
{
    public partial class UILabelTranslate : MonoBehaviour
    {
        public IEnumerable<DynamicTranslateModule> GetModules()
        {
            foreach (var Check in DynamicChecks)
            {
                DynamicTranslateModule module = Check.Value(this._label);

                if (module != null)
                {
                    yield return module;
                }
            }
        }
    }
}
