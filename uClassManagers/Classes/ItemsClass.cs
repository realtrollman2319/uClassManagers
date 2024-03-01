using SDG.Unturned;
using System.Collections.Generic;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("Items")]
    public class ItemsClass
    {
        public Items itemsClass { get; private set; }
        public ItemsClass(Items c_Items) => itemsClass = c_Items;

        [ScriptConstructor]
        public ItemsClass(byte newPage) => itemsClass = new Items(newPage);

        [ScriptProperty("width")]
        public byte Width => itemsClass.width;

        [ScriptProperty("page")]
        public byte Page => itemsClass.page;

        [ScriptProperty("height")]
        public byte Height => itemsClass.height;

        [ScriptProperty("items")]
        public ExpressionValue Items
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (ItemJar jar in itemsClass.items)
                {
                    list.Add(ExpressionValue.CreateObject(new ItemJarClass(jar)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptFunction("addItem")]
        public void AddItem(byte x, byte y, byte rot, uItemClass item)
        {
            itemsClass.addItem(x, y, rot, item.item);
        }

        [ScriptFunction("checkSpaceDrag")]
        public bool CheckSpaceDrag(byte old_x, byte old_y, byte oldRot, byte new_x, byte new_y, byte newRot, byte size_x, byte size_y, bool checkSame)
        {
            return itemsClass.checkSpaceDrag(old_x, old_y, oldRot, new_x, new_y, newRot, size_x, size_y, checkSame);
        }

        [ScriptFunction("checkSpaceEmpty")]
        public bool CheckSpaceEmpty(byte pos_x, byte pos_y, byte size_x, byte size_y, byte rot)
        {
            return itemsClass.checkSpaceEmpty(pos_x, pos_y, size_x, size_y, rot);
        }

        [ScriptFunction("checkSpaceSwap")]
        public bool CheckSpaceSwap(byte x, byte y, byte oldSize_X, byte oldSize_Y, byte oldRot, byte newSize_X, byte newSize_Y, byte newRot)
        {
            return itemsClass.checkSpaceSwap(x, y, oldSize_X, oldSize_Y, oldRot, newSize_X, newSize_Y, newRot);
        }

        [ScriptFunction("clear")]
        public void Clear()
        {
            itemsClass.clear();
        }

        [ScriptFunction("containsItem")]
        public bool ContainsItem(ItemJarClass jar)
        {
            return itemsClass.containsItem(jar.itemJar);
        }

        [ScriptFunction("findIndex")]
        public ExpressionValue FindIndex(byte x, byte y)
        {
            byte index = itemsClass.findIndex(x, y, out byte find_x, out byte find_y);
            List<ExpressionValue> list = new List<ExpressionValue>() { index, find_x, find_y };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("getIndex")]
        public byte GetIndex(byte x, byte y)
        {
            return itemsClass.getIndex(x, y);
        }

        [ScriptFunction("getItem")]
        public ItemJarClass GetItem(byte index)
        {
            return new ItemJarClass(itemsClass.getItem(index));
        }

        [ScriptFunction("getItemCount")]
        public byte GetItemCount()
        {
            return itemsClass.getItemCount();
        }

        [ScriptFunction("loadItem")]
        public void LoadItem(byte x, byte y, byte rot, uItemClass item)
        {
            itemsClass.loadItem(x, y, rot, item.item);
        }

        [ScriptFunction("loadSize")]
        public void LoadSize(byte newWidth, byte newHeight)
        {
            itemsClass.loadSize(newWidth, newHeight);
        }

        [ScriptFunction("removeItem")]
        public void RemoveItem(byte index)
        {
            itemsClass.removeItem(index);
        }

        [ScriptFunction("resize")]
        public void Resize(byte newWidth, byte newHeight)
        {
            itemsClass.resize(newWidth, newHeight);
        }

        [ScriptFunction("tryAddItem")]
        public bool TryAddItem(uItemClass item)
        {
            return itemsClass.tryAddItem(item.item);
        }

        [ScriptFunction("tryAddItem")]
        public bool TryAddItem(uItemClass item, bool isStateUpdatable)
        {
            return itemsClass.tryAddItem(item.item, isStateUpdatable);
        }

        [ScriptFunction("tryFindSpace")]
        public bool TryFindSpace(byte size_x, byte size_y)
        {
            bool hasFoundSpace = itemsClass.tryFindSpace(size_x, size_y, out byte x, out byte y, out byte rot);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasFoundSpace, x, y, rot };
            return ExpressionValue.Array(list);
        }

        [ScriptFunction("updateAmount")]
        public void UpdateAmount(byte index, byte newAmount)
        {
            itemsClass.updateAmount(index, newAmount);
        }

        [ScriptFunction("updateQuality")]
        public void UpdateQuality(byte index, byte newQuality)
        {
            itemsClass.updateQuality(index, newQuality);
        }

        [ScriptFunction("updateState")]
        public void UpdateState(byte index, ExpressionValue newState)
        {
            itemsClass.updateState(index, ByteTool.FromExpressionValue(newState));
        }
    }
}