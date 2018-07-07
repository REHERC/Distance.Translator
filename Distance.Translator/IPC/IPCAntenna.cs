using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;

namespace Distance.Translator
{
    public static partial class IPCAntenna
    {
        private static string _ipcIdentifier;
        private static IManager _manager;
        public static void initialize(IManager manager, string ipcIdentifier)
        {
            _manager = manager;
            _ipcIdentifier = ipcIdentifier;
        }
        
        public static void SendTranslation(string ipcIdentifier,string key,string value)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "translate";
            data["key"] = key;
            data["value"] = value;
            _manager.SendIPC(ipcIdentifier, data);
        }

        public static void SendLanguageAdd(string ipcIdentifier, string LanguageName, string Author)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "language-add";
            data["languagename"] = LanguageName;
            data["author"] = Author;
            _manager.SendIPC(ipcIdentifier, data);
        }

        public static void SendSetting(string ipcIdentifier, string Setting, object Value)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "setting";
            data["setting"] = Setting;
            data["value"] = Value;
            _manager.SendIPC(ipcIdentifier, data);
        }

        public static void SendIPCEnd(string ipcIdentifier)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "ipc-end";
            _manager.SendIPC(ipcIdentifier, data);
        }
    }
    
    public static partial class IPCAntenna
    {
        public static void RecieveData(IPCData data)
        {
            if (data.ContainsKey("request"))
            {
                switch (data["request"].ToString())
                {
                    case "awake":
                        if (data.SourceIdentifier == "DistanceTranslatorOptionsMenu") {
                            SendTranslation("DistanceTranslatorOptionsMenu", "header.description", Language.HEADER_DESCRIPTION);
                            
                            SendTranslation("DistanceTranslatorOptionsMenu", "plugin.menu.name", Language.PLUGIN_MENU_NAME);
                            SendTranslation("DistanceTranslatorOptionsMenu", "plugin.menu.title", Language.PLUGIN_MENU_TITLE);
                            SendTranslation("DistanceTranslatorOptionsMenu", "plugin.menu.language", Language.PLUGIN_MENU_LANGUAGE);
                            SendTranslation("DistanceTranslatorOptionsMenu", "plugin.menu.language.description", Language.PLUGIN_MENU_LANGUAGE_DESCRIPTION);
                            SendTranslation("DistanceTranslatorOptionsMenu", "plugin.menu.rainbowmode", Language.PLUGIN_MENU_RAINBOWMODE);
                            SendTranslation("DistanceTranslatorOptionsMenu", "plugin.menu.rainbowmode.description", Language.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);

                            SendSetting("DistanceTranslatorOptionsMenu","", CurrentPlugin.Config.GetItem<string>("LanguageFile"));

                            LanguageManager.DetectLanguages();
                            LanguageManager.SendLanguages();
                        }
                        break;
                }
            }
        }
    }
}
