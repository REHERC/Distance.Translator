using static Distance.Translator.CurrentPlugin;
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
                            Configuration["SubtitlesLanguage"] = lang;
                            Configuration.Save();

                            Language.Reload();
                        };

                        object[] args = {
                            "SUBTITLES LANGUAGE",
                            LangGet,
                            LangSet,
                            "",
                            LanguageFiles.ToArray()

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
