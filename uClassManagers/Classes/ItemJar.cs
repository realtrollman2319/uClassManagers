using SDG.Unturned;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("ItemJar")]
    public class ItemJarClass
    {
        public ItemJar itemJar { get; private set; }
        public ItemJarClass(ItemJar c_ItemJar) => itemJar = c_ItemJar;

        [ScriptConstructor]
        public ItemJarClass(ItemClass newItem) => itemJar = new ItemJar(newItem.Item.item);

        [ScriptConstructor]
        public ItemJarClass(byte new_x, byte new_y, byte newRot, ItemClass newItem) => itemJar = new ItemJar(new_x, new_y, newRot, newItem.Item.item);

        [ScriptProperty("x")]
        public byte X => itemJar.x;

        [ScriptProperty("y")]
        public byte Y => itemJar.y;

        [ScriptProperty("rot")]
        public byte Rot => itemJar.rot;

        [ScriptProperty("size_x")]
        public byte Size_x => itemJar.size_x;

        [ScriptProperty("size_y")]
        public byte Size_y => itemJar.size_y;

        [ScriptProperty("interactableItem")]
        public InteractableItemClass InteractableItem => new InteractableItemClass(itemJar.interactableItem);

        [ScriptProperty("item")]
        public uItemClass Item => new uItemClass(itemJar.item);

        [ScriptFunction("getAsset")]
        public ItemAssetClass GetAsset() => new ItemAssetClass(itemJar.GetAsset());
    }
}