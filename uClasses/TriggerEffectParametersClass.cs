using System;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClasses
{
    [ScriptClass("TriggerEffectParameters")]
    public class TriggerEffectParametersClass
    {
        public TriggerEffectParametersCSClass triggerEffectParametersCSClass { get; private set; }
        public TriggerEffectParametersClass(TriggerEffectParametersCSClass n_triggerEffectParametersCSClass) => triggerEffectParametersCSClass = n_triggerEffectParametersCSClass;

        [ScriptConstructor]
        public TriggerEffectParametersClass(string guid) => triggerEffectParametersCSClass = new TriggerEffectParametersCSClass(Guid.Parse(guid));

        [ScriptConstructor]
        public TriggerEffectParametersClass(ushort id) => triggerEffectParametersCSClass = new TriggerEffectParametersCSClass(id);


        [ScriptProperty("relevantDistance")]
        public float RelevantDistance
        {
            get
            {
                return triggerEffectParametersCSClass.relevantDistance;
            }
            set
            {
                triggerEffectParametersCSClass.relevantDistance = value;
            }
        }

        [ScriptProperty("wasInstigatedByPlayer")]
        public bool WasInstigatedByPlayer
        {
            get
            {
                return triggerEffectParametersCSClass.wasInstigatedByPlayer;
            }
            set
            {
                triggerEffectParametersCSClass.wasInstigatedByPlayer = value;
            }
        }

        [ScriptProperty("reliable")]
        public bool Reliable
        {
            get
            {
                return triggerEffectParametersCSClass.reliable;
            }
            set
            {
                triggerEffectParametersCSClass.reliable = value;
            }
        }

        [ScriptProperty("scale")]
        public Vector3Class Scale
        {
            get
            {
                return new Vector3Class(triggerEffectParametersCSClass.scale);
            }
            set
            {
                triggerEffectParametersCSClass.scale = value.Vector3;
            }
        }

        [ScriptProperty("direction")]
        public Vector3Class Direction
        {
            get
            {
                return new Vector3Class(triggerEffectParametersCSClass.direction);
            }
            set
            {
                triggerEffectParametersCSClass.direction = value.Vector3;
            }
        }

        [ScriptProperty("position")]
        public Vector3Class Position
        {
            get
            {
                return new Vector3Class(triggerEffectParametersCSClass.position);
            }
            set
            {
                triggerEffectParametersCSClass.position = value.Vector3;
            }
        }

        [ScriptProperty("shouldReplicate")]
        public bool ShouldReplicate
        {
            get
            {
                return triggerEffectParametersCSClass.shouldReplicate;
            }
            set
            {
                triggerEffectParametersCSClass.shouldReplicate = value;
            }
        }
    }
}
