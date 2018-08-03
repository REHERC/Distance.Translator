using UnityEngine;

namespace Distance.Translator
{
    class MainmenuGraphics : TranslateModule
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
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/DescriptionArea/Title").GetComponent<UILabel>().text = Language.HEADER_DESCRIPTION;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Panel - MenuTitle/UILabel - Title").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_TITLE;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/APPLY BACK/Apply/NameLabel").GetComponent<UILabel>().text = Language.BUTTON_APPLY.ToUpperInvariant();
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/APPLY BACK/Back/NameLabel").GetComponent<UILabel>().text = Language.BUTTON_BACK.ToUpperInvariant();
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Title").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_VIDEOSETTINGS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Fullscreen/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_FULLSCREEN;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Fullscreen").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.OPTIONS_GRAPHICS_FULLSCREEN_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Resolution/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_RESOLUTION;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Resolution").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.OPTIONS_GRAPHICS_RESOLUTION_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/VSync/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_VSYNC;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/VSync").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.OPTIONS_GRAPHICS_VSYNC_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Brightness/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_BRIGHTNESS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/VideoSettingsCategory/Brightness").GetComponent<SetMenuDescriptionOnHover>().SetText(Language.OPTIONS_GRAPHICS_BRIGHTNESS_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/Title").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_BONUSEFFECTS;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/StylizedOutlines/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_OUTLINES;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/StylizedOutlines").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetPrivateField("warningText_", Language.WARNING_GRAPHICS_BONUSEFFECT);
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_OUTLINES_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/FilmNoir/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_FILMNOIR;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/FilmNoir").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetPrivateField("warningText_", Language.WARNING_GRAPHICS_BONUSEFFECT);
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_FILMNOIR_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/CinematicLetterbox/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_LETTERBOX;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/BonusEffectsCategory/CinematicLetterbox").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetPrivateField("warningText_", Language.WARNING_GRAPHICS_BONUSEFFECT);
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_LETTERBOX_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Title").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_ADVANCED;
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Bloom/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_BLOOM;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Bloom").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_BLOOM_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/FilmGrain/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_FILMGRAIN;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/FilmGrain").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_FILMGRAIN_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Vignetting/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_VIGNETTING;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Vignetting").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_VIGNETTING_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/RadialBlur/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_RADIALBLUR;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/RadialBlur").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_RADIALBLUR_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/SunShafts/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_SUNSHAFTS;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/SunShafts").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_SUNSHAFTS_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/RealTimeReflections/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_REFLECTIONS;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/RealTimeReflections").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetPrivateField("warningText_", Language.WARNING_GRAPHICS_DEGRADEPERFORMANCE);
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_REFLECTIONS_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/AnisotropicFiltering/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_ANISOTROPICFILTERING;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/AnisotropicFiltering").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_ANISOTROPICFILTERING_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/DepthOfField/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_DEPTHOFFIELD;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/DepthOfField").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_DEPTHOFFIELD_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Particles/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_PARTICLES;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Particles").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_PARTICLES_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/TextureQuality/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_TEXTUREQUALITY;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/TextureQuality").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_TEXTUREQUALITY_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/AntiAliasing/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_ANTIALIASING;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/AntiAliasing").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_ANTIALIASING_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/DrawDistance/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_DRAWDISTANCE;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/DrawDistance").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_DRAWDISTANCE_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/ShadowQuality/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_SHADOWQUALITY;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/ShadowQuality").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_SHADOWQUALITY_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/MotionBlur/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_MOTIONBLUR;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/MotionBlur").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_MOTIONBLUR_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/CarDents/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_CARDENTS;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/CarDents").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_CARDENTS_DESCRIPTION);
                GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Detailed Lighting/NameLabel").GetComponent<UILabel>().text = Language.OPTIONS_GRAPHICS_DETAILEDLIGHTING;
                MenuDesc = GameObject.Find("OptionsFrontRoot/Panel - Options/Panel - Graphics/Anchor - Center/AdvancedCategory/Detailed Lighting").GetComponent<SetMenuDescriptionOnHover>();
                MenuDesc.SetText(Language.OPTIONS_GRAPHICS_DETAILEDLIGHTING_DESCRIPTION);

                CanRun = false;
            }
        }
    }
}