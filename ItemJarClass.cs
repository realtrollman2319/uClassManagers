using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uScript.API.Attributes;

namespace uClassManagers
{
    [ScriptClass("ItemJar")]
    public class ItemJarClass
    {
        public ItemJar itemJar { get; private set; }
        public ItemJarClass(ItemJar c_itemJar) => itemJar = c_itemJar;

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

        // TODO: ItemAssetClass, ItemClass expansion


        public byte x;
        public byte y;
        public byte rot;
        public byte size_x;
        public byte size_y;
        public InteractableItem interactableItem;

        public ItemJar(Item newItem);
        public ItemJar(byte new_x, byte new_y, byte newRot, Item newItem);

        public Item item { get; }

        public ItemAsset GetAsset();
        public T GetAsset<T>() where T : ItemAsset;
    }
}