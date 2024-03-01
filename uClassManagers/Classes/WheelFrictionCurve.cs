using UnityEngine;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("WheelFrictionCurve")]
    public class WheelFrictionCurveClass
    {
        public WheelFrictionCurve wheelFrictionCurve { get; private set; }
        public WheelFrictionCurveClass(WheelFrictionCurve c_WheelFrictionCurve) => wheelFrictionCurve = c_WheelFrictionCurve;

        [ScriptProperty("extremumSlip")]
        public float ExtremumSlip => wheelFrictionCurve.extremumSlip;

        [ScriptProperty("extremumValue")]
        public float ExtremumValue => wheelFrictionCurve.extremumValue;

        [ScriptProperty("asymptoteSlip")]
        public float AsymptoteSlip => wheelFrictionCurve.asymptoteSlip;

        [ScriptProperty("asymptoteValue")]
        public float AsymptoteValue => wheelFrictionCurve.asymptoteValue;

        [ScriptProperty("stiffness")]
        public float Stiffness => wheelFrictionCurve.stiffness;
    }
}