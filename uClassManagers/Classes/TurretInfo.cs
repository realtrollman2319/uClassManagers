using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("TurretInfo")]
    public class TurretInfoClass
    {
        public TurretInfo turretInfo { get; private set; }
        public TurretInfoClass(TurretInfo c_TurretInfo) => turretInfo = c_TurretInfo;

        [ScriptProperty("seatIndex")]
        public byte SeatIndex => turretInfo.seatIndex;

        [ScriptProperty("itemID")]
        public ushort ItemID => turretInfo.itemID;

        [ScriptProperty("yawMin")]
        public float YawMin => turretInfo.yawMin;

        [ScriptProperty("yawMax")]
        public float YawMax => turretInfo.yawMax;

        [ScriptProperty("pitchMin")]
        public float PitchMin => turretInfo.pitchMin;

        [ScriptProperty("pitchMax")]
        public float PitchMax => turretInfo.pitchMax;

        [ScriptProperty("useAimCamera")]
        public bool UseAimCamera => turretInfo.useAimCamera;
    }
}
