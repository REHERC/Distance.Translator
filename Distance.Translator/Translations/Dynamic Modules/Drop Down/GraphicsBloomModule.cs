﻿using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class GraphicsBloomModule : DynamicTranslateModule
    {
        public override string Name => "Graphics Settings Bloom Drop-Down";

        public override void Init(ref UILabel instance)
        {
            base.Init(ref instance);
        }

        public override bool Run(ref UILabel instance)
        {
            switch (this._state)
            {
                case "ON":
                    instance.text = Language.GetLine("settings.graphics.advanced.bloom.on");
                    break;
                case "OFF":
                    instance.text = Language.GetLine("settings.graphics.advanced.bloom.off");
                    break;
            }

            return true;
        }
    }
}