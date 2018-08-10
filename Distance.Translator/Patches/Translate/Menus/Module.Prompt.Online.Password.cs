using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class OnlinePasswordPrompt : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Online Password Prompt";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("InputPromptPanel/Panel") != null)
                {
                    GameObject.Find("InputPromptPanel/Panel/Name").GetComponent<UILabel>().text = "###";
                   
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