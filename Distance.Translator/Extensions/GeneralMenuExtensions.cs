using static Distance.Translator.CurrentPlugin;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Distance.Translator.Extensions
{
    public static class GeneralMenuExtensions
    {
        public static void CreateLanguageDropdown(this GeneralMenu __instance)
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
                            return CurrentPlugin.Configuration["InterfaceLanguage"].ToString();
                        };

                        Action<string> LangSet = delegate (string lang)
                        {
                            CurrentPlugin.Configuration["InterfaceLanguage"] = lang;
                            CurrentPlugin.Configuration.Save();

                            Language.Reload();
                        };

                        object[] args = {
                            "INTERFACE LANGUAGE",
                            LangGet,
                            LangSet,
                            "",
                            LanguageFiles.ToArray()
                            
                            /*
                            new Dictionary<string, string>()
                            {
                                {"English", ":default:"},
                                {"Français", "FR-fr"},
                            }.ToArray()*/

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
