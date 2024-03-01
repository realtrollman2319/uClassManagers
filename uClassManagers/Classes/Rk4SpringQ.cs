using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("Rk4SpringQ")]
    public class Rk4SpringQClass
    {
        public Rk4SpringQ rk4SpringQ { get; private set; }
        public Rk4SpringQClass(Rk4SpringQ c_Rk4SpringQ) => rk4SpringQ = c_Rk4SpringQ;

        [ScriptConstructor]
        public Rk4SpringQClass(float stiffness, float damping) => rk4SpringQ = new Rk4SpringQ(stiffness, damping);

        [ScriptProperty("currentRotation")]
        public Vector3Class CurrentRotation => new Vector3Class(rk4SpringQ.currentRotation.eulerAngles);

        [ScriptProperty("targetRotation")]
        public Vector3Class TargetRotation => new Vector3Class(rk4SpringQ.targetRotation.eulerAngles);

        [ScriptProperty("stiffness")]
        public float Stiffness => rk4SpringQ.stiffness;

        [ScriptProperty("damping")]
        public float Damping => rk4SpringQ.damping;

        [ScriptFunction("update")]
        public void Update(float deltaTime) => rk4SpringQ.Update(deltaTime);
    }
}
