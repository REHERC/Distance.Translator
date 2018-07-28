using System;
using System.Collections.Generic;
using System.Text;
using Spectrum.API.Configuration;
using UnityEngine.SceneManagement;

namespace Distance.Translator
{
    public static partial class Language
    {
        public static string LANGUAGE_NAME;
        public static string LANGUAGE_AUTHOR;

        public static string PLUGIN_MENU_NAME;
        public static string PLUGIN_MENU_TITLE;
        public static string PLUGIN_MENU_LANGUAGE;
        public static string PLUGIN_MENU_LANGUAGE_DESCRIPTION;
        public static string PLUGIN_MENU_LANGUAGE_UPDATE;
        public static string PLUGIN_MENU_LANGUAGE_UPDATE_DESCRIPTION;
        public static string PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_TITLE;
        public static string PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_MESSAGE;
        public static string PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_UNAVAILABLE_TITLE;
        public static string PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_UNAVAILABLE_MESSAGE;
        public static string PLUGIN_MENU_RAINBOWMODE;
        public static string PLUGIN_MENU_RAINBOWMODE_DESCRIPTION;

        public static string BUTTON_APPLY;
        public static string BUTTON_BACK;
        public static string BUTTON_YES;
        public static string BUTTON_NO;
        public static string BUTTON_OK;
        public static string BUTTON_CANCEL;
        public static string BUTTON_START;
        public static string BUTTON_DELETE;

        public static string HEADER_DESCRIPTION;

        public static string MAINMENU_PRESSKEY;

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
        public static string OPTIONS_VR;
        public static string OPTIONS_EXPERIMENTAL;

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

        public static string OPTIONS_GENERAL_TITLE;
        public static string OPTIONS_GENERAL_UNITS;
        public static string OPTIONS_GENERAL_UNITS_METRIC;
        public static string OPTIONS_GENERAL_UNITS_IMPERIAL;
        public static string OPTIONS_GENERAL_ALLABILITIES;
        public static string OPTIONS_GENERAL_RATINGPRIVACY;
        public static string OPTIONS_GENERAL_AUTODOWNLOAD;
        public static string OPTIONS_GENERAL_MENUANIMATIONS;
        public static string OPTIONS_GENERAL_BOOMBOX;
        public static string OPTIONS_GENERAL_BOOMBOX_BLOOM;
        public static string OPTIONS_GENERAL_BOOMBOX_SHAKE;
        public static string OPTIONS_GENERAL_VISUALIZER;
        public static string OPTIONS_GENERAL_VISUALIZER_OFF;
        public static string OPTIONS_GENERAL_VISUALIZER_CIRCLE;
        public static string OPTIONS_GENERAL_VISUALIZER_BARS;
        public static string OPTIONS_GENERAL_SHUFFLELEVELS;
        public static string OPTIONS_GENERAL_SHOWTRICKTEXT;

        public static string OPTIONS_CONTROLS_TITLE;
        public static string OPTIONS_CONTROLS_SUBTITLE;
        public static string OPTIONS_CONTROLS_DEVICE;
        public static string OPTIONS_CONTROLS_SCHEME;
        public static string OPTIONS_CONTROLS_SCHEME_SELECTED;
        public static string OPTIONS_CONTROLS_SCHEME_EDIT;
        public static string OPTIONS_CONTROLS_SCHEME_DELETE;
        public static string OPTIONS_CONTROLS_SCHEME_DUPLICATE;
        public static string OPTIONS_CONTROLS_SCHEME_RENAME;
        public static string OPTIONS_CONTROLS_INVERTY;
        public static string OPTIONS_CONTROLS_SELFRIGHTING;
        public static string OPTIONS_CONTROLS_LANDINGASSIST;
        public static string OPTIONS_CONTROLS_RUMBLEINTENSITY;
        public static string OPTIONS_CONTROLS_STEERINGSENSITIVITY;
        public static string OPTIONS_CONTROLS_FLIGHTSENSITIVITY;
        public static string OPTIONS_CONTROLS_INPUTSMOOTHING;
        public static string OPTIONS_CONTROLS_TAB_BASIC;
        public static string OPTIONS_CONTROLS_TAB_FLIGHT;
        public static string OPTIONS_CONTROLS_TAB_CAMERA;
        public static string OPTIONS_CONTROLS_TAB_MENU;

