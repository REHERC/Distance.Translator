﻿using System;
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
        public static string MAINMENU_GAMETITLEIDLE;

        public static string MENUBUTTON_ADVENTURE;
        public static string MENUBUTTON_ARCADE;
        public static string MENUBUTTON_MULTIPLAYER;
        public static string MENUBUTTON_LEVELEDITOR;
        public static string MENUBUTTON_WORKSHOP;
        public static string MENUBUTTON_GARAGE;
        public static string MENUBUTTON_BUGREPORT;
        public static string MENUBUTTON_OPTIONS;
        public static string MENUBUTTON_QUIT;
        public static string MENUBUTTON_GOMENU;
        public static string MENUBUTTON_GOEDITOR;
        public static string MENUBUTTON_GOLOBBY;
        public static string MENUBUTTON_NEXTLEVEL;
        public static string MENUBUTTON_RESTART;
        public static string MENUBUTTON_RESUME;
        public static string MENUBUTTON_SPECTATE;

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

        public static string TRICK_FREESTYLE;
        public static string TRICK_BARRELROLL;
        public static string TRICK_FRONTFLIP;
        public static string TRICK_BACKFLIP;
        public static string TRICK_FRISBEE;
        public static string TRICK_FRONTTWIST;
        public static string TRICK_BACKTWIST;
        public static string TRICK_WALLRIDE;
        public static string TRICK_CEILINGRIDE;
        public static string TRICK_GRIND;
        public static string TRICK_WHEELIE;
        public static string TRICK_SIDEWHEELIE;
        public static string TRICK_NOSESTAND;

        public static string OPTIONS_AUDIO_TITLE;
        public static string OPTIONS_AUDIO_MASTER;
        public static string OPTIONS_AUDIO_CAR;
        public static string OPTIONS_AUDIO_ENVIRONMENT;
        public static string OPTIONS_AUDIO_OBSTACLES;
        public static string OPTIONS_AUDIO_MENUS;
        public static string OPTIONS_AUDIO_ANNOUNCER;
        public static string OPTIONS_AUDIO_MUSIC;
        public static string OPTIONS_AUDIO_ANNOUNCERSETTINGS;
        public static string OPTIONS_AUDIO_ANNOUNCERSETTINGS_ALLMODES;
        public static string OPTIONS_AUDIO_ANNOUNCERSETTINGS_ARCADEONLY;
        public static string OPTIONS_AUDIO_ANNOUNCERSETTINGS_STUNTONLY;
        public static string OPTIONS_AUDIO_ANNOUNCERSETTINGS_DISABLED;
        public static string OPTIONS_AUDIO_CUSTOMMUSIC;
        public static string OPTIONS_AUDIO_CUSTOMMUSIC_FOLDER;
        public static string OPTIONS_AUDIO_CUSTOMMUSIC_TRACK;
        public static string OPTIONS_AUDIO_CUSTOMMUSIC_SHUFFLETRACKS;
        public static string OPTIONS_AUDIO_CUSTOMMUSIC_LOOPTRACKS;
    }

    public static partial class Language
    {
        public static void Initialize()
        {
            LANGUAGE_NAME = GetLine("language.name","Default");
            LANGUAGE_AUTHOR = GetLine("language.author","Refract");



            BUTTON_BACK = GetLine("button.back", "Back");
            BUTTON_APPLY = GetLine("button.apply", "Apply");
            BUTTON_YES = GetLine("button.yes", "Yes");
            BUTTON_NO = GetLine("button.no", "No");
            BUTTON_OK = GetLine("button.ok", "Ok");
            BUTTON_CANCEL = GetLine("button.cancel", "Cancel");
            BUTTON_START = GetLine("button.start", "Start");
            BUTTON_DELETE = GetLine("button.delete", "Delete");

            MAINMENU_PRESSKEY = GetLine("mainmenu.presskey", "Press any button to start", true,1);
            MAINMENU_GAMETITLEIDLE = GetLine("mainmenu.gametitleidle", "DISTANCE", true, 2);

            MENUBUTTON_ADVENTURE = GetLine("menubutton.adventure", "Adventure",true);
            MENUBUTTON_ARCADE = GetLine("menubutton.arcade", "Arcade",true);
            MENUBUTTON_MULTIPLAYER = GetLine("menubutton.multiplayer", "Multiplayer",true);
            MENUBUTTON_LEVELEDITOR = GetLine("menubutton.leveleditor", "Level Editor",true);
            MENUBUTTON_WORKSHOP = GetLine("menubutton.workshop", "Workshop",true);
            MENUBUTTON_GARAGE = GetLine("menubutton.garage", "Garage",true);
            MENUBUTTON_BUGREPORT = GetLine("menubutton.bugreport", "Bug Report",true);
            MENUBUTTON_OPTIONS = GetLine("menubutton.options", "Options",true);
            MENUBUTTON_QUIT = GetLine("menubutton.quit", "Quit", true);
            MENUBUTTON_GOMENU = GetLine("menubutton.gomenu", "Main Menu", true);
            MENUBUTTON_GOEDITOR = GetLine("menubutton.goeditor", "Back To Editor", true);
            MENUBUTTON_RESTART = GetLine("menubutton.restart", "Restart", true);
            MENUBUTTON_RESUME = GetLine("menubutton.resume", "Resume", true);
            MENUBUTTON_GOMENU = GetLine("menubutton.gomenu", "Main Menu", true);
            MENUBUTTON_GOEDITOR = GetLine("menubutton.goeditor", "Back To Editor", true);
            MENUBUTTON_GOLOBBY = GetLine("menubutton.golobby", "Back To Lobby", true);
            MENUBUTTON_NEXTLEVEL = GetLine("menubutton.nextlevel", "Next Level", true);
            MENUBUTTON_SPECTATE = GetLine("menubutton.spectate", "Spectate", true);


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
            
            TRICK_FREESTYLE = GetLine("trick.freestyle", "Freestyle");
            TRICK_BARRELROLL = GetLine("trick.barrelroll", "Barrel Roll");
            TRICK_FRONTFLIP = GetLine("trick.frontflip", "Front Flip");
            TRICK_BACKFLIP = GetLine("trick.backflip", "Back Flip");
            TRICK_FRISBEE = GetLine("trick.frisbee", "Frisbee");
            TRICK_FRONTTWIST = GetLine("trick.fronttwist", "Front Twist");
            TRICK_BACKTWIST = GetLine("trick.backtwist", "Back Twist");
            TRICK_WALLRIDE = GetLine("trick.wallride", "Wall Ride");
            TRICK_CEILINGRIDE = GetLine("trick.ceilingride", "Ceiling Ride");
            TRICK_GRIND = GetLine("trick.grind", "Grind");
            TRICK_WHEELIE = GetLine("trick.wheelie", "Wheelie");
            TRICK_SIDEWHEELIE = GetLine("trick.sidewheelie", "Side Wheelie");
            TRICK_NOSESTAND = GetLine("trick.nosestand", "Nose Stand");

            OPTIONS_AUDIO_TITLE = GetLine("options.audio.title", "Audio Options", true);
            OPTIONS_AUDIO_MASTER = GetLine("options.audio.master", "Master:", true);
            OPTIONS_AUDIO_CAR = GetLine("options.audio.car", "Car:", true);
            OPTIONS_AUDIO_ENVIRONMENT = GetLine("options.audio.environment", "Environment:", true);
            OPTIONS_AUDIO_OBSTACLES = GetLine("options.audio.obstacles", "Obstacles:", true);
            OPTIONS_AUDIO_MENUS = GetLine("options.audio.menus", "Menus:", true);
            OPTIONS_AUDIO_ANNOUNCER = GetLine("options.audio.announcer", "Announcer:", true);
            OPTIONS_AUDIO_MUSIC = GetLine("options.audio.music", "Music:", true);
            OPTIONS_AUDIO_ANNOUNCERSETTINGS = GetLine("options.audio.announcersettings", "Announcer Settings:", true);
            OPTIONS_AUDIO_ANNOUNCERSETTINGS_ALLMODES = GetLine("options.audio.announcersettings.allmodes", "All Modes");
            OPTIONS_AUDIO_ANNOUNCERSETTINGS_ARCADEONLY = GetLine("options.audio.announcersettings.arcadeonly", "Arcade Only");
            OPTIONS_AUDIO_ANNOUNCERSETTINGS_STUNTONLY = GetLine("options.audio.announcersettings.stuntonly", "Stunt Only");
            OPTIONS_AUDIO_ANNOUNCERSETTINGS_DISABLED = GetLine("options.audio.announcersettings.disabled", "Disabled");
            OPTIONS_AUDIO_CUSTOMMUSIC = GetLine("options.audio.custommusic", "Enable Custom Music:", true);
            OPTIONS_AUDIO_CUSTOMMUSIC_FOLDER = GetLine("options.audio.custommusic.folder", "Set Music Folder:", true);
            OPTIONS_AUDIO_CUSTOMMUSIC_TRACK = GetLine("options.audio.custommusic.track", "Select A Track:", true);
            OPTIONS_AUDIO_CUSTOMMUSIC_SHUFFLETRACKS = GetLine("options.audio.custommusic.shuffletracks", "Shuffle Tracks", true);
            OPTIONS_AUDIO_CUSTOMMUSIC_LOOPTRACKS = GetLine("options.audio.custommusic.looptracks", "Loop Tracks:", true);
        }

        public static List<string> Rainbow = new List<String>(){
            "F70001",
            "FEA700",
            "FFFF00",
            "008100",
            "0000FE",
            "840083"
        };

        public static string GetLine(String Line,String Default, bool uppercase = false,int aestheticspaces = 0,bool rainbow = false)
        {
            string result = "";
            try
            {
                result = CurrentPlugin.Lang.GetItem<string>(Line);
            }
            catch (Exception VirusSpirit)
            {
                if (!(Line == "nothing")) {
                    CurrentPlugin.Log.Exception(VirusSpirit);
                    CurrentPlugin.Log.Error("Impossible to find the translation key for \"" + Line + "\" in \"" + CurrentPlugin.Config.GetItem<String>("LanguageFile") + ".json\"");
                }
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
                result = processedaesthetic;
            }
            if (rainbow || (bool)CurrentPlugin.Config.GetItem<bool>("Rainbow"))
            {
                int index = 0;
                string rainbowresult = result;
                foreach (char chr in result)
                {
                    if (!(chr == ' '))
                    {
                        rainbowresult = rainbowresult + "[" + Rainbow[index] + "]" + chr + "[-]";
                        index++;
                        if (index > Rainbow.Count - 1)
                        {
                            index = 0;
                        }
                    }
                    else
                    {
                        rainbowresult = rainbowresult + " ";
                    }
                }
                result = rainbowresult;
            }
            if (CurrentPlugin.Config.GetItem<bool>("Dump"))
            {
                CurrentPlugin.LangDump[Line] = Default;
            }
            //CurrentPlugin.Log.Info("Loaded text for \"" + Line + "\" = \"" +  result + "\"");
            return result;
        }
    }
}
