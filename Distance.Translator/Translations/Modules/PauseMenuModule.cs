using Distance.Translator.Extensions;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class PauseMenuModule : TranslateModule
    {
        const string MainRoot = "PauseMenuRoot/Panel - Main";
        const string Root = MainRoot + "/MainButtonsPanel/MainButtons";
        const string PausedRoot = MainRoot + "/Paused";
        const string InfoBoxRoot = MainRoot + "/Upper Right Group";

        public override string Name => "Pause Menu";
        
        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "GameMode" || scene.name == "LevelEditor") && GameObject.Find($"{Root}") != null;
        }

        public override void Run()
        {
            GameObject.Find($"{Root}/Resume/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.resume").UP();
            GameObject.Find($"{Root}/BackToEditor/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.backtoeditor").UP();
            GameObject.Find($"{Root}/BackToLobby/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.backtolobby").UP();
            GameObject.Find($"{Root}/Spectate/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.spectate").UP();
            GameObject.Find($"{Root}/Restart/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.restart").UP();
            GameObject.Find($"{Root}/Next Track/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.nexttrack").UP();
            GameObject.Find($"{Root}/MainMenu/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.mainmenu").UP();
            GameObject.Find($"{Root}/Tricks/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.tricks").UP();
            GameObject.Find($"{Root}/Options/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.options").UP();
            GameObject.Find($"{Root}/Quit/UILabel").GetComponent<UILabel>().text = Language.GetLine("pausemenu.quit").UP();

            GameObject.Find($"{MainRoot}/UILabel - Level Name").GetComponent<UILabel>().text = LevelName();

            GameObject.Find($"{MainRoot}/UILabel - Game Mode").GetComponent<UILabel>().text = ModeName();

            GameObject.Find($"{MainRoot}/UILabel - Mode Description").GetComponent<UILabel>().text = ModeDescription();

            GameObject.Find($"{PausedRoot}/UILabel - Paused").GetComponent<UILabel>().text = Language.GetLine("pausemenu.title").UP();
            GameObject.Find($"{PausedRoot}/UILabel - You Are The Host").GetComponent<UILabel>().text = Language.GetLine("pausemenu.hosting").UP();

            if (!G.Sys.GameManager_.SplitScreen_ && !G.Sys.GameManager_.IsLevelEditorMode_)
            {
                GameObject.Find($"{InfoBoxRoot}/Panel - Level Info/UILabel - Level Info").GetComponent<UILabel>().text = LevelInfo();
            }

            Disable();
        }

        public string LevelName()
        {
            string out_result = "";
            if (!G.Sys.GameManager_.IsLevelEditorMode_)
            {
                GameManager game_manager = G.Sys.GameManager_;

                string level_path = game_manager.LevelPath_;
                LevelInfo level_info = G.Sys.LevelSets_.GetLevelInfo(level_path);

                out_result = string.Format(Language.GetLine("levelinfo.levelname"), game_manager.LevelName_);
                if (SteamworksManager.IsSteamBuild_ && level_info.levelType_ == LevelType.Workshop)
                    out_result = string.Format(Language.GetLine("levelinfo.workshoplevelname"), game_manager.LevelName_, SteamworksManager.GetSteamName(level_info.workshopCreatorID_));
            }
            else
                out_result = string.Format(Language.GetLine("levelinfo.levelname"), G.Sys.LevelEditor_.WorkingLevel_.Settings_.LevelName_);
            return out_result;
        }

        public string ModeName()
        {
            GameMode mode = G.Sys.GameManager_.Mode_;

            string out_result = string.Format(Language.GetLine("levelinfo.mode"), Language.GetLine($"gamemode.{mode.GameModeID_.ToString().DOWN()}"));

            return out_result;
        }

        public string ModeDescription()
        {
            GameMode mode = G.Sys.GameManager_.Mode_;

            string out_result = $"[FFFFFF]{Language.GetLine($"gamemode.{mode.GameModeID_.ToString().DOWN()}.description")}[-]";

            return out_result;
        }

        public string LevelInfo()
        {
            GameManager game_manager = G.Sys.GameManager_;

            string level_path = game_manager.LevelPath_;
            LevelInfo level_info = G.Sys.LevelSets_.GetLevelInfo(level_path);

            ProfileProgress progress = G.Sys.ProfileManager_.CurrentProfile_.Progress_;
            GameMode mode = G.Sys.GameManager_.Mode_;


            string out_result = "";


            int best = progress.GetTopResultWithRelativePath(level_info.relativePath_, mode.GameModeID_);
            string personal_best = Language.GetLine("levelinfo.personalbest.none");
            if (best != -1)
                if (mode.ResultsDisplayType_ == ResultsDisplayType.Time)
                    personal_best = GUtils.GetFormattedMS(best);
                else
                    personal_best = $"{GUtils.GetFormattedPoints(best)} eV";
            string out_personal_best = string.Format(Language.GetLine("levelinfo.personalbest"), personal_best);


            bool supports_medals = level_info.SupportsMedals(mode.GameModeID_);
            MedalStatus medal_status = MedalStatus.None;
            string medal = Language.GetLine($"medal.none");
            if (mode.SupportsMedals_ && supports_medals && level_path != null)
            {
                medal_status = progress.GetMedalStatusWithRelativePath(level_info.relativePath_, mode.GameModeID_);
                medal = Language.GetLine($"medal.{medal_status.ToString().DOWN().Replace("_", "")}");
            }
            string out_medal_earned = string.Format(Language.GetLine("levelinfo.medalearned"), medal);

            
            string out_difficulty = string.Format(Language.GetLine("levelinfo.difficulty"), Language.GetLine($"difficulty.{level_info.difficulty_.ToString().DOWN()}"));


            out_result = $"{out_personal_best}\n{out_medal_earned}\n{out_difficulty}";

            if (level_info.levelType_ == LevelType.Workshop)
            {
                string rating, vote;
                rating = vote = "";
                if (SteamworksManager.IsSteamBuild_ && G.Sys.SteamworksManager_.UGC_.TryGetWorkshopLevelData(level_info.relativePath_, out WorkshopLevelInfo level_data))
                {
                    rating = SteamworksUGC.GetWorkshopRatingText(level_data);
                    vote = Language.GetLine("levelinfo.workshop.vote.none");
                    switch (level_data.workshopVote_)
                    {
                        case EWorkshopVote.k_EWorkshopVoteFor:
                            vote = Language.GetLine("levelinfo.workshop.vote.for");
                            break;
                        case EWorkshopVote.k_EWorkshopVoteAgainst:
                            vote = Language.GetLine("levelinfo.workshop.vote.against");
                            break;
                    }
                }
                else
                {
                    rating = Language.GetLine("levelinfo.workshop.rating.unknown");
                    vote = Language.GetLine("levelinfo.workshop.vote.unknown");
                }

                string out_rating = string.Format(Language.GetLine("levelinfo.workshop.rating"), rating);
                string out_vote = string.Format(Language.GetLine("levelinfo.workshop.vote"), vote);

                out_result += $"\n{out_result}\n{out_rating}\n{out_vote}";
            }

            return out_result;
        }
    }
}
