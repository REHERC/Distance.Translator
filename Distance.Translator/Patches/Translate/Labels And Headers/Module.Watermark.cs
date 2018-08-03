using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class Watermark : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu Audio";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                string[] Lines = Spectrum.Interop.Game.Game.WatermarkText.Split('\n');
                if (Lines.Length > 1)
                {
                    Spectrum.Interop.Game.Game.WatermarkText = "";
                    for (int i = 0; i < Lines.Length; i++)
                    {
                        string Line = (i == 1) ? Language.GetWatermarkExtension() : Lines[i];
                        Spectrum.Interop.Game.Game.WatermarkText += Line;
                    }
                    Spectrum.Interop.Game.Game.WatermarkText = Spectrum.Interop.Game.Game.WatermarkText.TrimEnd('\n');

                    CanRun = false;
                }
            }
            else
            {
                CanRun = false;
            }
        }
    }
}