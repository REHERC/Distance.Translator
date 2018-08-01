using Distance.Translator.Menu;
using Spectrum.Menu.UI;

namespace Spectrum.Menu.Menus
{
    public class LanguageSettingsMenu : SpectrumMenu
    {
        public override string MenuTitleName_ => "PLUGIN_MENU_TITLE";
        public override string Name_ => "Language";


        public override bool DisplayInMenu(bool isPauseMenu)
        {
            return true;
        }
        
        public override void InitializeVirtual()
        {
            TweakEnum<string>("PLUGIN MENU LANGUAGE"
                     , () => SharedSettings.CURRENT_LANGUAGE
                     , (string lang) => 
                     {
                         SharedSettings.CURRENT_LANGUAGE = lang;
                         IPCAntenna.SendSetting("DistanceTranslator", "config.language", lang);
                         IPCAntenna.SendCommand("DistanceTranslator", "language-reload");
                     }
                     , "PLUGIN MENU LANGUAGE DESCRIPTION"
                     , LanguageManager.Languages.ToArray());
        }

        public override void OnPanelPop()
        {

        }
    }
}
