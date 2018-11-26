using Spectrum.API.Configuration;
using static Distance.Translator.CurrentPlugin;

namespace Distance.Translator
{
    public static class Language
    {
        public static string GetLine(string key)
        {
            //return $"{key}";
            bool issubtitle = key.StartsWith("subtitles.");

            Settings source = issubtitle ? Subtitles_Language : Gui_Language;

            return source.GetItem<string>(key);
        }
    }
}
