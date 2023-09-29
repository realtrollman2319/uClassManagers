using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using uClassManagers.Dictionaries;
using uClassManagers.uClasses;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers
{
    [ScriptModule("VehicleManager")]
    public class VehicleManagerClass
    {
        // Properties

        [ScriptProperty("SAVEDATA_VERSION_ADDED_DECAY")]
        public static byte SAVEDATA_VERSION_ADDED_DECAY => VehicleManager.SAVEDATA_VERSION_ADDED_DECAY;

        [ScriptProperty("SAVEDATA_VERSION_REPLACED_ID_WITH_GUID")]
        public static byte SAVEDATA_VERSION_REPLACED_ID_WITH_GUID => VehicleManager.SAVEDATA_VERSION_REPLACED_ID_WITH_GUID;

        [ScriptProperty("SAVEDATA_VERSION_BATTERY_GUID")]
        public static byte SAVEDATA_VERSION_BATTERY_GUID => VehicleManager.SAVEDATA_VERSION_BATTERY_GUID;

        [ScriptProperty("SAVEDATA_VERSION")]
        public static byte SAVEDATA_VERSION => VehicleManager.SAVEDATA_VERSION;

        [ScriptProperty("maxInstances")]
        public static uint MaxInstances => VehicleManager.maxInstances;

        [ScriptProperty("vehicles")]
        public static ExpressionValue Vehicles
        {
            get
            {
                List<InteractableVehicle> vmVehicles = VehicleManager.vehicles;
                if (vmVehicles.Count <= 0) return ExpressionValue.Null;
                List<ExpressionValue> EVList = new List<ExpressionValue>();
                foreach (InteractableVehicle vehicle in vmVehicles)
                {
                    EVList.Add(ExpressionValue.CreateObject(new VehicleClass(vehicle)));
                }
                return ExpressionValue.Array(EVList.ToArray());
            }
        }

        [ScriptFunction("getVehicleRandomTireAliveMask")]
        public static byte GetVehicleRandomTireAliveMask(VehicleAssetClass asset)
        {
            return VehicleManager.getVehicleRandomTireAliveMask(asset.vehicleAsset);
        }

        [ScriptFunction("siphonFromVehicle")]
        public static ushort SiphonFromVehicle(VehicleClass vehicle, PlayerClass instigatingPlayer, ushort desiredAmount)
        {
            return VehicleManager.siphonFromVehicle(vehicle.Vehicle, instigatingPlayer.Player, desiredAmount);
        }

        [ScriptFunction("findVehicleByNetInstanceID")]
        public static VehicleClass FindVehicleByNetInstanceID(uint instanceID)
        {
            return new VehicleClass(VehicleManager.findVehicleByNetInstanceID(instanceID));
        }

        [ScriptFunction("getVehicle")]
        public static VehicleClass GetVehicle(uint instanceID)
        {
            return new VehicleClass(VehicleManager.getVehicle(instanceID));
        }

        [ScriptFunction("spawnLockedVehicleForPlayerV2")]
        public static VehicleClass SpawnLockedVehicleForPlayerV2(ushort id, Vector3Class point, Vector3Class angle, PlayerClass player)
        {
            return new VehicleClass(VehicleManager.spawnLockedVehicleForPlayerV2(id, point.Vector3, Quaternion.Euler(angle.Vector3), player.Player));
        }

        [ScriptFunction("spawnVehicleV2")]
        public static VehicleClass SpawnVehicleV2(ushort id, Vector3Class point, Vector3Class angle)
        {
            return new VehicleClass(VehicleManager.spawnVehicleV2(id, point.Vector3, Quaternion.Euler(angle.Vector3)));
        }

        [ScriptFunction("forceRemovePlayer")]
        public static bool ForceRemovePlayer(PlayerClass player)
        {
            return VehicleManager.forceRemovePlayer(player.Player.channel.owner.playerID.steamID);
        }

        [ScriptFunction("removePlayerTeleportUnsafe")]
        public static bool RemovePlayerTeleportUnsafe(VehicleClass vehicle, PlayerClass player, Vector3Class position, float yaw)
        {
            return VehicleManager.removePlayerTeleportUnsafe(vehicle.Vehicle, player.Player, position.Vector3, yaw);
        }

        [ScriptFunction("serverForcePassengerIntoVehicle")]
        public static bool ServerForcePassengerIntoVehicle(PlayerClass player, VehicleClass vehicle)
        {
            return VehicleManager.ServerForcePassengerIntoVehicle(player.Player, vehicle.Vehicle);
        }

        [ScriptFunction("askVehicleDestroy")]
        public static void AskVehicleDestroy(VehicleClass vehicle)
        {
            VehicleManager.askVehicleDestroy(vehicle.Vehicle);
        }

        [ScriptFunction("askVehicleDestroyAll")]
        public static void AskVehicleDestroyAll()
        {
            VehicleManager.askVehicleDestroyAll();
        }

        [ScriptFunction("carjackVehicle")]
        public static void CarjackVehicle(VehicleClass vehicle, PlayerClass instigatingPlayer, Vector3Class force, Vector3Class torque)
        {
            VehicleManager.carjackVehicle(vehicle.Vehicle, instigatingPlayer.Player, force.Vector3, torque.Vector3);
        }

        [ScriptFunction("damage")]
        public static void Damage(VehicleClass vehicle, float damage, float times, bool canRepair, string instigatorSteamID = "0", string damageOrigin = "Unknown")
        {
            if (EnumDictionaries.EDamageOrigins.TryGetValue(damageOrigin, out EDamageOrigin resultEDamageOrigin))
            {
                VehicleManager.damage(vehicle.Vehicle, damage, times, canRepair, new CSteamID(ulong.Parse(instigatorSteamID)), resultEDamageOrigin);
            }
            else
            {
                Console.WriteLine(@"uClassManagers/VehicleManager module from uScript => Damage origin effects MUST be ""Unknown"", ""Mega_Zombie_Boulder"", ""Vehicle_Bumper"", ""Horde_Beacon_Self_Destruct"", ""Trap_Wear_And_Tear"", ""Carepackage_Timeout"", ""Plant_Harvested"", ""Charge_Self_Destruct"", ""Zombie_Swipe"", ""Grenade_Explosion"", ""Rocket_Explosion"", ""Food_Explosion"", ""Vehicle_Explosion"", ""Charge_Explosion"", ""Trap_Explosion"", ""Bullet_Explosion"", ""Radioactive_Zombie_Explosion"", ""Flamable_Zombie_Explosion"", ""Zombie_Electric_Shock"", ""Zombie_Stomp"", ""Zombie_Fire_Breath"", ""Sentry"", ""Useable_Gun"", ""Useable_Melee"", ""Punch"", ""Animal_Attack"", ""Kill_Volume"", ""Vehicle_Collision_Self_Damage"", ""Lightning"", or ""VehicleDecay"". They are case sensitive.", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                return;
            }
        }

        [ScriptFunction("damageTire")]
        public static void DamageTire(VehicleClass vehicle, int tireIndex, string instigatorSteamID = "0", string damageOrigin = "Unknown")
        {
            if (EnumDictionaries.EDamageOrigins.TryGetValue(damageOrigin, out EDamageOrigin resultEDamageOrigin))
            {
                VehicleManager.damageTire(vehicle.Vehicle, tireIndex, new CSteamID(ulong.Parse(instigatorSteamID)), resultEDamageOrigin);
            }
            else
            {
                Console.WriteLine(@"uClassManagers/VehicleManager module from uScript => Damage origin effects MUST be ""Unknown"", ""Mega_Zombie_Boulder"", ""Vehicle_Bumper"", ""Horde_Beacon_Self_Destruct"", ""Trap_Wear_And_Tear"", ""Carepackage_Timeout"", ""Plant_Harvested"", ""Charge_Self_Destruct"", ""Zombie_Swipe"", ""Grenade_Explosion"", ""Rocket_Explosion"", ""Food_Explosion"", ""Vehicle_Explosion"", ""Charge_Explosion"", ""Trap_Explosion"", ""Bullet_Explosion"", ""Radioactive_Zombie_Explosion"", ""Flamable_Zombie_Explosion"", ""Zombie_Electric_Shock"", ""Zombie_Stomp"", ""Zombie_Fire_Breath"", ""Sentry"", ""Useable_Gun"", ""Useable_Melee"", ""Punch"", ""Animal_Attack"", ""Kill_Volume"", ""Vehicle_Collision_Self_Damage"", ""Lightning"", or ""VehicleDecay"". They are case sensitive.", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                return;
            }
        }

        [ScriptFunction("enterVehicle")]
        public static void EnterVehicle(VehicleClass vehicle)
        {
            VehicleManager.enterVehicle(vehicle.Vehicle);
        }

        [ScriptFunction("exitVehicle")]
        public static void ExitVehicle()
        {
            VehicleManager.exitVehicle();
        }

        [ScriptFunction("forceRemovePlayer")]
        public static void ForceRemovePlayer(VehicleClass vehicle, string player)
        {
            VehicleManager.forceRemovePlayer(vehicle.Vehicle, new CSteamID(ulong.Parse(player)));
        }

        [ScriptFunction("getVehiclesInRadius")]
        public static ExpressionValue GetVehiclesInRadius(Vector3Class center, float sqrRadius)
        {
            List<InteractableVehicle> vehiclesInRadius = new List<InteractableVehicle>();
            VehicleManager.getVehiclesInRadius(center.Vector3, sqrRadius, vehiclesInRadius);
            if (vehiclesInRadius.Count <= 0) return ExpressionValue.Null;
            List<ExpressionValue> EVList = new List<ExpressionValue>();
            foreach (InteractableVehicle vehicle in vehiclesInRadius)
            {
                EVList.Add(ExpressionValue.CreateObject(new VehicleClass(vehicle)));
            }
            return ExpressionValue.Array(EVList.ToArray());
        }

        [ScriptFunction("load")]
        public static void Load()
        {
            VehicleManager.load();
        }

        [ScriptFunction("repair")]
        public static void Repair(VehicleClass vehicle, float damage, float times)
        {
            VehicleManager.repair(vehicle.Vehicle, damage, times);
        }

        [ScriptFunction("repair")]
        public static void Repair(VehicleClass vehicle, float damage, float times, string instigatorSteamID = "0")
        {
            VehicleManager.repair(vehicle.Vehicle, damage, times, new CSteamID(ulong.Parse(instigatorSteamID)));
        }

        [ScriptFunction("save")]
        public static void Save()
        {
            VehicleManager.save();
        }

        [ScriptFunction("sendExitVehicle")]
        public static void SendExitVehicle(VehicleClass vehicle, byte seat, Vector3Class point, byte angle, bool forceUpdate)
        {
            VehicleManager.sendExitVehicle(vehicle.Vehicle, seat, point.Vector3, angle, forceUpdate);
        }

        [ScriptFunction("sendVehicleBatteryCharge")]
        public static void SendVehicleBatteryCharge(VehicleClass vehicle, ushort newBatteryCharge)
        {
            VehicleManager.sendVehicleBatteryCharge(vehicle.Vehicle, newBatteryCharge);
        }

        [ScriptFunction("sendVehicleBonus")]
        public static void SendVehicleBonus()
        {
            VehicleManager.sendVehicleBonus();
        }

        [ScriptFunction("sendVehicleExploded")]
        public static void SendVehicleExploded(VehicleClass vehicle)
        {
            VehicleManager.sendVehicleExploded(vehicle.Vehicle);
        }

        [ScriptFunction("sendVehicleFuel")]
        public static void SendVehicleFuel(VehicleClass vehicle, ushort newFuel)
        {
            VehicleManager.sendVehicleFuel(vehicle.Vehicle, newFuel);
        }

        [ScriptFunction("sendVehicleHeadlights")]
        public static void SendVehicleHeadlights()
        {
            VehicleManager.sendVehicleHeadlights();
        }

        [ScriptFunction("sendVehicleHealth")]
        public static void SendVehicleHealth(VehicleClass vehicle, ushort newHealth)
        {
            VehicleManager.sendVehicleHealth(vehicle.Vehicle, newHealth);
        }

        [ScriptFunction("sendVehicleHorn")]
        public static void SendVehicleHorn()
        {
            VehicleManager.sendVehicleHorn();
        }

        [ScriptFunction("sendVehicleLock")]
        public static void SendVehicleLock()
        {
            VehicleManager.sendVehicleLock();
        }

        [ScriptFunction("sendVehicleRecov")]
        public static void SendVehicleRecov(VehicleClass vehicle, Vector3Class newPosition, int newRecov)
        {
            VehicleManager.sendVehicleRecov(vehicle.Vehicle, newPosition.Vector3, newRecov);
        }

        [ScriptFunction("sendVehicleSkin")]
        public static void SendVehicleSkin()
        {
            VehicleManager.sendVehicleSkin();
        }

        [ScriptFunction("sendVehicleStealBattery")]
        public static void SendVehicleStealBattery()
        {
            VehicleManager.sendVehicleStealBattery();
        }

        [ScriptFunction("sendVehicleTireAliveMask")]
        public static void SendVehicleTireAliveMask(VehicleClass vehicle, byte newTireAliveMask)
        {
            VehicleManager.sendVehicleTireAliveMask(vehicle.Vehicle, newTireAliveMask);
        }

        [ScriptFunction("ServerSetVehicleLock")]
        public static void ServerSetVehicleLock(VehicleClass vehicle, string ownerID, string groupID, bool isLocked)
        {
            VehicleManager.ServerSetVehicleLock(vehicle.Vehicle, new CSteamID(ulong.Parse(ownerID)), new CSteamID(ulong.Parse(groupID)), isLocked);
        }

        [ScriptFunction("unlockVehicle")]
        public static void UnlockVehicle(VehicleClass vehicle, PlayerClass instigatingPlayer)
        {
            VehicleManager.unlockVehicle(vehicle.Vehicle, instigatingPlayer.Player);
        }
    }
}