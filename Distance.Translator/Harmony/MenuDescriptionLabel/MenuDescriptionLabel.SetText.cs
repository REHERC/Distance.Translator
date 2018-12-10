using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Harmony;

namespace Distance.Translator.Harmony
{
    [HarmonyPatch(typeof(MenuDescriptionLabel), "SetText")]
    public class MenuDescriptionLabel__SetText__Patch
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);
            for (int i = 0; i < codes.Count; i++)
            {
                if (codes[i].opcode == OpCodes.Ldstr)
                {
                    if (codes[i].operand.ToString() == "Warning: ")
                    {
                        codes[i].operand = "";
                    }
                }
            }
            return codes.AsEnumerable();
        }
    }
}
