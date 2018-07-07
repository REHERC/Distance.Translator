using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;

namespace Distance.Translator.OptionsMenu
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
    }

    public static partial class IPCAntenna
    {
        public static void RecieveData(IPCData data)
        {
            if (data.ContainsKey("request"))
            {
                switch (data["request"].ToString())
                {
                    case "translate":
                        switch (data["key"].ToString())
                        {
                            case "header.description":
                                Language.HEADER_DESCRIPTION = data["value"].ToString();
                                break;
                            case "plugin.menu.name":
                                Language.PLUGIN_MENU_NAME = data["value"].ToString();
                                break;
                            case "plugin.menu.title":
                                Language.PLUGIN_MENU_TITLE = data["value"].ToString();
                                break;
                            case "plugin.menu.language":
                                Language.PLUGIN_MENU_LANGUAGE = data["value"].ToString().TrimEnd(':');
                                break;
                            case "plugin.menu.language.description":
                                Language.PLUGIN_MENU_LANGUAGE_DESCRIPTION = data["value"].ToString();
                                break;
                            case "plugin.menu.rainbowmode":
                                Language.PLUGIN_MENU_RAINBOWMODE = data["value"].ToString().TrimEnd(':');
                                break;
                            case "plugin.menu.rainbowmode.description":
                                Language.PLUGIN_MENU_RAINBOWMODE_DESCRIPTION = data["value"].ToString();
                                break;
                        }
                        break;
                    case "setting":


                        break;
                    case "language-add":

                        break;
                    case "ipc-end":

                        break;
                }
            }
        }
    }
}
