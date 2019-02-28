namespace Distance.Translator.Modules
{
    class InfoDisplayModule : TranslateModule
    {
        public override string Name => "Info Display";

        public override bool IsValidContext()
        {
            return Flags.GameMode && Flags.OfficialCampaign && !Flags.Loading;
        }

        public override void Run()
        {

        }
    }
}
