using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;

namespace Options.Menu
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
                                LanguageKeys.HEADER_DESCRIPTION = (string)data["value"];
                                break;
                            case "plugin.menu.name":
                                LanguageKeys.PLUGIN_MENU_NAME = (string)data["value"];
                                break;
                            case "plugin.menu.title":
                                LanguageKeys.PLUGIN_MENU_TITLE = (string)data["value"];
                                break;
                            case "plugin.menu.language":
                                LanguageKeys.PLUGIN_MENU_LANGUAGE = (string)data["value"].ToString().TrimEnd(':');
                                break;
                            case "plugin.menu.language.description":
                                LanguageKeys.PLUGIN_MENU_LANGUAGE_DESCRIPTION = (string)data["value"];
                                break;
                            case "plugin.menu.rainbowmode":
                                LanguageKeys.PLUGIN_MENU_RAINBOWMODE = (string)data["value"].ToString().TrimEnd(':');
                                break;
                            case "plugin.menu.rainbowmode.description":
                                LanguageKeys.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION = (string)data["value"];
                                break;
                        }
                        break;
                    case "setting":
                        switch (data["setting"].ToString())
                        {
                            case "config.language":
                                SharedSettings.SELECTED_LANGUAGE = (string)data["value"];
                                LanguageInfo current_lang = new LanguageInfo("English (default)", "Refract Studios", ":default:");
                                foreach (LanguageInfo lang in LanguageManager.Languages.Values)
                                {
                                    if (lang.File == (string)data["value"])
                                    {
                                        current_lang = lang;
                                        break;
                                    }
                                }
                                SharedSettings.CURRENT_LANGUAGE = current_lang;
                                break;
                            case "config.rainbow":
                                SharedSettings.RAINBOW_MODE = (bool)data["value"];
                                break;
                        }
                        break;
                    case "language-add":
                        string lang_name = (string)data["name"].ToString();
                        string lang_author = (string)data["author"].ToString();
                        string lang_file = (string)data["file"].ToString();
                        LanguageManager.Languages.Add("[00DDFF]" + lang_name + "[-] - [FF9000]" + lang_author + "[-]", new LanguageInfo(lang_name,lang_author,lang_file));
                        break;
                }
            }
        }
    }
}