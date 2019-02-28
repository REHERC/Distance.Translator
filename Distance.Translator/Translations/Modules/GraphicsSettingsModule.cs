using static Distance.Translator.Extensions.StringExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Distance.Translator.Modules
{
    class GraphicsSettingsModule : TranslateModule
    {
        public static string Root()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center";
            return "OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center";
        }

        public static string MenuTitleTemplate()
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MainMenu")
                return "OptionsFrontRoot/Panel - Options/Panel - Graphics/Panel - MenuTitle";
            return "OptionsFrontRoot/Panel - Options/Panel - Graphics/Panel - MenuTitle";
        }

        public override string Name => "Grapics Settings";

        public override bool IsValidContext()
        {
            Scene scene = SceneManager.GetActiveScene();
            return (scene.name == "MainMenu" || scene.name == "GameMode");
        }

        public override void Run()
        {
            GameObject.Find($"{MenuTitleTemplate()}/UILabel - Title").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.title");

            GameObject.Find($"{Root()}/APPLY BACK/Apply/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.buttons.apply").UP();
            GameObject.Find($"{Root()}/APPLY BACK/Back/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.buttons.back").UP();
            
            GameObject.Find($"{Root()}/DescriptionArea/Title").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.desctiption.header").UP();

            GameObject.Find($"{Root()}/VideoSettingsCategory/Title").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.videosettings.title").UP();
            GameObject.Find($"{Root()}/VideoSettingsCategory/Fullscreen/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.videosettings.fullscreen").UP();
            GameObject.Find($"{Root()}/VideoSettingsCategory/Fullscreen").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.videosettings.fullscreen.description"));
            GameObject.Find($"{Root()}/VideoSettingsCategory/Resolution/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.videosettings.resolution").UP();
            GameObject.Find($"{Root()}/VideoSettingsCategory/Resolution").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.videosettings.resolution.description"));
            GameObject.Find($"{Root()}/VideoSettingsCategory/VSync/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.videosettings.vsync").UP();
            GameObject.Find($"{Root()}/VideoSettingsCategory/VSync").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.videosettings.vsync.description"));
            GameObject.Find($"{Root()}/VideoSettingsCategory/BrightnessButton/UILabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.videosettings.brightness").UP();
            GameObject.Find($"{Root()}/VideoSettingsCategory/BrightnessButton").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.videosettings.brightness.description"));


            GameObject.Find($"{Root()}/BonusEffectsCategory/Title").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.bonuseffects.title").UP();
            GameObject.Find($"{Root()}/BonusEffectsCategory/CinematicLetterbox/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.bonuseffects.letterbox").UP();
            GameObject.Find($"{Root()}/BonusEffectsCategory/CinematicLetterbox").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.bonuseffects.letterbox.description"));
            GameObject.Find($"{Root()}/BonusEffectsCategory/CinematicLetterbox").GetComponent<SetMenuDescriptionOnHover>().SetPrivateField("warningText_", Language.GetLine("settings.graphics.bonuseffects.letterbox.warning"));

            GameObject.Find($"{Root()}/AdvancedCategory/Title").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.title").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/Bloom/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.bloom").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/Bloom").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.bloom.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/FilmGrain/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.filmgrain").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/FilmGrain").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.filmgrain.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/Vignetting/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.vignetting").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/Vignetting").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.vignetting.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/RadialBlur/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.radialblur").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/RadialBlur").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.radialblur.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/SunShafts/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.sunshafts").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/SunShafts").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.sunshafts.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/RealTimeReflections/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.reflections").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/RealTimeReflections").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.reflections.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/RealTimeReflections").GetComponent<SetMenuDescriptionOnHover>().SetPrivateField("warningText_", Language.GetLine("settings.graphics.advanced.reflections.warning"));
            GameObject.Find($"{Root()}/AdvancedCategory/AnisotropicFiltering/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.anisotropic").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/AnisotropicFiltering").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.anisotropic.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/DepthOfField/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.depthoffield").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/DepthOfField").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.depthoffield.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/AntiAliasing/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.antialiasing").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/AntiAliasing").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.antialiasing.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/CarDents/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.cardents").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/CarDents").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.cardents.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/Detailed Lighting/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.lighting").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/Detailed Lighting").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.lighting.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/DrawDistance/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.drawdistance").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/DrawDistance").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.drawdistance.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/MotionBlur/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.motionblur").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/MotionBlur").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.motionblur.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/Particles/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.particles").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/Particles").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.particles.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/ShadowQuality/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.shadowquality").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/ShadowQuality").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.shadowquality.description"));
            GameObject.Find($"{Root()}/AdvancedCategory/TextureQuality/NameLabel").GetComponent<UILabel>().text = Language.GetLine("settings.graphics.advanced.texturequality").UP();
            GameObject.Find($"{Root()}/AdvancedCategory/TextureQuality").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.GetLine("settings.graphics.advanced.texturequality.description"));
            
            Disable();
        }
    }
}
