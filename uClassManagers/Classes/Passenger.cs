using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("Passenger")]
    public class PassengerClass
    {
        public Passenger passenger { get; private set; }
        public PassengerClass(Passenger c_Passenger) => passenger = c_Passenger;

        [ScriptConstructor]
        public PassengerClass(TransformClass newSeat, TransformClass newObj, TransformClass newTurretYaw, TransformClass newTurretPitch, TransformClass newTurretAim)
        {
            passenger = new Passenger(newSeat.transform, newObj.transform, newTurretYaw.transform, newTurretPitch.transform, newTurretAim.transform);
        }

        [ScriptProperty("player")]
        public PlayerClass Player => new PlayerClass(passenger.player.player);

        [ScriptProperty("turret")]
        public TurretInfoClass Turret => new TurretInfoClass(passenger.turret);

        [ScriptProperty("state")]
        public ExpressionValue State => ByteTool.FromArray(passenger.state);

        [ScriptProperty("seat")]
        public TransformClass Seat => new TransformClass(passenger.seat);

        [ScriptProperty("obj")]
        public TransformClass Obj => new TransformClass(passenger.obj);

        [ScriptProperty("rotationYaw")]
        public Vector3Class RotationYaw => new Vector3Class(passenger.rotationYaw.eulerAngles);

        [ScriptProperty("turretYaw")]
        public TransformClass TurretYaw => new TransformClass(passenger.turretYaw);

        [ScriptProperty("rotationPitch")]
        public Vector3Class RotationPitch => new Vector3Class(passenger.rotationPitch.eulerAngles);

        [ScriptProperty("turretPitch")]
        public TransformClass TurretPitch => new TransformClass(passenger.turretPitch);

        [ScriptProperty("turretAim")]
        public TransformClass TurretAim => new TransformClass(passenger.turretAim);
    }
}