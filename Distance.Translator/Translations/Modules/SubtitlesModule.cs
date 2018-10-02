﻿using System;

namespace Distance.Translator
{
    class SubtitlesModule : TranslateModule
    {
        public override string Name => "Subtitles";

        public override bool IsValidContext()
        {
            return Flags.GameMode && Flags.OfficialCampaign && !Flags.Loading && !Flags.GamePaused;
        }

        public override void Run()
        {
            /*
            try
            {
                if (Game.CurrentMode == Spectrum.Interop.Game.GameMode.Adventure && SceneManager.GetActiveScene().name == "GameMode")
                {
                    if (G.Sys.OptionsManager_.Audio_.SubtitlesVisible_)
                    {
                        GameObject SubtitlesObject = GameObject.Find("AudioManager/UI Root/Panel/Anchor : Subtitles/Subtitles");
                        UILabel Subtitles = SubtitlesObject?.GetComponent<UILabel>();
                        if (Subtitles?.text != "")
                        {
                            switch (Subtitles.text.ToLowerInvariant())
                            {
                                case "[999999](intercom)[-] the array is our new home.":
                                    Subtitles.text = "[999999](Intercom)[-] h.";
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            */
        }
    }
}
