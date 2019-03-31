using static Distance.Translator.Extensions.StringExtensions;
using System.Collections.Generic;

namespace Distance.Translator.Modules
{
    public static partial class ModuleChecks
    {
        public static DynamicTranslateModule General_Units_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "UNITS"))
                return new GeneralUnitsModule();
            return null;
        }

        public static DynamicTranslateModule General_Visualizer_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "CAR SCREEN VISUALIZER"))
                return new GeneralVisualizerModule();
            return null;
        }

        public static DynamicTranslateModule General_CameraSplit_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "SPLIT-SCREEN CAMERA SPLIT"))
                return new GeneralCameraSplitModule();
            return null;
        }

        public static DynamicTranslateModule Replay_GhostType_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "GHOSTS IN ARCADE TYPE"))
                return new ReplayGhostTypeModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_Fullscreen_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "Fullscreen"))
                return new GraphicsFullscreenModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_VSync_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "VSync"))
                return new GraphicsVsyncModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_Letterbox_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "CinematicLetterbox"))
                return new GraphicsLetterboxModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_Bloom_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "Bloom"))
                return new GraphicsBloomModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_FilmGrain_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "FilmGrain"))
                return new GraphicsFilmGrainModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_Vignetting_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "Vignetting"))
                return new GraphicsVignettingModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_RadialBlur_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "RadialBlur"))
                return new GraphicsRadialBlurModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_SunShafts_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "SunShafts"))
                return new GraphicsSunShaftsModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_Reflections_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "RealTimeReflections"))
                return new GraphicsReflectionsModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_Anisotropic_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "AnisotropicFiltering"))
                return new GraphicsAnisotropicModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_Particles_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "Particles"))
                return new GraphicsParticlesModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_TextureQuality_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "TextureQuality"))
                return new GraphicsTextureQualityModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_AntiAliasing_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "AntiAliasing"))
                return new GraphicsAntiAliasingModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_DrawDistance_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "DrawDistance"))
                return new GraphicsDrawDistanceModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_ShadowQuality_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "ShadowQuality"))
                return new GraphicsShadowQualityModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_MotionBlur_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "MotionBlur"))
                return new GraphicsMotionBlurModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_CarDents_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "CarDents"))
                return new GraphicsCarDentsModule();
            return null;
        }

        public static DynamicTranslateModule Graphics_Lighting_DropDown(ref UILabel instance)
        {
            if (DropDown(ref instance, "Detailed Lighting"))
                return new GraphicsLightingModule();
            return null;
        }

        public static DynamicTranslateModule Profile_Edit_Header(ref UILabel instance)
        {
            if (IsParentableTo(Util.GameObjectPath(instance.transform), "OptionsFrontRoot/Panel - Options/Panel - Profiles/Anchor - Center/Panel - EditProfile/EditSelectedProfileLabel"))
                return new ProfileEditHeaderModule();
            return null;
        }

        public static DynamicTranslateModule General_Title(ref UILabel instance)
        {
            if (IsParentableTo(Util.GameObjectPath(instance.transform), GetRoot(new Dictionary<string, string>(){
                {"default", "OptionsFrontRoot(Clone)/Panel - Options/General/MenuTitleTemplate"},
                {"mainmenu", "OptionsFrontRoot/Panel - Options/General/MenuTitleTemplate"},

            }
            )))
            {
                if (instance.transform.name == "UILabel - Title")
                    return new GeneralTitleModule();
            }
            return null;
        }

        public static DynamicTranslateModule Replay_Title(ref UILabel instance)
        {
            if (IsParentableTo(Util.GameObjectPath(instance.transform), GetRoot(new Dictionary<string, string>(){
                {"default", "OptionsFrontRoot(Clone)/Panel - Options/Replay/MenuTitleTemplate"},
                {"mainmenu", "OptionsFrontRoot/Panel - Options/Replay/MenuTitleTemplate"}
            }
            )))
            {
                if (instance.transform.name == "UILabel - Title")
                    return new ReplayTitleModule();
            }
            return null;
        }
    }
}
