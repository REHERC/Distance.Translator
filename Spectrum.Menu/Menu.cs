using Distance.Translator;
using Harmony;
using Spectrum.API.Interfaces.Systems;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Distance.Translator.CurrentPlugin;

public static class Menu
{
    public static List<Type> menus;

    public static GameObject menuBlueprint;
    
    public static void Create<T>() where T : SpectrumMenu, new()
    {

    }
    
    private static void CreateMenu<T>(IManager manager, string settingsObjectName, string optionsFrontRootName, string mainMenuFrontRootName) where T : SpectrumMenu
    {
        menuBlueprint = Util.FindByName("SuperMenuBlueprint");

        settingsObjectName = $"{settingsObjectName} - {GetUniqueID()}";
        
        var spectrumSettingsObject = new GameObject(settingsObjectName);
        var menuController = spectrumSettingsObject.AddComponent<T>();
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

    public static string GetUniqueID()
    {
        Guid g = Guid.NewGuid();
        string guid = Convert.ToBase64String(g.ToByteArray());
        guid = guid.Replace("=", "");
        guid = guid.Replace("+", "");
        guid = guid.Replace("/", "");
        guid = guid.Replace("\\", "");

        return guid;
    }

    public static string GetOptionsRoot()
    {
        string scene = SceneManager.GetActiveScene().name.ToLower();
        return scene == "mainmenu" ? "OptionsFrontRoot" : "OptionsFrontRoot(Clone)";
    }
}