using SDG.Unturned;
using System.Collections.Generic;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("Interactable")]
    public class InteractableClass
    {
        public Interactable interactable { get; private set; }
        public InteractableClass(Interactable c_Interactable) => interactable = c_Interactable;

        [ScriptProperty("isChildOfVehicle")]
        public bool IsChildOfVehicle => interactable.IsChildOfVehicle;

        [ScriptFunction("checkHighlight")]
        public string CheckHighlight()
        {
            interactable.checkHighlight(out Color color);
            return ColorUtility.ToHtmlStringRGB(color);
        }

        [ScriptFunction("checkHint")]
        public ExpressionValue CheckHint()
        {
            bool hasChecked = interactable.checkHint(out EPlayerMessage message, out string text, out Color color);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasChecked, message.ToString(), text, ColorUtility.ToHtmlStringRGB(color) };
            return ExpressionValue.Array(list);
        }

        [ScriptFunction("checkInteractable")]
        public bool CheckInteractable() => interactable.checkInteractable();

        [ScriptFunction("checkUseable")]
        public bool CheckUseable() => interactable.checkUseable();

        [ScriptFunction("use")]
        public void Use() => interactable.use();
    }
}
