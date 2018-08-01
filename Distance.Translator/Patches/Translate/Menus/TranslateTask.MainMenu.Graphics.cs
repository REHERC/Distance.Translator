using UnityEngine;

namespace Distance.Translator
{
    class MainmenuGraphics : TranslateTask
    {
        private bool _CanRun;
        public bool CanRun
        {
            get
            { return _CanRun; }
            set
            { _CanRun = value; }
        }

        public string Name => "Mainmenu Graphics";

        public void Run()
        {
            if (GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center") != null)
            {
                SetMenuDescriptionOnHover MenuDesc; // Just a way to access the SetMenuDescriptionOnHover component of Game Objects and modify it's warningText_ property with extension methods
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/DescriptionArea/Title").GetComponentsInChildren<UILabel>()[0].text = Language.HEADER_DESCRIPTION;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Panel - MenuTitle/UILabel - Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_TITLE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/APPLY BACK/Apply/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_APPLY.ToUpperInvariant();
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/APPLY BACK/Back/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.BUTTON_BACK.ToUpperInvariant();
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_VIDEOSETTINGS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Fullscreen/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_FULLSCREEN;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Fullscreen").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.OPTIONS_GRAPHICS_FULLSCREEN_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Resolution/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_RESOLUTION;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Resolution").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.OPTIONS_GRAPHICS_RESOLUTION_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/VSync/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_VSYNC;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/VSync").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.OPTIONS_GRAPHICS_VSYNC_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Brightness/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_BRIGHTNESS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Brightness").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0].SetText(Language.OPTIONS_GRAPHICS_BRIGHTNESS_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_BONUSEFFECTS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/StylizedOutlines/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_OUTLINES;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/StylizedOutlines").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetPrivateField("warningText_", Language.WARNING_GRAPHICS_BONUSEFFECT);
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_OUTLINES_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/FilmNoir/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_FILMNOIR;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/FilmNoir").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetPrivateField("warningText_", Language.WARNING_GRAPHICS_BONUSEFFECT);
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_FILMNOIR_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/CinematicLetterbox/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_LETTERBOX;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/CinematicLetterbox").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetPrivateField("warningText_", Language.WARNING_GRAPHICS_BONUSEFFECT);
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_LETTERBOX_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Title").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_ADVANCED;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Bloom/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_BLOOM;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Bloom").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_BLOOM_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/FilmGrain/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_FILMGRAIN;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/FilmGrain").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_FILMGRAIN_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Vignetting/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_VIGNETTING;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Vignetting").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_VIGNETTING_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/RadialBlur/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_RADIALBLUR;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/RadialBlur").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_RADIALBLUR_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/SunShafts/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_SUNSHAFTS;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/SunShafts").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_SUNSHAFTS_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/RealTimeReflections/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_REFLECTIONS;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/RealTimeReflections").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetPrivateField("warningText_", Language.WARNING_GRAPHICS_DEGRADEPERFORMANCE);
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_REFLECTIONS_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/AnisotropicFiltering/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_ANISOTROPICFILTERING;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/AnisotropicFiltering").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_ANISOTROPICFILTERING_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/DepthOfField/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_DEPTHOFFIELD;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/DepthOfField").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_DEPTHOFFIELD_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Particles/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_PARTICLES;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Particles").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_PARTICLES_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/TextureQuality/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_TEXTUREQUALITY;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/TextureQuality").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_TEXTUREQUALITY_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/AntiAliasing/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_ANTIALIASING;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/AntiAliasing").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_ANTIALIASING_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/DrawDistance/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_DRAWDISTANCE;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/DrawDistance").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_DRAWDISTANCE_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/ShadowQuality/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_SHADOWQUALITY;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/ShadowQuality").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_SHADOWQUALITY_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/MotionBlur/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_MOTIONBLUR;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/MotionBlur").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_MOTIONBLUR_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/CarDents/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_CARDENTS;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/CarDents").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_CARDENTS_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Detailed Lighting/NameLabel").GetComponentsInChildren<UILabel>()[0].text = Language.OPTIONS_GRAPHICS_DETAILEDLIGHTING;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Detailed Lighting").GetComponentsInChildren<SetMenuDescriptionOnHover>()[0];
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_DETAILEDLIGHTING_DESCRIPTION);

                CanRun = false;
            }
        }
    }
}