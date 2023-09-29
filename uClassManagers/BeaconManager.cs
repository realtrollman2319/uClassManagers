using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers
{
    [ScriptModule("BeaconManager")]
    public class BeaconManagerClass
    {
        [ScriptFunction("checkBeacon")]
        public static BarricadeClass CheckBeacon(byte nav)
        {
            var beacon = BeaconManager.checkBeacon(nav);
            if (beacon != null)
            {
                BarricadeClass uBarricade = new BarricadeClass(beacon.transform);
                return uBarricade;
            }
            else
            {
                return null;
            }
        }

        [ScriptFunction("getParticipants")]
        public static int GetParticipants(byte nav)
        {
            return BeaconManager.getParticipants(nav);
        }
    }
}