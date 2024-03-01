using SDG.Unturned;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("Wheel")]
    public class WheelClass
    {
        public Wheel wheel { get; private set; }
        public WheelClass(Wheel c_Wheel) => wheel = c_Wheel;

        [ScriptProperty("model")]
        public TransformClass Model => new TransformClass(wheel.model);

        [ScriptProperty("brakeTorqueTractionMultiplier")]
        public float BrakeTorqueTractionMultiplier => wheel.brakeTorqueTractionMultiplier;

        [ScriptProperty("brakeTorqueMultiplier")]
        public float BrakeTorqueMultiplier => wheel.brakeTorqueMultiplier;

        [ScriptProperty("motorTorqueClampMultiplier")]
        public float MotorTorqueClampMultiplier => wheel.motorTorqueClampMultiplier;

        [ScriptProperty("stiffnessForward")]
        public float StiffnessForward => wheel.stiffnessForward;

        [ScriptProperty("stiffnessSideways")]
        public float StiffnessSideways => wheel.stiffnessSideways;

        [ScriptProperty("stiffnessTractionMultiplier")]
        public float StiffnessTractionMultiplier => wheel.stiffnessTractionMultiplier;

        [ScriptProperty("motorTorqueMultiplier")]
        public float MotorTorqueMultiplier => wheel.motorTorqueMultiplier;

        [ScriptProperty("hasBrakes")]
        public bool HasBrakes => wheel.hasBrakes;

        [ScriptProperty("isPowered")]
        public bool IsPowered => wheel.isPowered;

        [ScriptProperty("sidewaysFriction")]
        public WheelFrictionCurveClass SidewaysFriction => new WheelFrictionCurveClass(wheel.sidewaysFriction);

        [ScriptProperty("forwardFriction")]
        public WheelFrictionCurveClass ForwardFriction => new WheelFrictionCurveClass(wheel.forwardFriction);

        [ScriptProperty("rest")]
        public Vector3Class Rest => new Vector3Class(wheel.rest.eulerAngles);

        [ScriptProperty("isAnimationSteered")]
        public bool IsAnimationSteered => wheel.isAnimationSteered;

        [ScriptProperty("vehicle")]
        public InteractableVehicleClass Vehicle => new InteractableVehicleClass(wheel.vehicle);

        [ScriptProperty("isPhysical")]
        public bool IsPhysical
        {
            get => wheel.isPhysical;
            set => wheel.isPhysical = value;
        }

        [ScriptProperty("isAlive")]
        public bool IsAlive
        {
            get => wheel.isAlive;
            set => wheel.isAlive = value;
        }

        [ScriptProperty("isGrounded")]
        public bool IsGrounded => wheel.isGrounded;

        [ScriptProperty("isSteered")]
        public bool IsSteered => wheel.isSteered;

        [ScriptProperty("index")]
        public int Index => wheel.index;

        [ScriptFunction("askDamage")]
        public void AskDamage()
        {
            wheel.askDamage();
        }

        [ScriptFunction("askRepair")]
        public void AskRepair()
        {
            wheel.askRepair();
        }

        [ScriptFunction("checkForTraps")]
        public void CheckForTraps()
        {
            wheel.checkForTraps();
        }

        [ScriptFunction("reset")]
        public void Reset()
        {
            wheel.reset();
        }

        [ScriptFunction("simulate")]
        public void Simulate(float input_x, float input_y, bool inputBrake, float delta)
        {
            wheel.simulate(input_x, input_y, inputBrake, delta);
        }

        [ScriptFunction("update")]
        public void Update(float delta)
        {
            wheel.update(delta);
        }
    }
}