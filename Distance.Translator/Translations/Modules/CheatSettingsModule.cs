using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;
using Harmony;

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

        public override string Name => "Cheat Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode");
        }

        public override void Run()
        {
            bool flag_unlocked = false;

            flag_unlocked = G.Sys.Achievements_.HasAchieved(EAchievements.Adventurer);

            //GameObject.Find($"{Root()}/CAMPAIGN PLUS/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.cheats.campaignplus").UP();
            
            Disable();
        }
    }

    [HarmonyPatch(typeof(AchievementManager), "HasAchieved")]
    [HarmonyPatch(typeof(CheatsManager), "IsUnlocked")]
    [HarmonyPatch(typeof(CheatFlags), "IsSet")]
    public class Lock
    {
        public static void Postfix(ref bool __result)
        {
            __result = false;
        }
    }
}
