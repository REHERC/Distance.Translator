using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class ProfileEditHeaderModule : DynamicTranslateModule
    {
        public override string Name => "Profile Edit Header";

        public override bool Run(ref UILabel instance)
        {
            instance.text = string.Format(Language.GetLine("settings.profiles.edit.title"), G.Sys.ProfileManager_.CurrentProfile_.Name_);
            return true;
        }
    }
}
