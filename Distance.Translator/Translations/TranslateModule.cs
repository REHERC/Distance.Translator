using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;

namespace Distance.Translator.Modules
{
    public partial class TranslateModule
    {
        public virtual string Name { get; set; }

        private bool CanRun = false;

        public void Enable()
        {
            CanRun = true;
        }

        public void Disable()
        {
            CanRun = false;
        }

        public bool IsEnabled() => CanRun && IsValidContext();

        public virtual bool IsValidContext() => true;

        public virtual void Run() {}

        public virtual void Initialize() {}
    }

    public partial class DynamicTranslateModule
    {
        public virtual string Name { get; set; }

        public virtual void Init(ref UILabel instance)
        {
            _state = instance.text.UP();
        }

        public virtual bool Run(ref UILabel instance) => true;

        public virtual void Reset(ref UILabel instance) { }

        public void ResetDropDown(ref UILabel instance)
        {
            GameObject go = instance.transform.parent.parent.gameObject;
            UIExPopupList list = go?.GetComponent<UIExPopupList>();
            if (list != null)
                instance.text = list.value;
        }
        
        protected string _state = "";
    }
}