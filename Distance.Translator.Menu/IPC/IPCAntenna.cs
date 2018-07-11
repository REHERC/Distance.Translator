using System;
using System.Collections.Generic;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;

namespace Distance.Translator.Menu
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

        public static void SendAwake(string ipcIdentifier)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "awake";
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

        public static void SendCommand(string ipcIdentifier, string Command)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "command";
            data["command"] = Command;
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
                        SharedSettings.MAINPLUGIN_DETECTED = true;
                        break;
                    case "translate":
                        switch (data["key"].ToString())
                        {
                            case "header.description":
                                LanguageKeys.HEADER_DESCRIPTION = (string)data["value"].ToString();
                                break;
                            case "plugin.menu.name":
                                LanguageKeys.PLUGIN_MENU_NAME = (string)data["value"].ToString();
                                break;
                            case "plugin.menu.title":
                                LanguageKeys.PLUGIN_MENU_TITLE = (string)data["value"].ToString();
                                break;
                            case "plugin.menu.language":
                                LanguageKeys.PLUGIN_MENU_LANGUAGE = (string)data["value"].ToString().TrimEnd(':');
                                break;
                            case "plugin.menu.language.description":
                                LanguageKeys.PLUGIN_MENU_LANGUAGE_DESCRIPTION = (string)data["value"].ToString();
                                break;
                            case "plugin.menu.rainbowmode":
                                LanguageKeys.PLUGIN_MENU_RAINBOWMODE = (string)data["value"].ToString().TrimEnd(':');
                                break;
                            case "plugin.menu.rainbowmode.description":
                                LanguageKeys.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION = (string)data["value"].ToString();
                                break;
                        }
                        break;
                    case "setting":
                        switch (data["setting"].ToString())
                        {
                            case "config.rainbow":
                                SharedSettings.RAINBOW_MODE = (bool)data["value"];
                                break;
                        }
                        break;
                    case "language":
                        string lang_name = (string)data["name"].ToString();
                        string lang_author = (string)data["author"].ToString();
                        string lang_file = (string)data["file"].ToString();
                        bool lang_current = (bool)data["current"];
                        LanguageManager.Languages.Add(new KeyValuePair<string, string>($"{lang_name} [AADC98]({lang_author})[-]", lang_file));
                        if (lang_current) { SharedSettings.CURRENT_LANGUAGE = lang_file; }
                        break;
                }
            }
        }
    }
}