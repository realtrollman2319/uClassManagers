using SDG.Unturned;
using System;
using uClassManagers.Classes;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

#pragma warning disable CS0612
namespace uClassManagers.Managers
{
    [ScriptModule("StructureManager")]
    public class StructureManagerClass
    {
        [ScriptProperty("SAVEDATA_VERSION")]
        public static float SAVEDATA_VERSION => StructureManager.HEIGHT;

        [ScriptProperty("STRUCTURE_REGIONS")]
        public static byte STRUCTURE_REGIONS => StructureManager.STRUCTURE_REGIONS;

        [ScriptProperty("WALL")]
        public static float WALL => StructureManager.WALL;

        [ScriptProperty("PILLAR")]
        public static float PILLAR => StructureManager.PILLAR;

        [ScriptProperty("HEIGHT")]
        public static float HEIGHT => StructureManager.HEIGHT;

        [ScriptFunction("askClearAllStructures")]
        public static void AskClearAllStructures()
        {
            StructureManager.askClearAllStructures();
        }

        [ScriptFunction("askClearRegionStructures")]
        public static void AskClearRegionStructures(byte x, byte y)
        {
            StructureManager.askClearRegionStructures(x, y);
        }

        [ScriptFunction("changeOwnerAndGroup")]
        public static void ChangeOwnerAndGroup(StructureClass structure, string newOwner, string newGroup)
        {
            StructureManager.changeOwnerAndGroup(structure.StructureTransform, ulong.Parse(newOwner), ulong.Parse(newGroup));
        }

        [ScriptFunction("dropReplicatedStructure")]
        public static bool DropReplicatedStructure(ushort id, Vector3Class point, Vector3Class rotation, string owner, string group)
        {
            bool hasDropped = StructureManager.dropReplicatedStructure(new Structure(id), point.Vector3, Quaternion.Euler(rotation.Vector3), ulong.Parse(owner), ulong.Parse(owner));
            return hasDropped;
        }

        [ScriptFunction("dropReplicatedStructure")]
        public static bool DropReplicatedStructure(string guid, Vector3Class point, Vector3Class rotation, string owner, string group)
        {
            ItemStructureAsset asset = Assets.find<ItemStructureAsset>(GuidTool.ParseGuid(guid));
            bool hasDropped = StructureManager.dropReplicatedStructure(new Structure(asset, asset.health), point.Vector3, Quaternion.Euler(rotation.Vector3), ulong.Parse(owner), ulong.Parse(owner));
            return hasDropped;
        }

        [ScriptFunction("dropReplicatedStructure")]
        public static bool DropReplicatedStructure(uStructureClass structure, Vector3Class point, Vector3Class rotation, string owner, string group)
        {
            bool hasDropped = StructureManager.dropReplicatedStructure(structure.structure, point.Vector3, Quaternion.Euler(rotation.Vector3), ulong.Parse(owner), ulong.Parse(owner));
            return hasDropped;
        }

        [ScriptFunction("findStructureByRootTransform")]
        public static StructureClass FindStructureByRootTransform(TransformClass transform)
        {
            StructureDrop structureTransform = StructureManager.FindStructureByRootTransform(transform.transform);
            return new StructureClass(structureTransform.model);
        }

        [ScriptFunction("save")]
        public static void Save() => StructureManager.save();

        [ScriptFunction("load")]
        public static void Load() => StructureManager.load();

        [ScriptFunction("serverSetStructureTransform")]
        public static void ServerSetStructureTransform(StructureClass structure, Vector3Class position, Vector3Class rotation)
        {
            StructureManager.ServerSetStructureTransform(structure.StructureTransform, position.Vector3, Quaternion.Euler(rotation.Vector3));
        }

        [ScriptFunction("transformStructure")]
        public static void TransformStructure(StructureClass structure, Vector3Class point, float angle_x, float angle_y, float angle_z)
        {
            StructureManager.transformStructure(structure.StructureTransform, point.Vector3, angle_x, angle_y, angle_z);
        }
    }
}