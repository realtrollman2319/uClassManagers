using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClassExtensions
{
    [ScriptTypeExtension(typeof(ItemClass))]
    public class ItemClassExtension
    {
        [ScriptFunction("itemJar")]
        public static ItemJarClass ItemJar([ScriptInstance] ExpressionValue instance) => instance.Data is ItemClass item ? new ItemJarClass(item.Item) : null;
    }
}
