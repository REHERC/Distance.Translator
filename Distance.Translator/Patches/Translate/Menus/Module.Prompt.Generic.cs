using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class InputPrompt : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Input Prompt";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("InputPromptPanel/Panel") != null)
                {
                    UILabel label = GameObject.Find("InputPromptPanel/Panel/Name").GetComponent<UILabel>();
                    switch (label.text.ToUpperInvariant())
                    {
                        case "PASSWORD:":
                            label.text = "p";
                            break;
                        case "NEW SCHEME NAME:":
                            label.text = "nsm";
                            break;
                    }
                }
            }
        }
    }
}