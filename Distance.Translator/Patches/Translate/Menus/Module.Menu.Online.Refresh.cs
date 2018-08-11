using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class OnlineMenuRefresh : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Online Menu Refresh";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                string path = "OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/SubPanel/GameTable";
                GameObject GameTable = GameObject.Find(path);
                if (GameTable != null)
                {
                    foreach (GameObject Item in GameTable.GetChildren())
                    {
                        UILabel Status = GameObject.Find($@"{path}/{Item.name}/PrivateLabel").GetComponent<UILabel>();
                        GameStatus(ref Status);
                    }
                }
            }
        }

        private void GameStatus(ref UILabel label)
        {
            switch (label.text.ToUpperInvariant())
            {
                case "PUBLIC":
                    label.text = Language.MULTIPLAYER_ONLINE_STATUS_PUBLIC;
                    break;
                case "PRIVATE":
                    label.text = Language.MULTIPLAYER_ONLINE_STATUS_PRIVATE;
                    break;
            }
        }
    }
}