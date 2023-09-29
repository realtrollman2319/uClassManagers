using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClassExtensions
{
    [ScriptTypeExtension(typeof(Vector3Class))]
    public class Vector3ClassExpansion
    {
        // Read only section
        // Null for now
        /*
        [ScriptFunction("get_method")]
        public static string Method([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is Vector3Class vector3)) return string.empty;
        }
        */
    }
}