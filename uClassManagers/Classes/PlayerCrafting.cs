using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerCrafting")]
    public class PlayerCraftingClass
    {
        public PlayerCrafting playerCrafting { get; private set; }
        public PlayerCraftingClass(PlayerCrafting c_PlayerCrafting) => playerCrafting = c_PlayerCrafting;

        [ScriptFunction("removeItem")]
        public void RemoveItem(byte page, ItemJarClass jar)
        {
            playerCrafting.removeItem(page, jar.itemJar);
        }

        [ScriptFunction("sendCraft")]
        public void SendCraft(ushort id, byte index, bool force)
        {
            playerCrafting.sendCraft(id, index, force);
        }

        [ScriptFunction("sendStripAttachments")]
        public void SendStripAttachments(byte page, byte x, byte y)
        {
            playerCrafting.sendStripAttachments(page, x, y);
        }

        [ScriptFunction("ServerRefreshOwnerCrafting")]
        public void ServerRefreshOwnerCrafting()
        {
            playerCrafting.ServerRefreshOwnerCrafting();
        }
    }
}