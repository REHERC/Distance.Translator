using Distance.Translator.UnityScripts;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(ProfilesMenuProfileButton), "SetName")]
    public class ProfilesMenuProfileButton__SetName__Patch
    {
        static void Postfix(ProfilesMenuProfileButton __instance)
        {
            string profilename = __instance.GetPrivateField<string>("name_");
            __instance.nameLabel_.text = !__instance.GetPrivateField<bool>("selected_")
                ? profilename
                : string.Format(Language.GetLine("settings.profiles.select.item"), profilename);
            //if (!__instance.gameObject.HasComponent<ProfileButtonUpdate>())
            //    __instance.gameObject.AddComponent<ProfileButtonUpdate>();
        }
    }
}
