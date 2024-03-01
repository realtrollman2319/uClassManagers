using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Managers
{
    [ScriptModule("ClaimManager")]
    public class ClaimManagerClass
    {
        [ScriptFunction("canBuildOnVehicle")]
        public static bool CanBuildOnVehicle(VehicleClass vehicle, PlayerClass player)
        {
            return ClaimManager.canBuildOnVehicle(vehicle.Vehicle.transform, player.Player.channel.owner.playerID.steamID, player.Player.quests.groupID);
        }

        [ScriptFunction("checkCanBuild")]
        public static bool CheckCanBuild(Vector3Class vehicle, PlayerClass player, bool isClaim)
        {
            return ClaimManager.checkCanBuild(vehicle.Vector3, player.Player.channel.owner.playerID.steamID, player.Player.quests.groupID, isClaim);
        }
    }
}
