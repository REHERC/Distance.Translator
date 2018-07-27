using System;
using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(ControlsMenu), "UpdateCurrentSchemeNameLabel")]
        internal class ControlsMenu_UpdateCurrentSchemeNameLabel_Patch : ControlsMenu
        {
            static void Postfix(ControlsMenu __instance)
            {
                string State = __instance.currentSchemeNameLabel_.text.Substring(11,8);
                string SchemeName = __instance.currentSchemeNameLabel_.text.Substring(27);
                string SchemeLabelText = "";
                switch (State.ToLowerInvariant()) {
                    case "viewing:":
                        SchemeLabelText = String.Format("[c][878787]" + Language.OPTIONS_CONTROLS_VIEWING,"[-][/c]" + SchemeName);
                        break;
                    case "editing:":
                        SchemeLabelText = String.Format("[c][878787]" + Language.OPTIONS_CONTROLS_EDITING, "[-][/c]" + SchemeName);
                        break;
                }
                __instance.currentSchemeNameLabel_.text = SchemeLabelText;
            }
        }
    }
}