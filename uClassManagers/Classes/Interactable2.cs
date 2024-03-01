using SDG.Unturned;
using System.Collections.Generic;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("Interactable2Class")]
    public class Interactable2Class
    {
        public Interactable2 interactable2 { get; private set; }
        public Interactable2Class(Interactable2 c_Interactable2) => interactable2 = c_Interactable2;

        [ScriptProperty("owner")]
        public string  Owner => interactable2.owner.ToString();

        [ScriptProperty("group")]
        public string Group => interactable2.group.ToString();

        [ScriptProperty("salvageDurationMultiplier")]
        public float SalvageDurationMultiplier => interactable2.salvageDurationMultiplier;

        [ScriptProperty("hasOwnership")]
        public bool HasOwnership => interactable2.hasOwnership;

        [ScriptFunction("isPlant")]
        public ExpressionValue CheckHint()
        {
            bool hasChecked = interactable2.checkHint(out EPlayerMessage message, out float data);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasChecked, message.ToString(), data };
            return ExpressionValue.Array(list);
        }

        [ScriptFunction("use")]
        public void use() => interactable2.use();
    }
}
