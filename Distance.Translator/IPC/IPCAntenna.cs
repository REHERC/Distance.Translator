using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;

namespace Distance.Translator
{
    public static partial class IPCAntenna
    {
        public const string OPTIONS_MENU_IPC = "DistanceTranslatorMenu";

        private static string _ipcIdentifier;
        private static IManager _manager;
        public static void initialize(IManager manager, string ipcIdentifier)
        {
            _manager = manager;
            _ipcIdentifier = ipcIdentifier;
        }

        public static void SendAwake(string ipcIdentifier)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "awake";
            _manager.SendIPC(ipcIdentifier, data);
        }

        public static void SendTranslation(string ipcIdentifier,string key,string value)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "translate";
            data["key"] = key;
            data["value"] = value;
            _manager.SendIPC(ipcIdentifier, data);
        }

        public static void SendLanguage(string ipcIdentifier, string Name, string Author, string File,bool Current)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "language";
            data["name"] = Name;
            data["author"] = Author;
            data["file"] = File;
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
    }
    
    public static partial class IPCAntenna
    {
        public static void RecieveData(IPCData data)
        {
            if (data.ContainsKey("request"))
            {
                switch (data["request"].ToString())
                {
                    case "setting":
                        switch (data["setting"].ToString())
                        {
                            case "config.language":
                                CurrentPlugin.Config["LanguageFile"] = (string)data["value"].ToString();
                                CurrentPlugin.Config.Save();
                                break;
                            case "config.rainbow":
                                CurrentPlugin.Config["Rainbow"] = (bool)data["value"];
                                CurrentPlugin.Config.Save();
                                break;
                        }
                        break;
                    case "awake":
                        if (data.SourceIdentifier == OPTIONS_MENU_IPC) {
                            SharedSettings.MENUPLUGIN_DETECTED = true;

                            SendAwake(OPTIONS_MENU_IPC);

                            SendTranslation(OPTIONS_MENU_IPC, "header.description", Language.HEADER_DESCRIPTION);
                            
                            SendTranslation(OPTIONS_MENU_IPC, "plugin.menu.name", Language.PLUGIN_MENU_NAME);
                            SendTranslation(OPTIONS_MENU_IPC, "plugin.menu.title", Language.PLUGIN_MENU_TITLE);
                            SendTranslation(OPTIONS_MENU_IPC, "plugin.menu.language", Language.PLUGIN_MENU_LANGUAGE);
                            SendTranslation(OPTIONS_MENU_IPC, "plugin.menu.language.description", Language.PLUGIN_MENU_LANGUAGE_DESCRIPTION);
                            SendTranslation(OPTIONS_MENU_IPC, "plugin.menu.rainbowmode", Language.PLUGIN_MENU_RAINBOWMODE);
                            SendTranslation(OPTIONS_MENU_IPC, "plugin.menu.rainbowmode.description", Language.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION);
                            
                            LanguageManager.DetectLanguages();
                            LanguageManager.SendLanguages();

                            SendSetting(OPTIONS_MENU_IPC, "config.rainbow", CurrentPlugin.Config.GetItem<bool>("Rainbow"));
                        }
                        break;
                }
            }
        }
    }
}
