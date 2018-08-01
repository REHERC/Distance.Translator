using System.Collections.Generic;

namespace Distance.Translator
{
    public interface TranslateTask
    {
        string Name { get; }

        bool CanRun { get; set; }

        void Run();
    }
}
