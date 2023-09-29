using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.uClasses
{
    [ScriptModule("Assets")]
    public class AssetsClass
    {
        [ScriptFunction("findVehicle")]
        public static VehicleAssetClass Find(ushort id)
        {
            VehicleAsset vAsset = Assets.find(EAssetType.VEHICLE, id) as VehicleAsset;
            return vAsset != null ? new VehicleAssetClass(vAsset) : null;
        }

        [ScriptFunction("findVehicle")]
        public static VehicleAssetClass Find(string name)
        {
            VehicleAsset vAsset = Assets.find(EAssetType.VEHICLE, name) as VehicleAsset;
            return vAsset != null ? new VehicleAssetClass(vAsset) : null;
        }
    }
}
