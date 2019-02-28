using Spectrum.Interop.Game;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
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
            try
            {
                if (Game.CurrentMode == Spectrum.Interop.Game.GameMode.Adventure && SceneManager.GetActiveScene().name == "GameMode")
                    if (G.Sys.OptionsManager_.Audio_.SubtitlesVisible_)
                    {
                        GameObject SubtitlesObject = GameObject.Find("AudioManager/UI Root/Panel/Anchor : Subtitles/Subtitles");
                        UILabel Subtitles = SubtitlesObject?.GetComponent<UILabel>();
                        if (Subtitles?.text != "")
                            switch (Subtitles.text.ToLowerInvariant())
                            {
                                case "[999999](intercom)[-] the array is our new home.":
                                    //Subtitles.text = "[999999](Intercom)[-] h.";
                                    break;
                            }
                    }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e) { }
#pragma warning restore CS0168 // Variable is declared but never used
        }
    }
}
