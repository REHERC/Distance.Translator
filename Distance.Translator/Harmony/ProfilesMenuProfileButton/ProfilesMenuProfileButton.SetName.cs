using Distance.Translator.UnityScripts;
using Harmony;
using System;

namespace Distance.Translator.Harmony
{
    //TODO: Check why enabling this Harmony patch makes it throw an error
    [HarmonyPatch(typeof(ProfilesMenuProfileButton), "SetName", new Type[] { })]
    public class ProfilesMenuProfileButton__SetName__Patch
    {
        static void Postfix(ProfilesMenuProfileButton __instance)
        {
            string profilename = __instance.name_;
            __instance.nameLabel_.text = !__instance.selected_
                ? profilename
                : string.Format(Language.GetLine("settings.profiles.select.item"), profilename);
            //if (!__instance.gameObject.HasComponent<ProfileButtonUpdate>())
            //    __instance.gameObject.AddComponent<ProfileButtonUpdate>();
        }
    }
}