        public static string OPTIONS_CONTROLS_VIEWING;
        public static string OPTIONS_CONTROLS_EDITING;
        public static string OPTIONS_CONTROLS_HELPTEXT;

        public static string CONTROLS_NOTSET;

        public static string CONTROLS_BASIC_GAS;
        public static string CONTROLS_BASIC_BRAKE;
        public static string CONTROLS_BASIC_STEER_LEFT;
        public static string CONTROLS_BASIC_STEER_RIGHT;
        public static string CONTROLS_BASIC_BOOST;
        public static string CONTROLS_BASIC_JUMP;
        public static string CONTROLS_BASIC_WINGS;
        public static string CONTROLS_BASIC_GRIP;
        public static string CONTROLS_BASIC_SPECIAL;
        public static string CONTROLS_BASIC_RESET;
        public static string CONTROLS_BASIC_PAUSE;
        public static string CONTROLS_BASIC_HORN;
        public static string CONTROLS_BASIC_SHOWSCORE;
        public static string CONTROLS_BASIC_CHAT;

        public static string CONTROLS_FLIGHT_AIRROLL_LEFT;
        public static string CONTROLS_FLIGHT_AIRROLL_RIGHT;
        public static string CONTROLS_FLIGHT_AIRPITCH_DOWN;
        public static string CONTROLS_FLIGHT_AIRPITCH_UP;
        public static string CONTROLS_FLIGHT_WINGYAW_LEFT;
        public static string CONTROLS_FLIGHT_WINGYAW_RIGHT;
        public static string CONTROLS_FLIGHT_WINGPITCH_DOWN;
        public static string CONTROLS_FLIGHT_WINGPITCH_UP;
        public static string CONTROLS_FLIGHT_JETROLL_LEFT;
        public static string CONTROLS_FLIGHT_JETROLL_RIGHT;
        public static string CONTROLS_FLIGHT_JETPITCH_DOWN;
        public static string CONTROLS_FLIGHT_JETPITCH_UP;
        public static string CONTROLS_FLIGHT_WINGROLL_LEFT;
        public static string CONTROLS_FLIGHT_WINGROLL_RIGHT;

        public static string CONTROLS_CAMERA_CENTER;
        public static string CONTROLS_CAMERA_LOOKBEHIND;
        public static string CONTROLS_CAMERA_YAW_LEFT;
        public static string CONTROLS_CAMERA_YAW_RIGHT;
        public static string CONTROLS_CAMERA_PITCH_DOWN;
        public static string CONTROLS_CAMERA_PITCH_UP;
        public static string CONTROLS_CAMERA_CHANGEVIEW;
        public static string CONTROLS_CAMERA_NEXTPLAYER;

        public static string CONTROLS_MENU_CONFIRM;
        public static string CONTROLS_MENU_CANCEL;
        public static string CONTROLS_MENU_LEFT;
        public static string CONTROLS_MENU_RIGHT;
        public static string CONTROLS_MENU_DOWN;
        public static string CONTROLS_MENU_UP;
        public static string CONTROLS_MENU_START;
        public static string CONTROLS_MENU_PAGE_LEFT;
        public static string CONTROLS_MENU_PAGE_RIGHT;
        public static string CONTROLS_MENU_PAGE_DOWN;
        public static string CONTROLS_MENU_PAGE_UP;
        public static string CONTROLS_MENU_DELETE;
        public static string CONTROLS_MENU_CREATEPLAYLIST;
        public static string CONTROLS_MENU_RATELEVEL;
        public static string CONTROLS_MENU_SORTING;
        public static string CONTROLS_MENU_TOGGLEVISIBILITY;

