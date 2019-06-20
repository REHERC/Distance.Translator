using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;
using Harmony;
using System.Linq;

namespace Distance.Translator.Modules
{
    class CheatSettingsModule : TranslateModule
    {
        public static string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Cheats/Options/OptionsTable";
            return "OptionsFrontRoot(Clone)/Panel - Options/Cheats/Options/OptionsTable";
        }

        public static string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Cheats/MenuTitleTemplate";
            return "OptionsFrontRoot(Clone)/Panel - Options/Cheats/MenuTitleTemplate";
        }

        public override string Name => "Cheat Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode");
        }

        public override void Run()
        {
            Transform OptionsTable = GameObject.Find(Root()).transform;
            Transform[] Widgets = (from child_object in OptionsTable.GetChildren() where !child_object.HasComponent<UIExBlueprint>() select child_object).ToArray();

            void Translate(ECheat cheat, int index, string id)
            {
                if (G.Sys.CheatsManager_.IsUnlocked(cheat))
                {
                    if ((cheat == ECheat.CampaignPlus && !G.Sys.CheatsManager_.CampaignPlusRecognized_) || G.Sys.CheatsManager_.GetCheat(cheat).affectsGameplay && !G.Sys.CheatsManager_.GameplayCheatsRecognized_)
                    {
                        Widgets[index].Find("NameLabel").GetComponent<UILabel>().text = Language.GetLine($"settings.cheats.{id}").UP().Colorize(Colors.tomato);
                        Widgets[index].gameObject.GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine($"settings.cheats.{id}.description.unavailable"));
                    }
                    else
                    {
                        bool flag_needrestart = cheat == ECheat.CampaignPlus && G.Sys.GameManager_.IsCampaignMode_;
                        Widgets[index].Find("NameLabel").GetComponent<UILabel>().text = (Language.GetLine($"settings.cheats.{id}") + ':').UP();
                        Widgets[index].gameObject.GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine($"settings.cheats.{id}.description.unlocked") + (flag_needrestart ? '\n' + Language.GetLine($"settings.cheats.{id}.description.needrestart") : ""));
                    }
                }
                else
                {
                    Widgets[index].Find("NameLabel").GetComponent<UILabel>().text = GUtils.GetLockedText(Language.GetLine($"settings.cheats.{id}")).Colorize(Color.gray);
                    Widgets[index].gameObject.GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine($"settings.cheats.{id}.description.locked"));
                }
            }

            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Title").GetComponent<UILabel>().text = Language.GetLine("settings.cheats.title");

            Translate(ECheat.CampaignPlus, 0, "campaignplus");
            Translate(ECheat.MotorcycleMode, 1, "motorcyclemode");
            Translate(ECheat.MonsterTruck, 2, "monstertruck");
            Translate(ECheat.SkyWalker, 3, "skywalker");
            Translate(ECheat.FilmNoir, 4, "filmnoir");
            Translate(ECheat.StylizedOutlines, 5, "stylizedoutlines");
            Translate(ECheat.SuperBoost, 6, "superboost");
            Translate(ECheat.MaxDamage, 7, "maxdamage");
            Translate(ECheat.BubbleCar, 8, "bubblecar");
            Translate(ECheat.DeathProof, 9, "deathproof");
            Translate(ECheat.CrabFriend, 10, "crabfriend");
            Translate(ECheat.CrownOfTheElders, 11, "crownoftheelders");
            Translate(ECheat.PreservationalBoosterSloth, 12, "preservationalboostersloth");

            Disable();
        }
    }
}