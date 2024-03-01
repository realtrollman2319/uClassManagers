using SDG.Unturned;
using uClassManagers.Classes;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extensions
{
    [ScriptTypeExtension(typeof(StructureClass))]
    public class StructureClassExtension
    {
        [ScriptFunction("get_data")]
        public static StructureDataClass getStructureDrop([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is StructureClass structureClass)) return null;
            StructureDrop structureDrop = StructureManager.FindStructureByRootTransform(structureClass.StructureTransform);
            return new StructureDataClass(structureDrop.GetServersideData());
        }

        [ScriptFunction("get_transform")]
        public static TransformClass getStructureTransform([ScriptInstance] ExpressionValue instance)
        {
            return instance.Data is StructureClass structureClass ? new TransformClass(structureClass.StructureTransform) : null;
        }
    }
}