        public static string OPTIONS_PROFILES_TITLE;
        public static string OPTIONS_PROFILES_ADD;
        public static string OPTIONS_PROFILES_RENAME;
        public static string OPTIONS_PROFILES_DELETE;
        public static string OPTIONS_PROFILES_SELECT;
        public static string OPTIONS_PROFILES_CREATE;
        public static string OPTIONS_PROFILES_ENTERNAME;
        public static string OPTIONS_PROFILES_EDIT;
        public static string OPTIONS_PROFILES_SELECTED;

        public static string OPTIONS_REPLAYS_TITLE;
        public static string OPTIONS_REPLAYS_TYPE;
        public static string OPTIONS_REPLAYS_TYPE_DISABLED;
        public static string OPTIONS_REPLAYS_TYPE_LOCAL;
        public static string OPTIONS_REPLAYS_TYPE_FRIENDS;
        public static string OPTIONS_REPLAYS_TYPE_NEARMYRANKING;
        public static string OPTIONS_REPLAYS_TYPE_GLOBALBEST;
        public static string OPTIONS_REPLAYS_COUNT;
        public static string OPTIONS_REPLAYS_BRIGHTNESS;
        public static string OPTIONS_REPLAYS_NAMESVISIBLE;
        public static string OPTIONS_REPLAYS_PLAYBACKSPEED;
    }

