using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Harmony;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(MenuDescriptionLabel), "SetText")]
        internal partial class MenuDescriptionLabel_SetText_Patch
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
                            case "Warning: ":
                                codes[i].operand = Language.WARNING_PREFIX;
                                break;
                        }
                    }
                }
                return codes.AsEnumerable();
            }
        }
    }
}