using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class AudioLoadingMusicModule : DynamicTranslateModule
    {
        public override string Name => "Audio Custom Music Loading Label";

        public override bool Run(ref UILabel instance)
        {
            switch (instance.gameObject.name.UP())
            {
                case "UILABEL - ADDED":
                    switch (CustomMusicState.state)
                    {
                        case CustomMusicState.ScanState.Started:
                        case CustomMusicState.ScanState.Complete:
                            instance.text = string.Format(Language.GetLine("settings.audio.custommusic.status.count"), CustomMusicState.fileCount, GUtils.GetFormattedPoints(CustomMusicState.fileCount));
                            break;
                        case CustomMusicState.ScanState.Running:
                            instance.text = string.Format(Language.GetLine("settings.audio.custommusic.status.scanning"), CustomMusicState.scanningFolder);

                            break;
                    }
                    break;
                case "UILABEL - SEARCHING":
                    instance.text = Language.GetLine("settings.audio.custommusic.status.searching");
                    break;
            }
            return true;
        }
    }
}
