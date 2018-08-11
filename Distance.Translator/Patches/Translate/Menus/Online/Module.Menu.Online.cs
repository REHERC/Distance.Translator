using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    class OnlineMenu : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Online Menu";

        public void Run()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
            {
                if (GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser") != null)
                {
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Top Left/Container/UILabel - Mode Name").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_TITLE;
                    
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/FindAGame").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_FINDGAME;

                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/Server name").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_SERVERNAME;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/Mode").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_MODE;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/Players").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_PLAYERS;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/Ping").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_PING;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/Status").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_STATUS;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/Build").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_BUILD;
                    
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/RefreshButton/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_REFRESH;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/HideFullServersToggle/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_SERVERS_HIDEFULL;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/HidePrivateServersToggle/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_SERVERS_HIDEPRIVATE;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/ServerBrowser/HideIncompatibleServersToggle/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_SERVERS_HIDEINCOMPATIBLE;

                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/Host Game Group/UILabel - Host Your Own Game").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_HOSTGAME;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/Host Game Group/StartServerButton/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_NEWGAME;
                    
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/Direct IP Panel/Direct IP Group/Title").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_JOINGAME;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/Direct IP Panel/Direct IP Group/IPAddressInput/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_IPADDRESS;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/Direct IP Panel/Direct IP Group/PortInput/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_PORT;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/Direct IP Panel/Direct IP Group/PasswordInput/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_PASSWORD;
                    GameObject.Find("OnlineMPFrontRoot/UI Root/Panel - OnlineMPFront/Panel - ServerBrowser/Anchor - Center/Direct IP Panel/Direct IP Group/ConnectButton/NameLabel").GetComponent<UILabel>().text = Language.MULTIPLAYER_ONLINE_CONNECT;

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