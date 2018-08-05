using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(OnlineMenuLogic), "LoadingBoxConnecting")]
        internal class OnlineMenuLogic_LoadingBoxConnecting_Patch : OnlineMenuLogic
        {
            public static void Postfix(OnlineMenuLogic __instance)
            {
                __instance.loadingLabel_.text = Language.MULTIPLAYER_ONLINE_CONNECTING;
            }
        }
    }
}