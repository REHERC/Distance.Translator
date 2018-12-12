using static Distance.Translator.CurrentPlugin;
using Distance.Translator.Modules;
using System.Collections.Generic;
using UnityEngine;
using System;

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
                return;
            }

            foreach (DynamicTranslateModule module in this._modules)
            {
                module.Init(ref _label);
            }
        }

        void LateUpdate()
        {
            if (this._label != null)
            {
                foreach (DynamicTranslateModule module in this._modules)
                {
                    try
                    {
                        module.Run(ref _label);
                    }
#pragma warning disable CS0168 // Variable is declared but never used
                    catch (Exception PolygonFace) { }
#pragma warning restore CS0168 // Variable is declared but never used
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
    }
}
