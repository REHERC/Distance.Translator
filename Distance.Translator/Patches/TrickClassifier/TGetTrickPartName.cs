using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(TrickClassifier), "GetTrickPartName", new Type[] { typeof(TrickSystem.RotationTrickParts)})]
        internal partial class TrickClassifier_GetTrickPartName_RotationTrickParts_Patch
        {
            static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var codes = new List<CodeInstruction>(instructions);
                for (int i = 0; i < codes.Count; i++)
                {
                    if (codes[i].opcode == OpCodes.Ldstr)
                    {
                        switch(codes[i].operand.ToString()) {
                            case "Freestyle":
                                codes[i].operand = Language.TRICK_FREESTYLE;
                                break;
                            case "Barrel Roll":
                                codes[i].operand = Language.TRICK_BARRELROLL;
                                break;
                            case "Back Flip":
                                codes[i].operand = Language.TRICK_BACKFLIP;
                                break;
                            case "Front Flip":
                                codes[i].operand = Language.TRICK_FRONTFLIP;
                                break;
                            case "Back Twist":
                                codes[i].operand = Language.TRICK_BACKTWIST;
                                break;
                            case "Front Twist":
                                codes[i].operand = Language.TRICK_FRONTTWIST;
                                break;
                            case "Frisbee":
                                codes[i].operand = Language.TRICK_FRISBEE;
                                break;
                        }
                    }
                }
                return codes.AsEnumerable();
            }
        }

        [HarmonyPatch(typeof(TrickClassifier), "GetTrickPartName", new Type[] { typeof(TrickSystem.RideTrickParts) })]
         internal partial class TrickClassifier_GetTrickPartName_RideTrickParts_Patch
        {
            static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var codes = new List<CodeInstruction>(instructions);
                for (int i = 0; i < codes.Count; i++)
                {
                    if (codes[i].opcode == OpCodes.Ldstr)
                    {
                        switch (codes[i].operand.ToString())
                        {
                            case "Freestyle":
                                codes[i].operand = Language.TRICK_FREESTYLE;
                                break;
                            case "Wall Ride":
                                codes[i].operand = Language.TRICK_WALLRIDE;
                                break;
                            case "Ceiling Ride":
                                codes[i].operand = Language.TRICK_CEILINGRIDE;
                                break;
                            case "Grind":
                                codes[i].operand = Language.TRICK_GRIND;
                                break;
                            case "Wheelie":
                                codes[i].operand = Language.TRICK_WHEELIE;
                                break;
                            case "Side Wheelie":
                                codes[i].operand = Language.TRICK_SIDEWHEELIE;
                                break;
                        }
                    }
                }
                return codes.AsEnumerable();
            }
        }

        [HarmonyPatch(typeof(TrickClassifier), "GetTrickPartName", new Type[] { typeof(TrickSystem.HoldTrickParts) })]
        internal partial class TrickClassifier_GetTrickPartName_HoldTrickParts_Patch
        {
            static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var codes = new List<CodeInstruction>(instructions);
                for (int i = 0; i < codes.Count; i++)
                {
                    if (codes[i].opcode == OpCodes.Ldstr)
                    {
                        switch (codes[i].operand.ToString())
                        {
                            case "Freestyle":
                                codes[i].operand = Language.TRICK_FREESTYLE;
                                break;
                            case "Nose Stand":
                                codes[i].operand = Language.TRICK_NOSESTAND;
                                break;
                        }
                    }
                }
                return codes.AsEnumerable();
            }
        }
    }
}