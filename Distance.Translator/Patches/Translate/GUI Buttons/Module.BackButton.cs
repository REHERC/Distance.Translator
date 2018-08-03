using UnityEngine;

namespace Distance.Translator
{
    class GUIBackButton : TranslateModule
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "GUI BackButton";

        public void Run()
        {
            if (GameObject.Find("BackButton/Panel/BackButton") != null)
            {
                GameObject.Find("BackButton/Panel/BackButton/NameLabel").GetComponent<UILabel>().text = Language.BUTTON_BACK.ToUpperInvariant();
            }
        }
    }
}