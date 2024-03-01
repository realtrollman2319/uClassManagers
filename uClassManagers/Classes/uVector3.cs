using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("uVector3")]
    public class uVector3Class
    {
        public Vector3 vector3 { get; private set; }
        public uVector3Class(Vector3 c_Vector3) => vector3 = c_Vector3;

        [ScriptProperty("normalized")]
        public Vector3Class Normalized => new Vector3Class(vector3.normalized);

        [ScriptProperty("magnitude")]
        public float Magnitude => vector3.magnitude;

        [ScriptProperty("sqrMagnitude")]
        public float SqrMagnitude => vector3.sqrMagnitude;

        [ScriptProperty("right")]
        public static Vector3Class Right => new Vector3Class(Vector3.right);

        [ScriptProperty("left")]
        public static Vector3Class Left => new Vector3Class(Vector3.left);

        [ScriptProperty("up")]
        public static Vector3Class Up => new Vector3Class(Vector3.up);

        [ScriptProperty("back")]
        public static Vector3Class Back => new Vector3Class(Vector3.back);

        [ScriptProperty("forward")]
        public static Vector3Class Forward => new Vector3Class(Vector3.forward);

        [ScriptProperty("one")]
        public static Vector3Class One => new Vector3Class(Vector3.one);

        [ScriptProperty("zero")]
        public static Vector3Class Zero => new Vector3Class(Vector3.zero);

        [ScriptProperty("negativeInfinity")]
        public static Vector3Class NegativeInfinity => new Vector3Class(Vector3.negativeInfinity);

        [ScriptProperty("positiveInfinity")]
        public static Vector3Class PositiveInfinity => new Vector3Class(Vector3.positiveInfinity);

        [ScriptProperty("down")]
        public static Vector3Class Down => new Vector3Class(Vector3.down);
    }
}