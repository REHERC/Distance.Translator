﻿using static Distance.Translator.CurrentPlugin;
using Distance.Translator.Modules;
using System.Collections.Generic;
using UnityEngine;
using System;

#pragma warning disable CS0168

namespace Distance.Translator.UnityScripts
{
    public partial class UILabelTranslate : MonoBehaviour
    {
        private UILabel _label;
        private List<DynamicTranslateModule> _modules;
        
        void Start()
        {
            _label = this.gameObject.GetComponent<UILabel>();
            _modules = new List<DynamicTranslateModule>(GetModules());

            ModuleManager.OnResetAll += this.Reset;  

            if (_modules.Count == 0)
            {
                Destroy(gameObject.GetComponent<UILabelTranslate>());
                return;
            }

            foreach (DynamicTranslateModule module in this._modules)
                module.Init(ref _label);
        }

        void LateUpdate()
        {
            if (this._label != null)
                foreach (DynamicTranslateModule module in this._modules)
                    try
                    {
                        module.Init(ref _label);
                        module.Run(ref _label);
                    }
                    catch (Exception PolygonFace) { }
        }

        void Reset()
        {
            foreach (DynamicTranslateModule module in this._modules)
                module.Reset(ref _label);
        }
    }
}
