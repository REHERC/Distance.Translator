using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(PauseMenuLogic), "Start")]
        internal class PauseMenuLogic_Start_Patch : PauseMenuLogic
        {
            public static void Postfix(PauseMenuLogic __instance)
            {
                __instance.resumeButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_RESUME;
                __instance.restartButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_RESTART;
                __instance.spectateButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_SPECTATE;
                __instance.backToEditorButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_GOEDITOR;
                __instance.backToLobbyButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_GOLOBBY;
                __instance.mainMenuButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_GOMENU;
                __instance.optionsButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_OPTIONS;
                __instance.nextLevelButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_NEXTLEVEL;
                __instance.reportBugButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_BUGREPORT;
                __instance.quitButton_.GetComponent<UILabel>().text = Language.MENUBUTTON_QUIT;
                foreach (UIExButton button in __instance.optionButtonsPanel_.GetComponentsInChildren<UIExButton>())
                {
                    Translate.OptionsPanelButtons(button.GetComponent<UILabel>());
                }
            }
        }
    }
}