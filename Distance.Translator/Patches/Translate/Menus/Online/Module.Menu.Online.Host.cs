using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class OnlineHostMenu : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Online Host Menu";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game") != null)
                {
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Top Left/Container/UILabel - Mode Name").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_TITLE;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Host a Game/ServerNameInput/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_SERVERNAME;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Host a Game/ServerNameInput").GetComponent<UIExInput>().defaultText = Language.MULTIPLAYER_ONLINE_HOST_SERVERNAME_HINT;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Host a Game/MaxPlayersInput/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_MAXPLAYERS;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Host a Game/MaxPlayersNote").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_MAXPLAYERS_NOTE;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Host a Game/PrivateToggle/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_PRIVATE;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Host a Game/PrivateToggleNote").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_PRIVATE_NOTE;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Host a Game/PasswordInput/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_PASSWORD;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Host a Game/StartServerButton/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_START;

                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - Host A Game/Anchor - Center/UI Panel - Tips/HostAGameInfo").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOST_INFO;
                }
            }
            else
            {
                CanRun = false;
            }
        }
    }
}