using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("uPlayer")]
    public class uPlayerClass
    {
        public Player player { get; private set; }
        public uPlayerClass(Player c_Player) => player = c_Player;

        [ScriptProperty("first")]
        public TransformClass First => new TransformClass(player.first);

        [ScriptProperty("third")]
        public TransformClass Third => new TransformClass(player.third);

        [ScriptProperty("maxRateLimitedActionsPerSecond")]
        public uint MaxRateLimitedActionsPerSecond => player.maxRateLimitedActionsPerSecond;

        [ScriptProperty("agro")]
        public int Agro => player.agro;

        [ScriptProperty("wantsBattlEyeLogs")]
        public bool WantsBattlEyeLogs => player.wantsBattlEyeLogs;

        [ScriptProperty("isSpotOn")]
        public bool IsSpotOn => player.isSpotOn;

        [ScriptProperty("inPluginModal")]
        public bool InPluginModal => player.inPluginModal;

        [ScriptProperty("pluginWidgetFlags")]
        public string PluginWidgetFlags => player.pluginWidgetFlags.ToString();

        [ScriptProperty("AdminUsageFlags")]
        public string AdminUsageFlags => player.AdminUsageFlags.ToString();

        [ScriptProperty("character")]
        public TransformClass Character => new TransformClass(player.character);

        [ScriptProperty("rateLimitedActionsCredits")]
        public float RateLimitedActionsCredits => player.rateLimitedActionsCredits;

        [ScriptProperty("life")]
        public PlayerLifeClass Life => new PlayerLifeClass(player.life);

        [ScriptProperty("clothing")]
        public PlayerClothingClass Clothing => new PlayerClothingClass(player.clothing);

        [ScriptProperty("inventory")]
        public PlayerInventoryClass Inventory => new PlayerInventoryClass(player.inventory);

        [ScriptProperty("equipment")]
        public PlayerEquipmentClass Equipment => new PlayerEquipmentClass(player.equipment);

        [ScriptProperty("crafting")]
        public PlayerCraftingClass Crafting => new PlayerCraftingClass(player.crafting);

        [ScriptProperty("skills")]
        public PlayerSkillsClass Skills => new PlayerSkillsClass(player.skills);

        [ScriptProperty("movement")]
        public PlayerMovementClass Movement => new PlayerMovementClass(player.movement);

        [ScriptProperty("look")]
        public PlayerLookClass Look => new PlayerLookClass(player.look);

        [ScriptProperty("stance")]
        public PlayerStanceClass Stance => new PlayerStanceClass(player.stance);

        [ScriptProperty("input")]
        public PlayerInputClass Input => new PlayerInputClass(player.input);

        [ScriptProperty("voice")]
        public PlayerVoiceClass Voice => new PlayerVoiceClass(player.voice);

        [ScriptProperty("interact")]
        public PlayerInteractClass Interact => new PlayerInteractClass(player.interact);

        [ScriptProperty("animator")]
        public PlayerAnimatorClass Animator => new PlayerAnimatorClass(player.animator);

        [ScriptProperty("workzone")]
        public PlayerWorkzoneClass Workzone => new PlayerWorkzoneClass(player.workzone);

        [ScriptProperty("quests")]
        public PlayerQuestsClass Quests => new PlayerQuestsClass(player.quests);

        [ScriptFunction("adjustStanceOrTeleportIfStuck")]
        public bool AdjustStanceOrTeleportIfStuck()
        {
            return player.adjustStanceOrTeleportIfStuck();
        }

        [ScriptFunction("isPluginWidgetFlagActive")]
        public bool IsPluginWidgetFlagActive(string flag)
        {
            EPluginWidgetFlags? pluginWidgetFlag = EnumTool.pluginWidgetFlags.GetEnum(flag);
            if (pluginWidgetFlag == null) return false;
            return player.isPluginWidgetFlagActive(pluginWidgetFlag.Value);
        }

        [ScriptFunction("teleportToBed")]
        public bool TeleportToBed()
        {
            return player.teleportToBed();
        }

        [ScriptFunction("teleportToLocation")]
        public bool TeleportToLocation(Vector3Class position, float yaw)
        {
            return player.teleportToLocation(position.Vector3, yaw);
        }

        [ScriptFunction("teleportToPlayer")]
        public bool TeleportToPlayer(PlayerClass otherPlayer)
        {
            return player.teleportToPlayer(otherPlayer.Player);
        }

        [ScriptFunction("teleportToRandomSpawnPoint")]
        public bool TeleportToRandomSpawnPoint()
        {
            return player.teleportToRandomSpawnPoint();
        }

        [ScriptFunction("disableHeadlamp")]
        public void DisableHeadlamp()
        {
            player.disableHeadlamp();
        }

        [ScriptFunction("disableItemSpotLight")]
        public void DisableItemSpotLight()
        {
            player.disableItemSpotLight();
        }

        [ScriptFunction("disablePluginWidgetFlag")]
        public void DisablePluginWidgetFlag(string flag)
        {
            EPluginWidgetFlags? pluginWidgetFlag = EnumTool.pluginWidgetFlags.GetEnum(flag);
            if (pluginWidgetFlag == null) return;
            player.disablePluginWidgetFlag(pluginWidgetFlag.Value);
        }

        [ScriptFunction("enablePluginWidgetFlag")]
        public void EnablePluginWidgetFlag(string flag)
        {
            EPluginWidgetFlags? pluginWidgetFlag = EnumTool.pluginWidgetFlags.GetEnum(flag);
            if (pluginWidgetFlag == null) return;
            player.enablePluginWidgetFlag(pluginWidgetFlag.Value);
        }

        [ScriptFunction("save")]
        public void Save()
        {
            player.save();
        }

        [ScriptFunction("sendAchievementUnlocked")]
        public void SendAchievementUnlocked(string id)
        {
            player.sendAchievementUnlocked(id);
        }

        [ScriptFunction("sendBrowserRequest")]
        public void SendBrowserRequest(string msg, string url)
        {
            player.sendBrowserRequest(msg, url);
        }

        [ScriptFunction("sendMessage")]
        public void SendMessage(string playerMessage)
        {
            EPlayerMessage? player_Message = EnumTool.playerMessages.GetEnum(playerMessage);
            if (player_Message == null) return;
            player.sendMessage(player_Message.Value);
        }

        [ScriptFunction("sendRelayToServer")]
        public void SendRelayToServer(uint ip, ushort port, string password, bool shouldShowMenu = true)
        {
            player.sendRelayToServer(ip, port, password, shouldShowMenu);
        }

        [ScriptFunction("sendRelayToServer")]
        public void SendRelayToServer(uint ip, ushort port, string password)
        {
            player.sendRelayToServer(ip, port, password);
        }

        [ScriptFunction("sendKillStat")]
        public void SendKillStat(string kill)
        {
            EPlayerKill? playerKill = EnumTool.playerKills.GetEnum(kill);
            if (playerKill == null) return;
            player.sendStat(playerKill.Value);
        }

        [ScriptFunction("sendPlayerStat")]
        public void SendPlayerStat(string stat)
        {
            EPlayerStat? playerStat = EnumTool.playerStats.GetEnum(stat);
            if (playerStat == null) return;
            player.sendStat(playerStat.Value);
        }

        [ScriptFunction("sendTeleport")]
        public void SendTeleport(Vector3Class position, byte angle)
        {
            player.sendTeleport(position.Vector3, angle);
        }

        [ScriptFunction("sendTerminalRelay")]
        public void SendTerminalRelay(string internalMessage)
        {
            player.sendTerminalRelay(internalMessage);
        }

        [ScriptFunction("ServerShowHint")]
        public void ServerShowHint(string message, float durationSeconds)
        {
            player.ServerShowHint(message, durationSeconds);
        }

        [ScriptFunction("setAllPluginWidgetFlags")]
        public void SetAllPluginWidgetFlags(string newFlags)
        {
            EPluginWidgetFlags? pluginWidgetFlag = EnumTool.pluginWidgetFlags.GetEnum(newFlags);
            if (pluginWidgetFlag == null) return;
            player.setAllPluginWidgetFlags(pluginWidgetFlag.Value);
        }

        [ScriptFunction("setPluginWidgetFlag")]
        public void SetPluginWidgetFlag(string flag, bool active)
        {
            EPluginWidgetFlags? pluginWidgetFlag = EnumTool.pluginWidgetFlags.GetEnum(flag);
            if (pluginWidgetFlag == null) return;
            player.setPluginWidgetFlag(pluginWidgetFlag.Value, active);
        }

        [ScriptFunction("teleportToLocationUnsafe")]
        public void TeleportToLocationUnsafe(Vector3Class position, float yaw)
        {
            player.teleportToLocationUnsafe(position.Vector3, yaw);
        }

        [ScriptFunction("updateGlassesLights")]
        public void UpdateGlassesLights(bool on)
        {
            player.updateGlassesLights(on);
        }
    }
}