using SDG.Unturned;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("uItem")]
    public class uItemClass
    {
        public Item item { get; private set; }
        public uItemClass(Item c_Item) => item = c_Item;

        [ScriptConstructor]
        public uItemClass(ushort newID, bool full) => item = new Item(newID, full);

        [ScriptConstructor]
        public uItemClass(ItemAssetClass itemAssetClass, string origin)
        {
            EItemOrigin? itemOrigin = EnumTool.itemOrigins.GetEnum(origin);
            if (itemOrigin == null) return;
            item = new Item(itemAssetClass.itemAsset, itemOrigin.Value);
        }

        [ScriptConstructor]
        public uItemClass(ushort newID, string origin)
        {
            EItemOrigin? itemOrigin = EnumTool.itemOrigins.GetEnum(origin);
            if (itemOrigin == null) return;
            item = new Item(newID, itemOrigin.Value);
        }

        [ScriptConstructor]
        public uItemClass(ushort newID, bool full, byte newQuality) => item = new Item(newID, full, newQuality);

        [ScriptConstructor]
        public uItemClass(ushort newID, string origin, byte newQuality)
        {
            EItemOrigin? itemOrigin = EnumTool.itemOrigins.GetEnum(origin);
            if (itemOrigin == null) return;
            item = new Item(newID, itemOrigin.Value, newQuality);
        }

        [ScriptConstructor]
        public uItemClass(ushort newID, byte newAmount, byte newQuality) => item = new Item(newID, newAmount, newQuality);

        [ScriptConstructor]
        public uItemClass(ushort newID, byte newAmount, byte newQuality, ExpressionValue newState)
        {
            item = new Item(newID, newAmount, newQuality, ByteTool.FromExpressionValue(newState));
        }

        [ScriptProperty("amount")]
        public byte Amount => item.amount;

        [ScriptProperty("durability")]
        public byte Durability
        {
            get => item.durability;
            set => item.durability = value;
        }

        [ScriptProperty("metadata")]
        public ExpressionValue Metadata => ByteTool.FromArray(item.metadata); // TODO fix this

        [ScriptFunction("getAsset")]
        public ItemAssetClass GetAsset() => new ItemAssetClass(item.GetAsset());
    }
}