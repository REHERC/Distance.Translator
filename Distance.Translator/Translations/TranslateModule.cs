﻿namespace Distance.Translator
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

        public bool IsEnabled()
        {
            return CanRun && IsValidContext();
        }

        public virtual bool IsValidContext()
        {
            return true;
        }

        public virtual void Run()
        {

        }

        public virtual void Initialize()
        {

        }
    }
}