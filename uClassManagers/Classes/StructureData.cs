using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("StructureData")]
    public class StructureDataClass
    {
        public StructureData structureData { get; private set; }
        public StructureDataClass(StructureData c_structureData) => structureData = c_structureData;

        [ScriptProperty("point")]
        public Vector3Class Point => new Vector3Class(structureData.point);

        [ScriptProperty("angle_x")]
        public byte Angle_X => structureData.angle_x;

        [ScriptProperty("angle_y")]
        public byte Angle_Y => structureData.angle_y;

        [ScriptProperty("angle_z")]
        public byte Angle_Z => structureData.angle_z;

        [ScriptProperty("owner")]
        public string Owner => structureData.owner.ToString();

        [ScriptProperty("group")]
        public string Group => structureData.group.ToString();

        [ScriptProperty("objActiveDate")]
        public uint ObjActiveDate => structureData.objActiveDate;

        [ScriptProperty("instanceID")]
        public uint InstanceID => structureData.instanceID;

        [ScriptProperty("structure")]
        public uStructureClass UStructure => new uStructureClass(structureData.structure);
    }
}