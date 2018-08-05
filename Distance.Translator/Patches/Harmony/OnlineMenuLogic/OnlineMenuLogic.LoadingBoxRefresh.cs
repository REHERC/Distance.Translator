using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(OnlineMenuLogic), "LoadingBoxRefresh")]
        internal class OnlineMenuLogic_LoadingBoxRefresh_Patch : OnlineMenuLogic
        {
            public static void Postfix(OnlineMenuLogic __instance)
            {
                __instance.loadingLabel_.text = Language.MULTIPLAYER_ONLINE_REFRESHING;
            }
        }
    }
}