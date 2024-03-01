using uClassManagers.Classes;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extensions
{
    [ScriptTypeExtension(typeof(VehicleClass))]
    public class VehicleClassExtension
    {
        [ScriptFunction("get_vehicle")]
        public InteractableVehicleClass Vehicle([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return null;
            return new InteractableVehicleClass(vehicle.Vehicle);
        }
    }
}
