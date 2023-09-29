using System.Linq;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extras.MetadataChecker
{
    [ScriptTypeExtension(typeof(ItemClass))]
    public class ItemClassExtension
    {
        [ScriptFunction("get_metadata")]
        public static ExpressionValue getMetadata([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is ItemClass item)) return ExpressionValue.Null;
            var metadata = item.Item.item.metadata.Select(b => (ExpressionValue)b); // Converts each byte in the byte array to an ExpressionValue - Ster
            return ExpressionValue.Array(metadata);
        }
    }
}
