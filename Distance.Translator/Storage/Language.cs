using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Configuration;

namespace Distance.Translator
{
    public static partial class Language
    {
        public static string LANGUAGE_NAME;
        public static string LANGUAGE_AUTHOR;

        public static string DIALOGS_YES;
        public static string DIALOGS_NO;
        public static string DIALOGS_OK;
        public static string DIALOGS_CANCEL;

        public static string MAINMENU_PRESSKEY;

        public static string MAINMENU_ADVENTURE;
        public static string MAINMENU_ARCADE;
        public static string MAINMENU_MULTIPLAYER;
        public static string MAINMENU_LEVELEDITOR;
        public static string MAINMENU_WORKSHOP;
        public static string MAINMENU_GARAGE;
        public static string MAINMENU_BUGREPORT;
        public static string MAINMENU_OPTIONS;
        public static string MAINMENU_QUIT;
    }

    public static partial class Language
    {
        public static void Initialize()
        {
            LANGUAGE_NAME = GetLine("language.name","language.name");
            LANGUAGE_AUTHOR = GetLine("language.author","language.author");
            
            DIALOGS_YES = GetLine("dialogs.yes", "Yes");
            DIALOGS_NO = GetLine("dialogs.no", "No");
            DIALOGS_OK = GetLine("dialogs.ok", "Ok");
            DIALOGS_CANCEL = GetLine("dialogs.cancel", "Cancel");

            MAINMENU_PRESSKEY = GetLine("mainmenu.presskey", "Press any button to start", true);

            MAINMENU_ADVENTURE = GetLine("mainmenu.adventure", "Adventure",true);
            MAINMENU_ARCADE = GetLine("mainmenu.arcade", "Arcade",true);
            MAINMENU_MULTIPLAYER = GetLine("mainmenu.multiplayer", "Multiplayer",true);
            MAINMENU_LEVELEDITOR = GetLine("mainmenu.leveleditor", "Level Editor",true);
            MAINMENU_WORKSHOP = GetLine("mainmenu.workshop", "Workshop",true);
            MAINMENU_GARAGE = GetLine("mainmenu.garage", "Garage",true);
            MAINMENU_BUGREPORT = GetLine("mainmenu.bugreport", "Bug Report",true);
            MAINMENU_OPTIONS = GetLine("mainmenu.options", "Options",true);
            MAINMENU_QUIT = GetLine("mainmenu.quit", "Quit",true);
        }

        public static string GetLine(string Line,string Default, Boolean uppercase = false)
        {
            string result = "";
            try
            {
                result = CurrentPlugin.Lang.GetItem<string>(Line);
            }
            catch (Exception VirusSpirit)
            {
                CurrentPlugin.Log.Exception(VirusSpirit);
                CurrentPlugin.Log.Error("Impossible to find the translation key for \"" + Line + "\" in \"" + CurrentPlugin.Config.GetItem<String>("LanguageFile") + ".json\"");
                result = Default;
            }
            if ((result == "") || (result == null) || (result == string.Empty)) {
                result = Default;
            }
            if (uppercase) result = result.ToUpper();
            CurrentPlugin.Log.Info("Loaded text for \"" + Line + "\"");
            return result;
        }
    }
}
