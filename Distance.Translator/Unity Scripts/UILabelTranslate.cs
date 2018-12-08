using static Distance.Translator.CurrentPlugin;
using Distance.Translator.Modules;
using System.Collections.Generic;
using UnityEngine;

namespace Distance.Translator.UnityScripts
{
    public partial class UILabelTranslate : MonoBehaviour
    {
        private UILabel _label;
        private List<DynamicTranslateModule> _modules;
        
        void Start()
        {
            this._label = this.gameObject.GetComponent<UILabel>();
            this._modules = new List<DynamicTranslateModule>(GetModules());
            
            ModuleManager.OnResetAll += this.Reset;

            if (this._modules.Count == 0)
            {
                UnityEngine.Object.Destroy(this.gameObject.GetComponent<UILabelTranslate>());
            }
        }

        void FixedUpdate()
        {
            if (this._label != null)
            {
                foreach (DynamicTranslateModule module in this._modules)
                {
                    module.Run(ref _label);
                }
            }
        }

        void Reset()
        {
            foreach (DynamicTranslateModule module in this._modules)
            {
                module.Reset(ref _label);
            }
        }

        void OnDestroy()
        {
            if (Configuration["Debug"] is true)
            {
                
            }
        }
    }
}
