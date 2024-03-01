using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerInteract")]
    public class PlayerInteractClass
    {
        public PlayerInteract playerInteract { get; private set; }
        public PlayerInteractClass(PlayerInteract c_PlayerInteract) => playerInteract = c_PlayerInteract;

        [ScriptProperty("interactable")]
        public static InteractableClass Interactable => new InteractableClass(PlayerInteract.interactable);

        [ScriptProperty("interactable2")]
        public static Interactable2Class Interactable2 => new Interactable2Class(PlayerInteract.interactable2);

        [ScriptFunction("sendSalvageTimeOverride")]
        public void SendSalvageTimeOverride(float overrideValue) => playerInteract.sendSalvageTimeOverride(overrideValue);
    }
}
