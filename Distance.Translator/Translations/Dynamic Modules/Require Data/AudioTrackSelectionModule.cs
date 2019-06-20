using System.IO;
using static Distance.Translator.Extensions.StringExtensions;

namespace Distance.Translator.Modules
{
    class AudioTrackSelectionModule : DynamicTranslateModule
    {
        public override string Name => "Audio Track Selection Label";

        public override bool Run(ref UILabel instance)
        {
            AudioManager am = G.Sys.AudioManager_;
            if (string.IsNullOrEmpty(am.CurrentCustomMusicDirectory_))
                instance.text = Language.GetLine("settings.audio.custommusic.selecttrack.nofolder");
            else if (!Directory.Exists(am.CurrentCustomMusicDirectory_))
                instance.text = Language.GetLine("settings.audio.custommusic.selecttrack.foldernotfound");
            return true;
        }
    }
}
