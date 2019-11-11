using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;

namespace Distance.Translator.UnityScripts
{
    class UpdateActionEntry : MonoBehaviour
    {
        ControlsMenuActionEntry entry_;

        void Awake()
        {
            entry_ = GetComponent<ControlsMenuActionEntry>();
        }

        void Update()
        {
            entry_.actionLabel_.text = Language.GetLine($"controls.{entry_.Action_.ToString().DOWN().Replace("_", "")}");


            void Replace(string search, string line)
            {
                if (entry_.primaryButton_.commandLabel_.text.DOWN() == search.DOWN())
                    entry_.primaryButton_.commandLabel_.text = Language.GetLine(line.DOWN());

                if (entry_.secondaryButton_.commandLabel_.text.DOWN() == search.DOWN())
                    entry_.secondaryButton_.commandLabel_.text = Language.GetLine(line.DOWN());
            }

            Replace("(Not Set)", "controls.special.notset");
            Replace("(Invalid ID)", "controls.special.invalidid");
        }
    }
}
