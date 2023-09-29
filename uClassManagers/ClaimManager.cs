using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers
{
    [ScriptModule("ClaimManager")]
    public class ClaimManagerClass
    {
        [ScriptFunction("canBuildOnVehicle")]
        public static bool CanBuildOnVehicle(VehicleClass vehicle, PlayerClass player)
        {
            bool canBuild = ClaimManager.canBuildOnVehicle(vehicle.Vehicle.transform, player.Player.channel.owner.playerID.steamID, player.Player.quests.groupID);
            return canBuild;
        }

        [ScriptFunction("checkCanBuild")]
        public static bool CheckCanBuild(Vector3Class vehicle, PlayerClass player, bool isClaim)
        {
            bool canBuild = ClaimManager.checkCanBuild(vehicle.Vector3, player.Player.channel.owner.playerID.steamID, player.Player.quests.groupID, isClaim);
            return canBuild;
        }
    }
}
