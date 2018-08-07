using System;
using System.Collections.Generic;
using System.Reflection;

namespace Distance.Translator.Menu
{
    public static class GeneralMenu_Extensions
    {
        public static void TweakLanguage(this GeneralMenu __instance)
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
                            return SharedSettings.CURRENT_LANGUAGE;
                        };

                        Action<string> LangSet = delegate (string lang)
                        {
                            SharedSettings.CURRENT_LANGUAGE = lang;
                            IPCAntenna.SendSetting("DistanceTranslator", "config.language", lang);
                            IPCAntenna.SendCommand("DistanceTranslator", "language-reload");
                        };
                        
                        object[] args = {
                            "LANGUAGE",
                            LangGet,
                            LangSet,
                            null,
                            LanguageManager.Languages.ToArray()
                        };

                        genericMethod.Invoke(__instance, args);

                        return;
                    }
                }
            }
        }
    }
}