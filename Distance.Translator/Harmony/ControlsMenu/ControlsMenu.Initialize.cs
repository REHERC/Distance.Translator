using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(ControlsMenu), "Initialize")]
    public class ControlsMenu__Initialize__Patch
    {
        static void Postfix(ControlsMenu __instance)
        {
            ModuleManager.OnResetAll += () =>
            {
                __instance.UpdateCurrentSchemeNameLabel();
            };
        }
    }
}