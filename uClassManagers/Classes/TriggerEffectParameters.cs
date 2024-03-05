using SDG.Unturned;
using System;
using uClassManagers.Classes.Assets;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("TriggerEffectParameters")]
    public class TriggerEffectParametersClass
    {
        public TriggerEffectParameters triggerEffectParameters { get; private set; }
        public TriggerEffectParametersClass(TriggerEffectParameters c_triggerEffectParameters) => triggerEffectParameters = c_triggerEffectParameters;

        [ScriptConstructor]
        public TriggerEffectParametersClass(EffectAssetClass effectAsset, Vector3Class position, float relevantDistance = 128, bool reliable = true, bool shouldReplicate = true, bool wasInstigatedByPlayer = false)
        {
            triggerEffectParameters = new TriggerEffectParameters(effectAsset.effectAsset)
            {
                position = position.Vector3,
                scale = Vector3.one,
                shouldReplicate = shouldReplicate,
                reliable = reliable,
                wasInstigatedByPlayer = wasInstigatedByPlayer,
                relevantDistance = relevantDistance
            };
        }

        [ScriptConstructor]
        public TriggerEffectParametersClass(string guid, Vector3Class position, float relevantDistance = 128, bool reliable = true, bool shouldReplicate = true, bool wasInstigatedByPlayer = false)
        {
            triggerEffectParameters = new TriggerEffectParameters(GuidTool.ParseGuid(guid))
            {
                position = position.Vector3,
                scale = Vector3.one,
                shouldReplicate = shouldReplicate,
                reliable = reliable,
                wasInstigatedByPlayer = wasInstigatedByPlayer,
                relevantDistance = relevantDistance
            };
        }

        [ScriptConstructor]
        public TriggerEffectParametersClass(ushort id, Vector3Class position, float relevantDistance = 128, bool reliable = true, bool shouldReplicate = true, bool wasInstigatedByPlayer = false)
        {
            #pragma warning disable CS0618
            triggerEffectParameters = new TriggerEffectParameters(id)
            {
                position = position.Vector3,
                scale = Vector3.one,
                shouldReplicate = shouldReplicate,
                reliable = reliable,
                wasInstigatedByPlayer = wasInstigatedByPlayer,
                relevantDistance = relevantDistance
            };
        }

        [ScriptProperty("asset")]
        public EffectAssetClass Asset => new EffectAssetClass(triggerEffectParameters.asset);

        [ScriptProperty("position")]
        public Vector3Class Position => new Vector3Class(triggerEffectParameters.position);

        [ScriptProperty("scale")]
        public Vector3Class Scale => new Vector3Class(triggerEffectParameters.scale);

        [ScriptProperty("shouldReplicate")]
        public bool ShouldReplicate => triggerEffectParameters.shouldReplicate;

        [ScriptProperty("reliable")]
        public bool Reliable => triggerEffectParameters.reliable;

        [ScriptProperty("wasInstigatedByPlayer")]
        public bool WasInstigatedByPlayer => triggerEffectParameters.wasInstigatedByPlayer;

        [ScriptProperty("relevantDistance")]
        public float RelevantDistance => triggerEffectParameters.relevantDistance;

        [ScriptFunction("GetDirection")]
        public Vector3Class GetDirection() => new Vector3Class(triggerEffectParameters.GetDirection());

        [ScriptFunction("GetRotation")]
        public Vector3Class GetRotation() => new Vector3Class(triggerEffectParameters.GetRotation().eulerAngles);

        [ScriptFunction("SetDirection")]
        public void SetDirection(Vector3Class forward) => triggerEffectParameters.SetDirection(forward.Vector3);

        [ScriptFunction("SetDirection")]
        public void SetDirection(Vector3Class forward, Vector3Class upwards) => triggerEffectParameters.SetDirection(forward.Vector3, upwards.Vector3);

        [ScriptFunction("SetRelevantPlayer")]
        public void SetDirection(PlayerClass player) => triggerEffectParameters.SetRelevantPlayer(player.Player.channel.owner.transportConnection);

        [ScriptFunction("SetRotation")]
        public void SetRotation(Vector3Class rotation) => triggerEffectParameters.SetRotation(Quaternion.Euler(rotation.Vector3));

        [ScriptFunction("SetUniformScale")]
        public void SetUniformScale(float scale) => triggerEffectParameters.SetUniformScale(scale);
    }
}
