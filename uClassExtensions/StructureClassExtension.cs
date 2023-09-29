using uClassManagers.uClasses;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClassExtensions
{
    [ScriptTypeExtension(typeof(StructureClass))]
    public class StructureClassExtension
    {
        [ScriptFunction("get_transform")]
        public static TransformClass getStructureTransform([ScriptInstance] ExpressionValue instance)
        {
            return instance.Data is StructureClass structureClass ? new TransformClass(structureClass.StructureTransform) : null;
        }
    }
}
