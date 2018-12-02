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
}
