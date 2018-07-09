using System;
using System.Collections.Generic;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;
using Spectrum.Menu;
using Spectrum.Menu.Menus;
using UnityEngine;

namespace Distance.Translator.Menu
{
    public class Photon : IPlugin, IIPCEnabled
    {
        public void HandleIPCData(IPCData data)
        {
            IPCAntenna.RecieveData(data);
        }

        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine($"Initializing ... ({ipcIdentifier})");
            CurrentPlugin.initialize();
            LanguageManager.InitLanguages();
            IPCAntenna.initialize(manager, ipcIdentifier);
            CurrentPlugin.Log.Info("Initialization done!");
            CurrentPlugin.Log.Info("Subscribing to Events ...");
            Events.Scene.LoadFinish.Subscribe((data) =>
            {
                if (data.sceneName == "MainMenu" && SharedSettings.MAINPLUGIN_DETECTED)
                {
                    CreateMenu(manager, "SpectrumSettingsObject", "OptionsFrontRoot", "MainMenuFrontRoot");
                }
            });
            CurrentPlugin.Log.Info("Subscribed to Events!");
            CurrentPlugin.Log.Info("Starting IPC ...");
            IPCAntenna.SendAwake("DistanceTranslator");
            CurrentPlugin.Log.Info("IPC done!");
        }

        private void CreateMenu(IManager manager, string settingsObjectName, string optionsFrontRootName, string mainMenuFrontRootName)
        {
            var spectrumSettingsObject = new GameObject(settingsObjectName);
            var menuController = spectrumSettingsObject.AddComponent<LanguageSettingsMenu>();
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
