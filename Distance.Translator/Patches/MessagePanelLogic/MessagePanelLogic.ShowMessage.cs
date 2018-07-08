using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(MessagePanelLogic), "ShowMessage")]
        internal class MessagePanelLogic_ShowMessage_Patch : MessagePanelLogic
        {
            static void Postfix(MessagePanelLogic __instance,string message, string title = "", string returnText = "", MessagePanelLogic.OnButtonClicked okDelegate = null, MessagePanelLogic.OnButtonClicked cancelDelegate = null, bool okCancel = false, UIWidget.Pivot textPivot = UIWidget.Pivot.Center, float time = 0f, bool yesNo = false) {
                if (yesNo)
                {
                    __instance.okRightLabel_.text = LanguageKeys.BUTTON_YES;
                    __instance.okCenterLabel_.text = LanguageKeys.BUTTON_YES;
                    __instance.cancelLeftLabel_.text = LanguageKeys.BUTTON_NO;
                }
                else
                {
                    __instance.okRightLabel_.text = LanguageKeys.BUTTON_OK;
                    __instance.okCenterLabel_.text = LanguageKeys.BUTTON_OK;
                    __instance.cancelLeftLabel_.text = LanguageKeys.BUTTON_CANCEL;
                }
            }
        }
    }
}