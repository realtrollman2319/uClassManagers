using SDG.Unturned;
using System.Collections.Generic;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerInventory")]
    public class PlayerInventoryClass
    {
        public PlayerInventory playerInventory { get; private set; }
        public PlayerInventoryClass(PlayerInventory c_PlayerInventory) => playerInventory = c_PlayerInventory;

        [ScriptProperty("LOADOUT")]
        public static ExpressionValue LOADOUT => UnsignedShortTool.FromVectorArray(PlayerInventory.LOADOUT);

        [ScriptProperty("HORDE")]
        public static ExpressionValue HORDE => UnsignedShortTool.FromVectorArray(PlayerInventory.HORDE);

        [ScriptProperty("SKILLSETS_SERVER")]
        public static ExpressionValue SKILLSETS_SERVER => UnsignedShortTool.FromMatrixArray(PlayerInventory.SKILLSETS_SERVER);

        [ScriptProperty("SKILLSETS_CLIENT")]
        public static ExpressionValue SKILLSETS_CLIENT => UnsignedShortTool.FromMatrixArray(PlayerInventory.SKILLSETS_CLIENT);

        [ScriptProperty("SKILLSETS_HERO")]
        public static ExpressionValue SKILLSETS_HERO => UnsignedShortTool.FromMatrixArray(PlayerInventory.SKILLSETS_HERO);

        [ScriptProperty("loadout")]
        public static ExpressionValue Loadout => UnsignedShortTool.FromVectorArray(PlayerInventory.loadout);

        [ScriptProperty("skillsets")]
        public static ExpressionValue Skillsets => UnsignedShortTool.FromMatrixArray(PlayerInventory.skillsets);

        [ScriptProperty("SAVEDATA_VERSION")]
        public byte SAVEDATA_VERSION => PlayerInventory.SAVEDATA_VERSION;

        [ScriptProperty("SLOTS")]
        public byte SLOTS => PlayerInventory.SLOTS;

        [ScriptProperty("PAGES")]
        public byte PAGES => PlayerInventory.PAGES;

        [ScriptProperty("BACKPACK")]
        public byte BACKPACK => PlayerInventory.BACKPACK;

        [ScriptProperty("VEST")]
        public byte VEST => PlayerInventory.VEST;

        [ScriptProperty("SHIRT")]
        public byte SHIRT => PlayerInventory.SHIRT;

        [ScriptProperty("PANTS")]
        public byte PANTS => PlayerInventory.PANTS;

        [ScriptProperty("STORAGE")]
        public byte STORAGE => PlayerInventory.STORAGE;

        [ScriptProperty("AREA")]
        public byte AREA => PlayerInventory.AREA;

        [ScriptProperty("isStoring")]
        public bool IsStoring => playerInventory.isStoring;

        [ScriptProperty("isStorageTrunk")]
        public bool IsStorageTrunk => playerInventory.isStorageTrunk;

        [ScriptProperty("shouldInventoryStopGestureCloseStorage")]
        public bool ShouldInventoryStopGestureCloseStorage => playerInventory.shouldInventoryStopGestureCloseStorage;

        [ScriptProperty("items")]
        public ExpressionValue Items
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (Items item in playerInventory.items)
                {
                    list.Add(ExpressionValue.CreateObject(new ItemsClass(item)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptProperty("shouldInteractCloseStorage")]
        public bool ShouldInteractCloseStorage => playerInventory.shouldInteractCloseStorage;

        [ScriptProperty("shouldStorageOpenDashboard")]
        public bool ShouldStorageOpenDashboard => playerInventory.shouldStorageOpenDashboard;

        [ScriptFunction("checkSpaceDrag")]
        public bool CheckSpaceDrag(byte page, byte old_x, byte old_y, byte oldRot, byte new_x, byte new_y, byte newRot, byte size_x, byte size_y, bool checkSame)
        {
            return playerInventory.checkSpaceDrag(page, old_x, old_y, oldRot, new_x, new_y, newRot, size_x, size_y, checkSame);
        }

        [ScriptFunction("checkSpaceEmpty")]
        public bool CheckSpaceEmpty(byte page, byte x, byte y, byte size_x, byte size_y, byte rot)
        {
            return playerInventory.checkSpaceEmpty(page, x, y, size_x, size_y, rot);
        }

        [ScriptFunction("checkSpaceSwap")]
        public bool CheckSpaceSwap(byte page, byte x, byte y, byte oldSize_X, byte oldSize_Y, byte oldRot, byte newSize_X, byte newSize_Y, byte newRot)
        {
            return playerInventory.checkSpaceSwap(page, x, y, oldSize_X, oldSize_Y, oldRot, newSize_X, newSize_Y, newRot);
        }

        [ScriptFunction("closeDistantStorage")]
        public void CloseDistantStorage()
        {
            playerInventory.closeDistantStorage();
        }

        [ScriptFunction("closeStorage")]
        public void CloseStorage()
        {
            playerInventory.closeStorage();
        }

        [ScriptFunction("closeStorageAndNotifyClient")]
        public void CloseStorageAndNotifyClient()
        {
            playerInventory.closeStorageAndNotifyClient();
        }

        [ScriptFunction("closeTrunk")]
        public void CloseTrunk()
        {
            playerInventory.closeTrunk();
        }

        [ScriptFunction("doesSearchNeedRefresh")]
        public bool DoesSearchNeedRefresh(int index)
        {
            return playerInventory.doesSearchNeedRefresh(ref index);
        }

        [ScriptFunction("findIndex")]
        public ExpressionValue FindIndex(byte page, byte x, byte y)
        {
            byte index = playerInventory.findIndex(page, x, y, out byte find_x, out byte find_y);
            List<ExpressionValue> list = new List<ExpressionValue>() { index, find_x, find_y };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("forceAddItem")]
        public void ForceAddItem(uItemClass item, bool auto, bool playEffect)
        {
            playerInventory.forceAddItem(item.item, auto, playEffect);
        }

        [ScriptFunction("forceAddItem")]
        public void ForceAddItem(uItemClass item, bool auto)
        {
            playerInventory.forceAddItem(item.item, auto);
        }

        [ScriptFunction("forceAddItemAuto")]
        public void ForceAddItemAuto(uItemClass item, bool autoEquipWeapon, bool autoEquipUseable, bool autoEquipClothing, bool playEffect)
        {
            playerInventory.forceAddItemAuto(item.item, autoEquipWeapon, autoEquipUseable, autoEquipClothing, playEffect);
        }

        [ScriptFunction("forceAddItemAuto")]
        public void ForceAddItemAuto(uItemClass item, bool autoEquipWeapon, bool autoEquipUseable, bool autoEquipClothing)
        {
            playerInventory.forceAddItemAuto(item.item, autoEquipWeapon, autoEquipUseable, autoEquipClothing);
        }

        [ScriptFunction("getHeight")]
        public byte GetHeight(byte page)
        {
            return playerInventory.getHeight(page);
        }

        [ScriptFunction("getIndex")]
        public byte GetIndex(byte page, byte x, byte y)
        {
            return playerInventory.getIndex(page, x, y);
        }

        [ScriptFunction("getItem")]
        public ItemJarClass GetItem(byte page, byte index)
        {
            return new ItemJarClass(playerInventory.getItem(page, index));
        }

        [ScriptFunction("getItemCount")]
        public byte GetItemCount(byte page)
        {
            return playerInventory.getItemCount(page);
        }

        [ScriptFunction("getWidth")]
        public byte GetWidth(byte page)
        {
            return playerInventory.getWidth(page);
        }

        [ScriptFunction("load")]
        public void Load()
        {
            playerInventory.load();
        }

        [ScriptFunction("openStorage")]
        public void OpenStorage(InteractableStorageClass newStorage)
        {
            playerInventory.openStorage(newStorage.interactableStorage);
        }

        [ScriptFunction("openTrunk")]
        public void OpenTrunk(ItemsClass trunkItems)
        {
            playerInventory.openTrunk(trunkItems.itemsClass);
        }

        [ScriptFunction("removeItem")]
        public void RemoveItem(byte page, byte index)
        {
            playerInventory.removeItem(page, index);
        }

        [ScriptFunction("replaceItems")]
        public void ReplaceItems(byte page, ItemsClass replacement)
        {
            playerInventory.replaceItems(page, replacement.itemsClass);
        }

        [ScriptFunction("save")]
        public void Save()
        {
            playerInventory.save();
        }

        [ScriptFunction("sendDragItem")]
        public void SendDragItem(byte page_0, byte x_0, byte y_0, byte page_1, byte x_1, byte y_1, byte rot_1)
        {
            playerInventory.sendDragItem(page_0, x_0, y_0, page_1, x_1, y_1, rot_1);
        }

        [ScriptFunction("sendDropItem")]
        public void SendDropItem(byte page, byte x, byte y)
        {
            playerInventory.sendDropItem(page, x, y);
        }

        [ScriptFunction("sendStorage")]
        public void SendStorage()
        {
            playerInventory.sendStorage();
        }

        [ScriptFunction("sendSwapItem")]
        public void SendSwapItem(byte page_0, byte x_0, byte y_0, byte rot_0, byte page_1, byte x_1, byte y_1, byte rot_1)
        {
            playerInventory.sendSwapItem(page_0, x_0, y_0, rot_0, page_1, x_1, y_1, rot_1);
        }

        [ScriptFunction("sendUpdateAmount")]
        public void SendUpdateAmount(byte page, byte x, byte y, byte amount)
        {
            playerInventory.sendUpdateAmount(page, x, y, amount);
        }

        [ScriptFunction("sendUpdateInvState")]
        public void SendUpdateInvState(byte page, byte x, byte y, ExpressionValue state)
        {
            playerInventory.sendUpdateInvState(page, x, y, ByteTool.FromExpressionValue(state));
        }

        [ScriptFunction("sendUpdateQuality")]
        public void SendUpdateQuality(byte page, byte x, byte y, byte quality)
        {
            playerInventory.sendUpdateQuality(page, x, y, quality);
        }

        [ScriptFunction("tryAddItem")]
        public bool TryAddItem(uItemClass item, bool auto, bool playEffect)
        {
            return playerInventory.tryAddItem(item.item, auto, playEffect);
        }

        [ScriptFunction("tryAddItem")]
        public bool TryAddItem(uItemClass item, byte x, byte y, byte page, byte rot)
        {
            return playerInventory.tryAddItem(item.item, x, y, page, rot);
        }

        [ScriptFunction("tryAddItem")]
        public bool TryAddItem(uItemClass item, bool auto)
        {
            return playerInventory.tryAddItem(item.item, auto);
        }

        [ScriptFunction("tryAddItemAuto")]
        public bool TryAddItemAuto(uItemClass item, bool autoEquipWeapon, bool autoEquipUseable, bool autoEquipClothing, bool playEffect)
        {
            return playerInventory.tryAddItemAuto(item.item, autoEquipWeapon, autoEquipUseable, autoEquipClothing, playEffect);
        }

        [ScriptFunction("tryFindSpace")]
        public ExpressionValue TryFindSpace(byte size_x, byte size_y)
        {
            bool hasFoundSpace = playerInventory.tryFindSpace(size_x, size_y, out byte outPage, out byte outX, out byte outY, out byte outRot);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasFoundSpace, outPage, outX, outY, outRot };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("tryFindSpace")]
        public ExpressionValue TryFindSpace(byte page, byte size_x, byte size_y)
        {
            bool hasFoundSpace = playerInventory.tryFindSpace(page, size_x, size_y, out byte x, out byte y, out byte rot);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasFoundSpace, x, y, rot };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("updateAmount")]
        public void UpdateAmount(byte page, byte index, byte newAmount)
        {
            playerInventory.updateAmount(page, index, newAmount);
        }

        [ScriptFunction("updateItems")]
        public void UpdateItems(byte page, ItemsClass newItems)
        {
            playerInventory.updateItems(page, newItems.itemsClass);
        }

        [ScriptFunction("updateQuality")]
        public void UpdateQuality(byte page, byte index, byte newQuality)
        {
            playerInventory.updateQuality(page, index, newQuality);
        }

        [ScriptFunction("updateState")]
        public void UpdateState(byte page, byte index, ExpressionValue newState)
        {
            playerInventory.updateState(page, index, ByteTool.FromExpressionValue(newState));
        }
    }
}
