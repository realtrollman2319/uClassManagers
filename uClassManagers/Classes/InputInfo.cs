using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("InputInfo")]
    public class InputInfoClass
    {
        public InputInfo inputInfo { get; private set; }
        public InputInfoClass(InputInfo c_InputInfo) => inputInfo = c_InputInfo;

        [ScriptProperty("type")]
        public string Type => inputInfo.type.ToString();

        [ScriptProperty("usage")]
        public string Usage => inputInfo.usage.ToString();

        [ScriptProperty("point")]
        public Vector3Class Point => new Vector3Class(inputInfo.point);

        [ScriptProperty("direction")]
        public Vector3Class Direction => new Vector3Class(inputInfo.direction);

        [ScriptProperty("normal")]
        public Vector3Class Normal => new Vector3Class(inputInfo.normal);

        [ScriptProperty("player")]
        public PlayerClass Player => new PlayerClass(inputInfo.player);

        [ScriptProperty("zombie")]
        public uZombieClass Zombie => new uZombieClass(inputInfo.zombie);

        [ScriptProperty("animal")]
        public uAnimalClass Animal => new uAnimalClass(inputInfo.animal);

        [ScriptProperty("limb")]
        public string Limb => inputInfo.limb.ToString();

        [ScriptProperty("materialName")]
        public string MaterialName => inputInfo.materialName;

        [ScriptProperty("vehicle")]
        public VehicleClass Vehicle => new VehicleClass(inputInfo.vehicle);

        [ScriptProperty("transform")]
        public TransformClass Transform => new TransformClass(inputInfo.transform);

        [ScriptProperty("colliderTransform")]
        public TransformClass ColliderTransform => new TransformClass(inputInfo.colliderTransform);

        [ScriptProperty("section")]
        public byte Section => inputInfo.section;
    }
}
