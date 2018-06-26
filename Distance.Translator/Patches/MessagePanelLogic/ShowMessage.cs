using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using Spectrum.API;
using Spectrum.API.Configuration;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Logging;

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
                    __instance.okRightLabel_.text = Language.DIALOGS_YES;
                    __instance.okCenterLabel_.text = Language.DIALOGS_YES;
                    __instance.cancelLeftLabel_.text = Language.DIALOGS_NO;
                }
                else
                {
                    __instance.okRightLabel_.text = Language.DIALOGS_OK;
                    __instance.okCenterLabel_.text = Language.DIALOGS_OK;
                    __instance.cancelLeftLabel_.text = Language.DIALOGS_CANCEL;
                }
            }
        }
    }
}