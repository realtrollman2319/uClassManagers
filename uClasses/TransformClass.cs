using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClasses
{
    [ScriptClass("Transform")]
    public class TransformClass
    {
        public Transform Transform { get; private set; }
        public TransformClass(Transform transform) => Transform = transform;

        [ScriptProperty("position")]
        public Vector3Class Position
        {
            get => new Vector3Class(Transform.position);
        }

        [ScriptProperty("rotation")]
        public Vector3Class Rotation
        {
            get => new Vector3Class(Transform.rotation.eulerAngles);
        }

        [ScriptFunction("InverseTransformPoint")]
        public Vector3Class InverseTransformPoint(Vector3Class vector3)
        {
            return new Vector3Class(Transform.InverseTransformPoint(vector3.Vector3));
        }
    }
}
