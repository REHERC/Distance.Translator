using Distance.Translator.Menu;
using Spectrum.Menu.UI;
using UnityEngine;

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
            
            GameObject DescriptionArea = GameObject.Find("OptionsFrontRoot/Panel - Options/Language/Options/DescriptionArea");
            if (DescriptionArea != null)
            {
                DescriptionArea.Destroy();
            }
        }

        public override void OnPanelPop()
        {

        }
    }
}
