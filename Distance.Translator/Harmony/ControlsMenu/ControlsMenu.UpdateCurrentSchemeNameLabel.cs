using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(ControlsMenu), "UpdateCurrentSchemeNameLabel")]
    public class ControlsMenu__UpdateCurrentSchemeNameLabel__Patch
    {
        static bool Prefix(ControlsMenu __instance)
        {
            if (!__instance.selectedControlScheme_) return false;
            __instance.currentSchemeNameLabel_.text = string.Format(Language.GetLine(__instance.inSchemeEditingMode_ ? "settings.controls.info.editing" : "settings.controls.info.viewing"), __instance.selectedControlScheme_.name_);
            return false;
        }
    }
}