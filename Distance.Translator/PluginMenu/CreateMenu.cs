using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Interfaces.Systems;
using UnityEngine;

namespace Distance.Translator
{
    public partial class Photon
    {
        private void CreateMenu(IManager manager, string settingsObjectName, string optionsFrontRootName, string mainMenuFrontRootName)
        {
            var spectrumSettingsObject = new GameObject(settingsObjectName);
            var menuController = spectrumSettingsObject.AddComponent<LanguageMenu>();
            menuController.SetManager(manager);

            var optionsLogic = Util.FindByName(optionsFrontRootName).GetComponent<OptionsMenuLogic>();
            var options = new List<OptionsSubmenu>();
            options.AddRange(optionsLogic.subMenus_);
            options.Add(menuController);
            optionsLogic.subMenus_ = options.ToArray();

            var mainMenuLogic = Util.FindByName(mainMenuFrontRootName).GetComponent<MainMenuLogic>();
            List<MenuButtonList.ButtonInfo> buttonInfos = mainMenuLogic.optionsButtons_.GetButtonInfos(optionsLogic, false);
            mainMenuLogic.optionsButtons_.Init(buttonInfos);
        }
    }
}
