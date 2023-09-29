using SDG.Unturned;
using uClassManagers.uClasses;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClassExtensions
{
    [ScriptTypeExtension(typeof(PlayerClass))]
    public class PlayerClassExtension
    {
        [ScriptFunction("get_transform")]
        public static TransformClass getPlayerTransform([ScriptInstance] ExpressionValue instance)
        {
            return instance.Data is PlayerClass playerClass ? new TransformClass(playerClass.Player.transform) : null;
        }

        [ScriptFunction("sendTeleport")]
        public static void getSendTeleport([ScriptInstance] ExpressionValue instance, Vector3Class position, byte angle)
        {
            if (!(instance.Data is PlayerClass playerClass)) return;
            playerClass.Player.sendTeleport(position.Vector3, angle);
        }

        [ScriptFunction("dropAllItems")]
        public static void DropItem([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is PlayerClass playerClass)) return;
            Player player = playerClass.Player;
            for (byte index = 0; index < PlayerInventory.SLOTS; ++index)
            {
                ItemJar itemJar = player.inventory.getItem(index, 0);
                if (itemJar != null)
                {
                    ItemManager.dropItem(itemJar.item, playerClass.Position.Vector3, false, false, true);
                    player.inventory.removeItem(index, 0);
                    player.equipment.sendSlot(index);
                }
            }
            for (byte slots = PlayerInventory.SLOTS; slots < PlayerInventory.PAGES - 2; ++slots)
            {
                for (int index = player.inventory.getItemCount(slots) - 1; index >= 0; --index)
                {
                    ItemJar itemJar = player.inventory.getItem(slots, (byte)index);
                    if (itemJar != null)
                    {
                        ItemManager.dropItem(itemJar.item, playerClass.Position.Vector3, false, false, true);
                        player.inventory.removeItem(slots, (byte)index);
                    }
                }
            }
        }
    }
}
