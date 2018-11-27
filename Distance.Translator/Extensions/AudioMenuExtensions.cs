using Distance.Translator;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Distance.Translator.Extensions
{
    public static class AudioMenuExtensions
    {
        public static void CreateLanguageDropdown(this AudioMenu __instance)
        {
            Type[] searchParameters = new Type[] {
                typeof(string),
                typeof(Func<string>),
                typeof(Action<string>),
                typeof(string),
                typeof(KeyValuePair<string, string>[])
            };
            MethodInfo[] methods = typeof(GeneralMenu).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (MethodInfo method in methods)
            {
                if (method.Name == "TweakEnum")
                {
                    MethodInfo genericMethod = method.MakeGenericMethod(typeof(string));
                    ParameterInfo[] methodParameters = genericMethod.GetParameters();
                    if (methodParameters.Length == searchParameters.Length)
                    {
                        for (int index = 0; index < searchParameters.Length; index++)
                        {
                            if (methodParameters[index].ParameterType != searchParameters[index])
                            {
                                continue;
                            }
                        }

                        Func<string> LangGet = delegate
                        {
                            return CurrentPlugin.Configuration["SubtitlesLanguage"].ToString();
                        };

                        Action<string> LangSet = delegate (string lang)
                        {
                            CurrentPlugin.Configuration["SubtitlesLanguage"] = lang;
                            CurrentPlugin.Configuration.Save();
                            ModuleManager.ResetAll();
                        };

                        object[] args = {
                            "SUBTITLES LANGUAGE",
                            LangGet,
                            LangSet,
                            "",
                            new Dictionary<string, string>()
                            {
                                {"English", ":default:"},
                                {"Français", "FR-fr"},
                            }.ToArray()

                            //LanguageManager.Languages.ToArray()
                        };

                        genericMethod.Invoke(__instance, args);

                        return;
                    }
                }
            }
        }
    }
}
