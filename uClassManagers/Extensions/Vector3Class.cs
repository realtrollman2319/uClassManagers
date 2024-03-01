using uClassManagers.Classes;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extensions
{
    [ScriptTypeExtension(typeof(Vector3Class))]
    public class Vector3ClassExtension
    {
        [ScriptFunction("get_vector3")]
        public uVector3Class Vector3([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is Vector3Class vector3)) return null;
            return new uVector3Class(vector3.Vector3);
        }
    }
}