    public static partial class Language
    {
        public static void Initialize()
        {
            SharedSettings.CURRENT_LANGUAGE_FILE = CurrentPlugin.Config.GetItem<String>("LanguageFile");
            CurrentPlugin.Lang = new Settings($@"Languages\{SharedSettings.CURRENT_LANGUAGE_FILE}");


            LANGUAGE_NAME = GetLine("language.name","English");
            LANGUAGE_AUTHOR = GetLine("language.author", "Refract Studios");

            PLUGIN_MENU_NAME = GetLine("plugin.menu.name", "Language");
            PLUGIN_MENU_TITLE = GetLine("plugin.menu.title", "Language Settings");
            PLUGIN_MENU_LANGUAGE = GetLine("plugin.menu.language", "Language", true);
            PLUGIN_MENU_LANGUAGE_DESCRIPTION = GetLine("plugin.menu.language.description", "The language displayed by the game.");
            PLUGIN_MENU_LANGUAGE_UPDATE = GetLine("plugin.menu.language.update", "Refresh language", true);
            PLUGIN_MENU_LANGUAGE_UPDATE_DESCRIPTION = GetLine("plugin.menu.language.update.description", "Reload the language displayed by the game.");
            PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_TITLE = GetLine("plugin.menu.language.update.dialog.title", "Reload Language", true);
            PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_MESSAGE = GetLine("plugin.menu.language.update.dialog.message", "This operation can take some time on slow computers.");
            PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_UNAVAILABLE_TITLE = GetLine("plugin.menu.language.update.dialog.unavailable.title", "Reload Language", true);
            PLUGIN_MENU_LANGUAGE_UPDATE_DIALOG_UNAVAILABLE_MESSAGE = GetLine("plugin.menu.language.update.dialog.unavailable.message", "This feature isn't available in game mode.");
            PLUGIN_MENU_RAINBOWMODE = GetLine("plugin.menu.rainbowmode", "Rainbow Mode", true);
            PLUGIN_MENU_RAINBOWMODE_DESCRIPTION = GetLine("plugin.menu.rainbowmode.description", "Applies a rainbow-like effect to some texts of the game.");

            BUTTON_BACK = GetLine("button.back", "Back");
            BUTTON_APPLY = GetLine("button.apply", "Apply");
            BUTTON_YES = GetLine("button.yes", "Yes");
            BUTTON_NO = GetLine("button.no", "No");
            BUTTON_OK = GetLine("button.ok", "Ok");
            BUTTON_CANCEL = GetLine("button.cancel", "Cancel");
            BUTTON_START = GetLine("button.start", "Start");
            BUTTON_DELETE = GetLine("button.delete", "Delete");

            HEADER_DESCRIPTION = GetLine("header.description", "Description", true);

            MAINMENU_PRESSKEY = GetLine("mainmenu.presskey", "Press any button to start", true,1);
            
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
            OPTIONS_VR = GetLine("options.vr", "VR Options");

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

            OPTIONS_GENERAL_TITLE = GetLine("options.general.title", "General Menu", true);
            OPTIONS_GENERAL_UNITS = GetLine("options.general.units", "Units:", true);
            OPTIONS_GENERAL_UNITS_METRIC = GetLine("options.general.units.metric", "Metric");
            OPTIONS_GENERAL_UNITS_IMPERIAL = GetLine("options.general.units.imperial", "Imperial");
            OPTIONS_GENERAL_ALLABILITIES = GetLine("options.general.allabilities", "All Abilities In Adventure Mode:", true);
            OPTIONS_GENERAL_RATINGPRIVACY = GetLine("options.general.ratingprivacy", "Workshop Rating Privacy:", true);
            OPTIONS_GENERAL_AUTODOWNLOAD = GetLine("options.general.autodownload", "Workshop Level Auto-Download:", true);
            OPTIONS_GENERAL_MENUANIMATIONS = GetLine("options.general.menuanimations", "Enable Menu Animations:", true);
            OPTIONS_GENERAL_BOOMBOX = GetLine("options.general.boombox", "Enable Boom Box Mode:", true);
            OPTIONS_GENERAL_BOOMBOX_BLOOM = GetLine("options.general.boombox.bloom", "Boom Box Bloom Intensity:", true);
            OPTIONS_GENERAL_BOOMBOX_SHAKE = GetLine("options.general.boombox.shake", "Boom Box Shake Intensity:", true);
            OPTIONS_GENERAL_VISUALIZER = GetLine("options.general.visualizer", "Car Screen Visualizer:", true);
            OPTIONS_GENERAL_VISUALIZER_OFF = GetLine("options.general.visualizer.off", "off");
            OPTIONS_GENERAL_VISUALIZER_CIRCLE = GetLine("options.general.visualizer.circle", "Circle");
            OPTIONS_GENERAL_VISUALIZER_BARS = GetLine("options.general.visualizer.bars", "Bars");
            OPTIONS_GENERAL_SHUFFLELEVELS = GetLine("options.general.shufflelevels", "Shuffle Levels:", true);
            OPTIONS_GENERAL_SHOWTRICKTEXT = GetLine("options.general.showtricktext", "Show Trick Text:", true);

            OPTIONS_CONTROLS_TITLE = GetLine("options.controls.title", "Controls Options", true);
            OPTIONS_CONTROLS_SUBTITLE = GetLine("options.controls.subtitle", "Editing {0}'s controls");
            OPTIONS_CONTROLS_DEVICE = GetLine("options.controls.device", "Device", true);
            OPTIONS_CONTROLS_SCHEME_SELECTED = GetLine("options.controls.scheme.selected", "Selected Scheme:", true);
            OPTIONS_CONTROLS_SCHEME_EDIT = GetLine("options.controls.scheme.edit", "Edit Scheme", true);
            OPTIONS_CONTROLS_SCHEME_DELETE = GetLine("options.controls.scheme.delete", "Delete", true);
            OPTIONS_CONTROLS_SCHEME_DUPLICATE = GetLine("options.controls.scheme.duplicate", "Duplicate", true);
            OPTIONS_CONTROLS_SCHEME_RENAME = GetLine("options.controls.scheme.rename", "Rename", true);
            OPTIONS_CONTROLS_INVERTY = GetLine("options.controls.inverty", "Invert Y (Flying):", true);
            OPTIONS_CONTROLS_SELFRIGHTING = GetLine("options.controls.selfrighting", "Tipped Over Self-Righting:", true);
            OPTIONS_CONTROLS_LANDINGASSIST = GetLine("options.controls.landingassist", "Flight Landing Assist:", true);
            OPTIONS_CONTROLS_RUMBLEINTENSITY = GetLine("options.controls.rumbleintensity", "Rumble Intensity:", true);
            OPTIONS_CONTROLS_STEERINGSENSITIVITY = GetLine("options.controls.steeringsensitivity", "Steering Sensitivity:", true);
            OPTIONS_CONTROLS_FLIGHTSENSITIVITY = GetLine("options.controls.flightsensitivity", "Flight Sensitivity:", true);
            OPTIONS_CONTROLS_INPUTSMOOTHING = GetLine("options.controls.inputsmoothing", "Digital Input Smoothing:", true);
            OPTIONS_CONTROLS_TAB_BASIC = GetLine("options.controls.tab.basic", "Basic");
            OPTIONS_CONTROLS_TAB_FLIGHT = GetLine("options.controls.tab.flight", "Flight");
            OPTIONS_CONTROLS_TAB_CAMERA = GetLine("options.controls.tab.camera", "Camera");
            OPTIONS_CONTROLS_TAB_MENU = GetLine("options.controls.tab.menu", "Menu");

            OPTIONS_CONTROLS_VIEWING = GetLine("options.controls.viewing", "Viewing: {0}");
            OPTIONS_CONTROLS_EDITING = GetLine("options.controls.editing", "Editing: {0}");
            OPTIONS_CONTROLS_HELPTEXT = GetLine("options.controls.helptext", "[FFFFFF][Enter] Edit  [Del] Clear  [Esc] Revert[-]");

            CONTROLS_NOTSET = GetLine("controls.notset", "(Not Set)");

            CONTROLS_BASIC_GAS = GetLine("controls.basic.gas", "Gas");
            CONTROLS_BASIC_BRAKE = GetLine("controls.basic.brake", "Brake");
            CONTROLS_BASIC_STEER_LEFT = GetLine("controls.basic.steer.left", "Steer Left");
            CONTROLS_BASIC_STEER_RIGHT = GetLine("controls.basic.steer.right", "Steer Right");
            CONTROLS_BASIC_BOOST = GetLine("controls.basic.boost", "Boost");
            CONTROLS_BASIC_JUMP = GetLine("controls.basic.jump", "Jump");
            CONTROLS_BASIC_WINGS = GetLine("controls.basic.wings", "Wings");
            CONTROLS_BASIC_GRIP = GetLine("controls.basic.grip", "Grip");
            CONTROLS_BASIC_SPECIAL = GetLine("controls.basic.special", "Special");
            CONTROLS_BASIC_RESET = GetLine("controls.basic.reset", "Reset");
            CONTROLS_BASIC_PAUSE = GetLine("controls.basic.pause", "Pause");
            CONTROLS_BASIC_HORN = GetLine("controls.basic.horn", "Horn");
            CONTROLS_BASIC_SHOWSCORE = GetLine("controls.basic.showscore", "Show Score");
            CONTROLS_BASIC_CHAT = GetLine("controls.basic.chat", "Chat");

            CONTROLS_FLIGHT_AIRROLL_LEFT = GetLine("controls.flight.airroll.left", "Air Roll Left");
            CONTROLS_FLIGHT_AIRROLL_RIGHT = GetLine("controls.flight.airroll.right", "Air Roll Right");
            CONTROLS_FLIGHT_AIRPITCH_DOWN = GetLine("controls.flight.airpitch.down", "Air Pitch Down");
            CONTROLS_FLIGHT_AIRPITCH_UP = GetLine("controls.flight.airpitch.up", "Air Pitch Up");
            CONTROLS_FLIGHT_WINGYAW_LEFT = GetLine("controls.flight.wingyaw.left", "Wing Yaw Left");
            CONTROLS_FLIGHT_WINGYAW_RIGHT = GetLine("controls.flight.wingyaw.right", "Wing Yaw Right");
            CONTROLS_FLIGHT_WINGPITCH_DOWN = GetLine("controls.flight.wingpitch.down", "Wing Pitch Down");
            CONTROLS_FLIGHT_WINGPITCH_UP = GetLine("controls.flight.wingpitch.up", "Wing Pitch Up");
            CONTROLS_FLIGHT_JETROLL_LEFT = GetLine("controls.flight.jetroll.left", "Jet Roll Left");
            CONTROLS_FLIGHT_JETROLL_RIGHT = GetLine("controls.flight.jetroll.right", "Jet Roll Right");
            CONTROLS_FLIGHT_JETPITCH_DOWN = GetLine("controls.flight.jetpitch.down", "Jet Pitch Down");
            CONTROLS_FLIGHT_JETPITCH_UP = GetLine("controls.flight.jetpitch.up", "Jet Pitch Up");
            CONTROLS_FLIGHT_WINGROLL_LEFT = GetLine("controls.flight.wingroll.left", "Wing Roll Left");
            CONTROLS_FLIGHT_WINGROLL_RIGHT = GetLine("controls.flight.wingroll.right", "Wing Roll Right");

            CONTROLS_CAMERA_CENTER = GetLine("controls.camera.center", "Center Camera");
            CONTROLS_CAMERA_LOOKBEHIND = GetLine("controls.camera.lookbehind", "Camera Look Behind");
            CONTROLS_CAMERA_YAW_LEFT = GetLine("controls.camera.yaw.left", "Camera Yaw Left");
            CONTROLS_CAMERA_YAW_RIGHT = GetLine("controls.camera.yaw.right", "Camera Yaw Right");
            CONTROLS_CAMERA_PITCH_DOWN = GetLine("controls.camera.pitch.down", "Camera Pitch Down");
            CONTROLS_CAMERA_PITCH_UP = GetLine("controls.camera.pitch.up", "Camera Pitch Up");
            CONTROLS_CAMERA_CHANGEVIEW = GetLine("controls.camera.changeview", "Change Camera View");
            CONTROLS_CAMERA_NEXTPLAYER = GetLine("controls.camera.nextplayer", "Spectate Next Player");

            CONTROLS_MENU_CONFIRM = GetLine("controls.menu.confirm", "Menu Confirm");
            CONTROLS_MENU_CANCEL = GetLine("controls.menu.cancel", "Menu Cancel");
            CONTROLS_MENU_LEFT = GetLine("controls.menu.left", "Menu Left");
            CONTROLS_MENU_RIGHT = GetLine("controls.menu.right", "Menu Right");
            CONTROLS_MENU_DOWN = GetLine("controls.menu.down", "Menu Down");
            CONTROLS_MENU_UP = GetLine("controls.menu.up", "Menu Up");
            CONTROLS_MENU_START = GetLine("controls.menu.start", "Menu Start");
            CONTROLS_MENU_PAGE_LEFT = GetLine("controls.menu.page.left", "Menu Page Left");
            CONTROLS_MENU_PAGE_RIGHT = GetLine("controls.menu.page.right", "Menu Page Right");
            CONTROLS_MENU_PAGE_DOWN = GetLine("controls.menu.page.down", "Menu Page Down");
            CONTROLS_MENU_PAGE_UP = GetLine("controls.menu.page.up", "Menu Page Up");
            CONTROLS_MENU_DELETE = GetLine("controls.menu.delete", "Menu Delete");
            CONTROLS_MENU_CREATEPLAYLIST = GetLine("controls.menu.createplaylist", "Menu Create Playlist");
            CONTROLS_MENU_RATELEVEL = GetLine("controls.menu.ratelevel", "Menu Rate Level");
            CONTROLS_MENU_SORTING = GetLine("controls.menu.sorting", "Menu Sorting");
            CONTROLS_MENU_TOGGLEVISIBILITY = GetLine("controls.menu.togglevisibility", "Toggle Menu Visibility");

            OPTIONS_PROFILES_TITLE = GetLine("options.profiles.title", "Profile Options", true);
            OPTIONS_PROFILES_ADD = GetLine("options.profiles.add", "Add profile", true);
            OPTIONS_PROFILES_RENAME = GetLine("options.profiles.rename", "Rename Profile", true);
            OPTIONS_PROFILES_DELETE = GetLine("options.profiles.delete", "Delete Profile", true);
            OPTIONS_PROFILES_SELECT = GetLine("options.profiles.select", "Select Primary Profile", true);
            OPTIONS_PROFILES_CREATE = GetLine("options.profiles.create", "Create A New Profile", true);
            OPTIONS_PROFILES_ENTERNAME = GetLine("options.profiles.entername", "Enter a name here");
            OPTIONS_PROFILES_EDIT = GetLine("options.profiles.edit", "Edit selected profile: {0}");
            OPTIONS_PROFILES_SELECTED = GetLine("options.profiles.selected", "(selected)");

            OPTIONS_REPLAYS_TITLE = GetLine("options.replays.title", "Replay and Ghosts Options", true);
            OPTIONS_REPLAYS_TYPE = GetLine("options.replays.type", "Ghosts In Arcade Type:", true);
            OPTIONS_REPLAYS_TYPE_DISABLED = GetLine("options.replays.type.disabled", "Disabled");
            OPTIONS_REPLAYS_TYPE_LOCAL = GetLine("options.replays.type.local", "Local");
            OPTIONS_REPLAYS_TYPE_FRIENDS = GetLine("options.replays.type.friends", "Friends");
            OPTIONS_REPLAYS_TYPE_NEARMYRANKING = GetLine("options.replays.type.nearmyranking", "Near My Ranking");
            OPTIONS_REPLAYS_TYPE_GLOBALBEST = GetLine("options.replays.type.globalbest", "Global Best");
            OPTIONS_REPLAYS_COUNT = GetLine("options.replays.count", "Ghosts In Arcade Count:", true);
            OPTIONS_REPLAYS_BRIGHTNESS = GetLine("options.replays.brightness", "Ghosts Brightness:", true);
            OPTIONS_REPLAYS_NAMESVISIBLE = GetLine("options.replays.namesvisible", "Ghosts Names Visible:", true);
            OPTIONS_REPLAYS_PLAYBACKSPEED = GetLine("options.replays.playbackspeed", "Playback Speed Affects Music:", true);
        }

