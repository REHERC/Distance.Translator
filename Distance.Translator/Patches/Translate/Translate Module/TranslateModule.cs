using System.Collections.Generic;

namespace Distance.Translator
{
    public interface TranslateModule
    {
        string Name { get; }

        bool CanRun { get; set; }

        void Run();
    }
}
