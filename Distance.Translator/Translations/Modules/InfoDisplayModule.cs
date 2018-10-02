using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distance.Translator
{
    class InfoDisplayModule : TranslateModule
    {
        public override string Name => "Info Display";

        public override bool IsValidContext()
        {
            return Flags.GameMode && Flags.OfficialCampaign && !Flags.Loading;
        }

        public override void Run()
        {

        }
    }
}
