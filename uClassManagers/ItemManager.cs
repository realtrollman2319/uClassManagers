using SDG.Unturned;
using System.Collections.Generic;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers
{
    [ScriptModule("ItemManager")]
    public static class ItemManagerClass
    {
        [ScriptFunction("askClearAllItems")]
        public static void AskClearAllItems()
        {
            ItemManager.askClearAllItems();
        }

        [ScriptFunction("askClearRegionItems")]
        public static void AskClearRegionItems(byte x, byte y)
        {
            ItemManager.askClearRegionItems(x, y);
        }

        [ScriptFunction("dropItem")]
        public static void DropItem(ItemClass item, Vector3Class point, bool playEffect = true, bool wideSpread = false, bool isDropped = true) // Note this does not remove the player's item inside his inventory.
        {
            ItemManager.dropItem(item.Item.item, point.Vector3, playEffect, isDropped, wideSpread);
        }

        [ScriptFunction("findSimulatedItemsInRadius")]
        public static ExpressionValue FindSimulatedItemsInRadius(Vector3Class center, float radius)
        {
            List<InteractableItem> iList = new List<InteractableItem>();
            ItemManager.findSimulatedItemsInRadius(center.Vector3, radius, iList);
            if (iList.Count <= 0) return ExpressionValue.Null;

            List<ExpressionValue> EVList = new List<ExpressionValue>();

            foreach (InteractableItem i in iList)
            {
                EVList.Add(ExpressionValue.CreateObject(new ItemClass(i.jar)));
            }
            return ExpressionValue.Array(EVList.ToArray());
        }

        [ScriptFunction("ServerClearItemsInSphere")]
        public static void ServerClearItemsInSphere(Vector3Class center, float radius)
        {
            ItemManager.ServerClearItemsInSphere(center.Vector3, radius);
        }
    }
}