        public static void Apply()
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        // List of colors (in order) used in the rainbow effect (colors from the randomize button in the garage menu)
        public static List<string> Rainbow = new List<String>(){
            "F70001",
            "FEA700",
            "FFFF00",
            "008100",
            "0000FE",
            "840083"
        };

        // List of translation keys that can't be affected by the rainbow effect
        public static List<string> RainbowProof = new List<String>(){
            "language.name",
            "language.author",
            "plugin.menu.rainbowmode.description",
            "plugin.menu.language.description",
            "options.audio.announcersettings.allmodes",
            "options.audio.announcersettings.arcadeonly",
            "options.audio.announcersettings.stuntonly",
            "options.audio.announcersettings.disabled",
            "options.general.units.metric",
            "options.general.units.imperial",
            "options.general.visualizer.off",
            "options.general.visualizer.circle",
            "options.general.visualizer.bars",
            "options.replays.type.disabled",
            "options.replays.type.local",
            "options.replays.type.friends",
            "options.replays.type.nearmyranking",
            "options.replays.type.globalbest",
        };
        
        public static string GetLine(String Line,String Default, bool uppercase = false,int aestheticspaces = 0,bool rainbow = false)
        {
            string result = "";
            try
            {
                if (CurrentPlugin.Config.GetItem<string>("LanguageFile") == ":default:")
                {
                    throw new Exception("default language");
                }
                result = CurrentPlugin.Lang.GetItem<string>(Line);
            }
            catch (Exception VirusSpirit)
            {
                if (Line != "nothing" && VirusSpirit.Message != "default language")
                {
                    CurrentPlugin.Log.Exception(VirusSpirit);
                    CurrentPlugin.Log.Error("Impossible to find the translation key for \"" + Line + "\" in \"" + CurrentPlugin.Config.GetItem<String>("LanguageFile") + ".json\"");
                }
                result = Default;
            }
            if ((result == "") || (result == null) || (result == string.Empty)) {
                result = Default;
            }
            if (uppercase) result = result.ToUpperInvariant();
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
            if ((rainbow || (bool)CurrentPlugin.Config.GetItem<bool>("Rainbow")) && !RainbowProof.Contains(Line))
            {
                int index = 0;
                string rainbowresult = "";
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
            return result;
        }
    }
}
