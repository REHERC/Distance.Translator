using Harmony;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Menu
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(GeneralMenu), "InitializeVirtual")]
        internal class GeneralMenu_InitializeVirtual_Patch : GeneralMenu
        {
            public static void Prefix(GeneralMenu __instance)
            {
                Scene scene = SceneManager.GetActiveScene();
                if (scene.name == "MainMenu")
                {
                    __instance.TweakLanguage();
                }
            }
        }
    }
}