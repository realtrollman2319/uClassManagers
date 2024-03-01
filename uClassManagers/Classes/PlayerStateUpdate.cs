using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerStateUpdate")]
    public class PlayerStateUpdateClass
    {
        public PlayerStateUpdate playerStateUpdate { get; private set; }
        public PlayerStateUpdateClass(PlayerStateUpdate c_PlayerStateUpdate) => playerStateUpdate = c_PlayerStateUpdate;

        [ScriptProperty("pos")]
        public Vector3Class Pos => new Vector3Class(playerStateUpdate.pos);

        [ScriptProperty("angle")]
        public byte Angle => playerStateUpdate.angle;

        [ScriptProperty("rot")]
        public byte Rot => playerStateUpdate.rot;
    }
}
