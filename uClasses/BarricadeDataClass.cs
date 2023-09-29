using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClasses
{
    [ScriptClass("barricadeData")]
    public class BarricadeDataClass
    {
        public BarricadeData barricadeData { get; private set; }
        public BarricadeDataClass(BarricadeData c_barricadeData) => barricadeData = c_barricadeData;

        [ScriptProperty("point")]
        public Vector3Class Point
        {
            get => new Vector3Class(barricadeData.point);
            set => barricadeData.point = value.Vector3;
        }

        [ScriptProperty("angle_x")]
        public byte Angle_X
        {
            get => barricadeData.angle_x;
            set => barricadeData.angle_x = value;
        }

        [ScriptProperty("angle_y")]
        public byte Angle_Y
        {
            get => barricadeData.angle_y;
            set => barricadeData.angle_y = value;
        }

        [ScriptProperty("angle_z")]
        public byte Angle_Z
        {
            get => barricadeData.angle_z;
            set => barricadeData.angle_z = value;
        }

        [ScriptProperty("owner")]
        public string Owner
        {
            get => barricadeData.owner.ToString();
            set => barricadeData.owner = uint.Parse(value);
        }

        [ScriptProperty("group")]
        public string Group
        {
            get => barricadeData.group.ToString();
            set => barricadeData.group = uint.Parse(value);
        }

        [ScriptProperty("objActiveDate")]
        public uint ObjActiveDate
        {
            get => barricadeData.objActiveDate;
            set => barricadeData.objActiveDate = value;
        }

        [ScriptProperty("instanceID")]
        public uint InstanceID
        {
            get => barricadeData.instanceID;
        }

        [ScriptProperty("uBarricade")]
        public uBarricadeClass UBarricade
        {
            get => new uBarricadeClass(barricadeData.barricade);
        }
    }
}