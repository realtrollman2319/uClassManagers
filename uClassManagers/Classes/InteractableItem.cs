using SDG.Unturned;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("InteractableItem")]
    public class InteractableItemClass
    {
        public InteractableItem interactableItem { get; private set; }
        public InteractableItemClass(InteractableItem c_InteractableItem) => interactableItem = c_InteractableItem;

        [ScriptProperty("item")]
        public uItemClass Item => new uItemClass(interactableItem.item);

        [ScriptProperty("jar")]
        public ItemJarClass Jar => new ItemJarClass(interactableItem.jar);

        [ScriptProperty("asset")]
        public ItemAssetClass asset => new ItemAssetClass(interactableItem.asset);

        [ScriptFunction("clampRange")]
        public void ClampRange() => interactableItem.clampRange();

        [ScriptFunction("use")]
        public void Use() => interactableItem.use();
    }
}