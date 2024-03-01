using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("Transform")]
    public class TransformClass
    {
        public Transform transform { get; private set; }
        public TransformClass(Transform c_transform) => transform = c_transform;

        [ScriptProperty("localPosition")]
        public Vector3Class LocalPosition => new Vector3Class(transform.localPosition);

        [ScriptProperty("eulerAngles")]
        public Vector3Class EulerAngles => new Vector3Class(transform.eulerAngles);

        [ScriptProperty("localEulerAngles")]
        public Vector3Class LocalEulerAngles => new Vector3Class(transform.localEulerAngles);

        [ScriptProperty("right")]
        public Vector3Class Right => new Vector3Class(transform.right);

        [ScriptProperty("up")]
        public Vector3Class Up => new Vector3Class(transform.up);

        [ScriptProperty("forward")]
        public Vector3Class Forward => new Vector3Class(transform.forward);

        [ScriptProperty("position")]
        public Vector3Class Position => new Vector3Class(transform.position);

        [ScriptProperty("lossyScale")]
        public Vector3Class LossyScale => new Vector3Class(transform.lossyScale);

        [ScriptProperty("localScale")]
        public Vector3Class LocalScale => new Vector3Class(transform.localScale);

        [ScriptProperty("rotation")]
        public Vector3Class Rotation => new Vector3Class(transform.rotation.eulerAngles);

        [ScriptProperty("localRotation")]
        public Vector3Class LocalRotation => new Vector3Class(transform.localRotation.eulerAngles);

        [ScriptProperty("parent")]
        public TransformClass Parent => new TransformClass(transform.parent);

        [ScriptProperty("root")]
        public TransformClass Root => new TransformClass(transform.root);

        [ScriptProperty("childCount")]
        public int ChildCount => transform.childCount;

        [ScriptProperty("hierarchyCapacity")]
        public int HierarchyCapacity => transform.hierarchyCapacity;

        [ScriptProperty("hierarchyCount")]
        public int HierarchyCount => transform.hierarchyCount;

        [ScriptFunction("Find")]
        public TransformClass Find(string n)
        {
            return new TransformClass(transform.Find(n));
        }

        [ScriptFunction("InverseTransformDirection")]
        public Vector3Class InverseTransformDirection(Vector3Class direction)
        {
            return new Vector3Class(transform.InverseTransformDirection(direction.Vector3));
        }

        [ScriptFunction("InverseTransformDirection")]
        public Vector3Class InverseTransformDirection(float x, float y, float z)
        {
            return new Vector3Class(transform.InverseTransformDirection(x, y, z));
        }

        [ScriptFunction("InverseTransformPoint")]
        public Vector3Class InverseTransformPoint(Vector3Class position)
        {
            return new Vector3Class(transform.InverseTransformPoint(position.Vector3));
        }

        [ScriptFunction("InverseTransformPoint")]
        public Vector3Class InverseTransformPoint(float x, float y, float z)
        {
            return new Vector3Class(transform.InverseTransformPoint(x, y, z));
        }

        [ScriptFunction("InverseTransformVector")]
        public Vector3Class InverseTransformVector(Vector3Class vector)
        {
            return new Vector3Class(transform.InverseTransformVector(vector.Vector3));
        }

        [ScriptFunction("InverseTransformVector")]
        public Vector3Class InverseTransformVector(float x, float y, float z)
        {
            return new Vector3Class(transform.InverseTransformVector(x, y, z));
        }
    }
}
