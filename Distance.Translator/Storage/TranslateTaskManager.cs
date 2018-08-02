using System;
using System.Collections.Generic;

namespace Distance.Translator
{
    public static class TranslateTaskManager
    {
        public static List<TranslateTask> Translations;

        public static void Initialize()
        {
            Translations = new List<TranslateTask>();
            Translations.Clear();
            
            Translations.Add(new Watermark() { CanRun = true });

            Translations.Add(new Mainmenu() { CanRun = true });

            Translations.Add(new SubmenuOptions() { CanRun = true });
            
            Translations.Add(new MainmenuAudio() { CanRun = true });
            Translations.Add(new MainmenuGeneral() { CanRun = true });
            Translations.Add(new MainmenuControls() { CanRun = true });
            Translations.Add(new MainmenuGraphics() { CanRun = true });
            Translations.Add(new MainmenuProfiles() { CanRun = true });
            Translations.Add(new MainmenuReplay() { CanRun = true });
            Translations.Add(new MainmenuLanguage() { CanRun = true });
        }

        public static void Run()
        {
            foreach (TranslateTask Translation in Translations)
            {
                if (Translation.CanRun)
                {
                    try
                    {
                        Translation.Run();
                    }
                    catch (Exception BRUH)
                    {

                    }
                }
            }
        }

        public static void Reset()
        {
            foreach (TranslateTask Translation in Translations)
            {
                Translation.CanRun = true;
            }
        }
    }
}
