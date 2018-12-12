using System;
using System.Collections.Generic;

namespace Distance.Translator
{
    public static partial class ModuleManager
    {
        public static List<Action> ResetModules = new List<Action>()
        {
            () => {
                foreach (var profilebutton in UnityEngine.Object.FindObjectsOfType<ProfilesMenuProfileButton>())
                {
                    profilebutton.CallPrivateMethod("SetName");
                }
            }
        };

    }
}
