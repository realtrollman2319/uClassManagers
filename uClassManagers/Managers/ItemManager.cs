using SDG.Unturned;
using System.Collections.Generic;
using uClassManagers.Classes;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Managers
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
        public static void DropItemClass(ItemClass item, Vector3Class point, bool playEffect = true, bool wideSpread = false, bool isDropped = true) // Note this does not remove the player's item inside his inventory.
        {
            ItemManager.dropItem(item.Item.item, point.Vector3, playEffect, isDropped, wideSpread);
        }

        /*

        [ScriptFunction("dropItem")]
        public static void DropItem(ItemJarClass item, Vector3Class point, bool playEffect = true, bool wideSpread = false, bool isDropped = true) // Note this does not remove the player's item inside his inventory.
        {
            ItemManager.dropItem(item.itemJar.item, point.Vector3, playEffect, isDropped, wideSpread);
        }
        
        // "Methods are hidden by overloads:"
        [ScriptFunction("dropItem")]
        public static void DropItemJar(uItemClass item, Vector3Class point, bool playEffect = true, bool wideSpread = false, bool isDropped = true) // Note this does not remove the player's item inside his inventory.
        {
            ItemManager.dropItem(item.item, point.Vector3, playEffect, isDropped, wideSpread);
        }
        */

        [ScriptFunction("findSimulatedItemsInRadius")]
        public static ExpressionValue FindSimulatedItemsInRadius(Vector3Class center, float sqrRadius)
        {
            List<InteractableItem> iList = new List<InteractableItem>();
            ItemManager.findSimulatedItemsInRadius(center.Vector3, sqrRadius, iList);

            List<ExpressionValue> itemList = new List<ExpressionValue>();
            foreach (InteractableItem i in iList)
            {
                itemList.Add(ExpressionValue.CreateObject(new ItemClass(i.jar)));
            }
            return ExpressionValue.Array(itemList.ToArray());
        }

        [ScriptFunction("ServerClearItemsInSphere")]
        public static void ServerClearItemsInSphere(Vector3Class center, float radius)
        {
            ItemManager.ServerClearItemsInSphere(center.Vector3, radius);
        }
    }
}
