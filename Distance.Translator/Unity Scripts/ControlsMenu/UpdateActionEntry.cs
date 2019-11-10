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
            entry_.actionLabel_.text = $"controls.{entry_.Action_.ToString().DOWN().Replace("_", "")}";
        }
    }
}
