using SDG.Unturned;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("SafezoneNode")]
    public class SafezoneNodeClass
    {
        public SafezoneNode safezoneNode { get; private set; }
        public SafezoneNodeClass(SafezoneNode c_SafezoneNode) => safezoneNode = c_SafezoneNode;

        [ScriptConstructor]
        public SafezoneNodeClass(Vector3Class newPoint) => safezoneNode = new SafezoneNode(newPoint.Vector3);

        [ScriptConstructor]
        public SafezoneNodeClass(Vector3Class newPoint, float newRadius, bool newHeight, bool newNoWeapons, bool newNoBuildables) => safezoneNode = new SafezoneNode(newPoint.Vector3, newRadius, newHeight, newNoWeapons, newNoBuildables);

        [ScriptProperty("MIN_SIZE")]
        public static float MIN_SIZE => SafezoneNode.MIN_SIZE;

        [ScriptProperty("MAX_SIZE")]
        public static float MAX_SIZE => SafezoneNode.MAX_SIZE;

        [ScriptProperty("isHeight")]
        public bool IsHeight => safezoneNode.isHeight;

        [ScriptProperty("noWeapons")]
        public bool NoWeapons => safezoneNode.noWeapons;

        [ScriptProperty("noBuildables")]
        public bool NoBuildables => safezoneNode.noBuildables;

        [ScriptProperty("radius")]
        public float Radius
        {
            get => safezoneNode.radius;
            set => safezoneNode.radius = value;
        }

        [ScriptProperty("point")]
        public Vector3Class Point => new Vector3Class(safezoneNode.point);

        [ScriptProperty("type")]
        public string Type => safezoneNode.type.ToString();

        [ScriptProperty("model")]
        public TransformClass Model => new TransformClass(safezoneNode.model);

        [ScriptFunction("move")]
        public void Move(Vector3Class newPoint)
        {
            safezoneNode.move(newPoint.Vector3);
        }

        [ScriptFunction("remove")]
        public void Remove()
        {
            safezoneNode.remove();
        }

        [ScriptFunction("setEnabled")]
        public void SetEnabled(bool isEnabled)
        {
            safezoneNode.setEnabled(isEnabled);
        }

        [ScriptFunction("CalculateNormalizedRadiusFromRadius")]
        public static float CalculateNormalizedRadiusFromRadius(float radius)
        {
            return SafezoneNode.CalculateNormalizedRadiusFromRadius(radius);
        }

        [ScriptFunction("CalculateRadiusFromNormalizedRadius")]
        public static float CalculateRadiusFromNormalizedRadius(float normalizedRadius)
        {
            return SafezoneNode.CalculateRadiusFromNormalizedRadius(normalizedRadius);
        }
    }
}
