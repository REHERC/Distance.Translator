using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;

namespace Distance.Translator
{
    public static class IPCAntenna
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

        public static void SendLanguageAdd(string ipcIdentifier)
        {
            IPCData data = new IPCData(_ipcIdentifier);
            data["request"] = "language-build";
            _manager.SendIPC(ipcIdentifier, data);
        }
    }
}
