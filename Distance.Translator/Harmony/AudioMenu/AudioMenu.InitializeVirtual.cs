using static Distance.Translator.Extensions.AudioMenuExtensions;
using static Distance.Translator.CurrentPlugin;
using Harmony;
using UnityEngine;

namespace Distance.Translator.Harmony
{
    //[HarmonyPatch(typeof(AudioMenu), "Initialize")]
    public class AudioMenu__InitializeVirtual__Patch
    {
        static void Postfix(AudioMenu __instance)
        {
            foreach (var obj in __instance.PanelObject_.transform.Find("Anchor - Center/VolumeOptions").gameObject.GetChildren())
            {
                if (obj.name.ToLowerInvariant() == "subtitles options")
                {
                    GameObject prefab = Object.Instantiate(obj);
                    prefab.name = "Subtitles Language";
                    prefab.transform.Find("NameLabel").GetComponent<UILabel>().text = "SUBTITLES LANGUAGE;";
                        
                    prefab.RemoveComponent<UIExPopupList>();

                    UIExPopupList subtitles_list = prefab.AddComponent<UIExPopupList>();

                    __instance.InitPopup<string>(subtitles_list,
                        () => {
                            return CurrentPlugin.Configuration["SubtitlesLanguage"].ToString(); ;
                        },
                        (value) => {
                            Configuration["SubtitlesLanguage"] = value;
                            Configuration.Save();

                            Language.Reload();
                        },
                        LanguageFiles.ToArray()
                    );



                    //prefab.transform.parent = obj.transform.parent;
                }
            }
        }
    }
}
