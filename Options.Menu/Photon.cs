﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.IPC;
using Spectrum.MenuSystem.UI;
using UnityEngine;

namespace Options.Menu
{
    public class Photon : IPlugin,IIPCEnabled
    {
        public void HandleIPCData(IPCData data)
        {
            IPCAntenna.RecieveData(data);
        }

        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Console.WriteLine("Initializing ...");
            CurrentPlugin.initialize();
            LanguageManager.InitLanguages();
            IPCAntenna.initialize(manager,ipcIdentifier);
            CurrentPlugin.Log.Info("Initialization done!");
            CurrentPlugin.Log.Info("Subscribing to game Events ...");
            Events.Scene.LoadFinish.Subscribe((data) =>
            {
                if (data.sceneName == "MainMenu")
                {
                    CreateMenu(manager, "SpectrumSettingsObject", "OptionsFrontRoot", "MainMenuFrontRoot");
                }
            });
            CurrentPlugin.Log.Info("Subscribed to Events!");
            CurrentPlugin.Log.Info("Starting IPC ...");
            IPCAntenna.SendAwake("DistanceTranslator");
            CurrentPlugin.Log.Info("IPC done!");
        }

        //CreateMenu(manager, "SpectrumSettingsObject", "OptionsFrontRoot", "MainMenuFrontRoot");
        private void CreateMenu(IManager manager, string settingsObjectName, string optionsFrontRootName, string mainMenuFrontRootName)
        {
            var spectrumSettingsObject = new GameObject(settingsObjectName);
            var menuController = spectrumSettingsObject.AddComponent<SpectrumSettingsMenu>();
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