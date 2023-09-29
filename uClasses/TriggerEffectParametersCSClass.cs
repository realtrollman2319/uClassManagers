using System;
using UnityEngine;

namespace uClassManagers.uClasses
{
    public class TriggerEffectParametersCSClass
    {
        internal Guid guid = Guid.Empty;
        internal ushort id = 0;

        public float relevantDistance = 1024f;
        public bool wasInstigatedByPlayer = false;
        public bool reliable = true;
        public Vector3 scale = new Vector3(0, 0, 0);
        public Vector3 direction = new Vector3(0, 0, 0);
        public Vector3 position = new Vector3(0, 0, 0);
        public bool shouldReplicate = true;

        public TriggerEffectParametersCSClass(Guid guid) { this.guid = guid; }
        public TriggerEffectParametersCSClass(ushort id) { this.id = id; }
    }
}
