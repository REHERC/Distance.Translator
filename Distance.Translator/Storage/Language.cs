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

        public static string BUTTON_APPLY;
        public static string BUTTON_BACK;
        public static string BUTTON_YES;
        public static string BUTTON_NO;
        public static string BUTTON_OK;
        public static string BUTTON_CANCEL;
        public static string BUTTON_START;
        public static string BUTTON_DELETE;

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

        public static string ADVENTURE_PREVIEW;
        public static string ADVENTURE_PREVIEW_DESCRIPTION;

        public static string ARCADE_SPRINT;
        public static string ARCADE_SPRINT_DESCRIPTION;
        public static string ARCADE_CHALLENGE;
        public static string ARCADE_CHALLENGE_DESCRIPTION;
        public static string ARCADE_STUNT;
        public static string ARCADE_STUNT_DESCRIPTION;
        public static string ARCADE_TRACKMOGRIFY;
        public static string ARCADE_TRACKMOGRIFY_DESCRIPTION;

        public static string MULTIPLAYER_ONLINE;
        public static string MULTIPLAYER_SPLITSCREEN;

        public static string WORKSHOP_VISIT;
        public static string WORKSHOP_VISIT_DESCRIPTION;
        public static string WORKSHOP_DOWNLOAD;
        public static string WORKSHOP_DOWNLOAD_DESCRIPTION;
        public static string WORKSHOP_UPDATE;
        public static string WORKSHOP_UPDATE_DESCRIPTION;
        public static string WORKSHOP_UNSUBSCRIBE;
        public static string WORKSHOP_UNSUBSCRIBE_DESCRIPTION;

        public static string OPTIONS_AUDIO;
        public static string OPTIONS_GENERAL;
        public static string OPTIONS_CONTROLS;
        public static string OPTIONS_GRAPHICS;
        public static string OPTIONS_PROFILES;
        public static string OPTIONS_REPLAY;
        public static string OPTIONS_CHEATS;
    }

    public static partial class Language
    {
        public static void Initialize()
        {
            LANGUAGE_NAME = GetLine("language.name","language.name");
            LANGUAGE_AUTHOR = GetLine("language.author","language.author");

            BUTTON_BACK = GetLine("button.back", "Back");
            BUTTON_APPLY = GetLine("button.apply", "Apply");
            BUTTON_YES = GetLine("button.yes", "Yes");
            BUTTON_NO = GetLine("button.no", "No");
            BUTTON_OK = GetLine("button.ok", "Ok");
            BUTTON_CANCEL = GetLine("button.cancel", "Cancel");
            BUTTON_START = GetLine("button.start", "Start");
            BUTTON_DELETE = GetLine("button.delete", "Delete");

            MAINMENU_PRESSKEY = GetLine("mainmenu.presskey", "Press any button to start", true,1);

            MAINMENU_ADVENTURE = GetLine("mainmenu.adventure", "Adventure",true);
            MAINMENU_ARCADE = GetLine("mainmenu.arcade", "Arcade",true);
            MAINMENU_MULTIPLAYER = GetLine("mainmenu.multiplayer", "Multiplayer",true);
            MAINMENU_LEVELEDITOR = GetLine("mainmenu.leveleditor", "Level Editor",true);
            MAINMENU_WORKSHOP = GetLine("mainmenu.workshop", "Workshop",true);
            MAINMENU_GARAGE = GetLine("mainmenu.garage", "Garage",true);
            MAINMENU_BUGREPORT = GetLine("mainmenu.bugreport", "Bug Report",true);
            MAINMENU_OPTIONS = GetLine("mainmenu.options", "Options",true);
            MAINMENU_QUIT = GetLine("mainmenu.quit", "Quit", true);

            ADVENTURE_PREVIEW = GetLine("adventure.preview", "Preview");
            ADVENTURE_PREVIEW_DESCRIPTION = GetLine("adventure.preview.description", "Early version of Adventure mode. Final campaign coming when Distance exits Beta.");

            ARCADE_SPRINT = GetLine("arcade.sprint", "Sprint");
            ARCADE_SPRINT_DESCRIPTION = GetLine("arcade.sprint.description", "Survive the track and race to the end.");
            ARCADE_CHALLENGE = GetLine("arcade.challenge", "Challenge");
            ARCADE_CHALLENGE_DESCRIPTION = GetLine("arcade.challenge.description", "No resetting, no checkpoints. Only raw challenge on short tracks.");
            ARCADE_STUNT = GetLine("arcade.stunt", "Stunt");
            ARCADE_STUNT_DESCRIPTION = GetLine("arcade.stunt.description", "Perform crazy tricks and earn a high score to beat out the competition.");
            ARCADE_TRACKMOGRIFY = GetLine("arcade.trackmogrify", "Trackmogrify");
            ARCADE_TRACKMOGRIFY_DESCRIPTION = GetLine("arcade.trackmogrify.description", "Enter a phrase and randomly generate an entire level. How creative can you get?");

            MULTIPLAYER_ONLINE = GetLine("multiplayer.online", "Online");
            MULTIPLAYER_SPLITSCREEN = GetLine("multiplayer.splitscreen", "Split-Screen");

            WORKSHOP_VISIT = GetLine("workshop.visit", "Visit Workshop");
            WORKSHOP_VISIT_DESCRIPTION = GetLine("workshop.visit.description", "Discover new community-created content on Steam Workshop.");
            WORKSHOP_DOWNLOAD = GetLine("workshop.download", "Download New");
            WORKSHOP_DOWNLOAD_DESCRIPTION = GetLine("workshop.download.description", "Check for any newly subscribed levels.");
            WORKSHOP_UPDATE = GetLine("workshop.update", "Update All");
            WORKSHOP_UPDATE_DESCRIPTION = GetLine("workshop.update.description", "Check for updates to each one of your subscriptions.");
            WORKSHOP_UNSUBSCRIBE = GetLine("workshop.unsubscribe", "Unsubscribe All");
            WORKSHOP_UNSUBSCRIBE_DESCRIPTION = GetLine("workshop.unsubscribe.description", "Unsubscribe to all of your subscriptions.");

            OPTIONS_AUDIO = GetLine("options.audio", "Audio");
            OPTIONS_GENERAL = GetLine("options.general", "General");
            OPTIONS_CONTROLS = GetLine("options.controls", "Controls");
            OPTIONS_GRAPHICS = GetLine("options.graphics", "Graphics");
            OPTIONS_PROFILES = GetLine("options.profiles", "Profiles");
            OPTIONS_REPLAY = GetLine("options.replays", "Replay");
            OPTIONS_CHEATS = GetLine("options.cheats", "Cheats");
        }


        public static string GetLine(string Line,string Default, Boolean uppercase = false,int aestheticspaces = 0)
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
            if (aestheticspaces > 0)
            {
                string processedaesthetic = "";
                StringBuilder spaces = new StringBuilder();
                spaces.Append(' ',aestheticspaces);
                foreach (char chr in result)
                {
                    processedaesthetic += (string)(chr.ToString() + spaces);
                }
                while (processedaesthetic.EndsWith(" "))
                {
                    processedaesthetic = processedaesthetic.TrimEnd(' ');
                }
            }
            //CurrentPlugin.Log.Info("Loaded text for \"" + Line + "\" = \"" +  result + "\"");
            return result;
        }
    }
}
