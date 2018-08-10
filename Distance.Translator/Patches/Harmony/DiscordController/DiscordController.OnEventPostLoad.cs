using Events.Level;
using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        //[HarmonyPatch(typeof(DiscordController), "OnEventPostLoad")]
        internal class DiscordController_OnEventPostLoad_Patch : DiscordController
        {
            static bool Prefix(DiscordController __instance, PostLoad.Data data)
            {
                if (BuildInfo.IsBetaBuild())
                {
                    __instance.presence.details = "Modding";
                    __instance.presence.state = "Distance.Translator";

                    __instance.presence.startTimestamp = 0L;
                    __instance.presence.endTimestamp = 0L;

                    __instance.presence.largeImageKey = "dodge";
                    __instance.presence.largeImageText = "using Spectrum.API;\n¯\\_(ツ)_/¯";
                    
                    DiscordRpc.UpdatePresence(ref __instance.presence);

                    return false;
                }
                return true;
            }

            static void Postfix(DiscordController __instance, PostLoad.Data data)
            {
                __instance.presence.largeImageKey = "dodge";
                DiscordRpc.UpdatePresence(ref __instance.presence);
            }

        }
    }
}
                