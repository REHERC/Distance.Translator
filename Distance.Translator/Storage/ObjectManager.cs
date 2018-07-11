using System.Collections.Generic;
namespace Distance.Translator
{
    public static class ObjectManager
    {
        public static List<string> Panels = null;

        public static void Initialize()
        {
            Panels = new List<string>();
            Panels.Clear();
        }

        public static void AddPanel(string panel)
        {
            if (!Panels.Contains(panel))
            {
                Panels.Add(panel);
            }
        }
    }
}
