using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using uClassManagers.uClasses;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClassExtensions
{
    [ScriptTypeExtension(typeof(VehicleClass))]
    public class VehicleClassExtension
    {
        // Read only section

        [ScriptFunction("get_passengers")]
        public static ExpressionValue Passengers([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return null;
            if (vehicle.Vehicle.passengers == null || vehicle.Vehicle.passengers.Length <= 0) return null;

            List<ExpressionValue> passengers = new List<ExpressionValue>();

            foreach (Passenger passenger in vehicle.Vehicle.passengers)
            {
                passengers.Add(ExpressionValue.CreateObject(new PlayerClass(passenger.player.player)));
            }

            return ExpressionValue.Array(passengers.ToArray());
        }

        [ScriptFunction("get_tires")]
        public static ExpressionValue Tires([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return null;
            if (vehicle.Vehicle.tires == null || vehicle.Vehicle.tires.Length <= 0) return null;

            List<ExpressionValue> tires = new List<ExpressionValue>();

            foreach (Wheel wheel in vehicle.Vehicle.tires)
            {
                tires.Add(ExpressionValue.CreateObject(new TransformClass(wheel.model)));
            }

            return ExpressionValue.Array(tires.ToArray());
        }

        [ScriptFunction("get_hasDefaultCenterOfMass")]
        public static bool HasDefaultCenterOfMass([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.hasDefaultCenterOfMass : false;

        [ScriptFunction("get_isBlimpFloating")]
        public static bool IsBlimpFloating([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isBlimpFloating : false;

        [ScriptFunction("get_isHooked")]
        public static bool IsHooked([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isHooked : false;

        [ScriptFunction("get_isExploded")]
        public static bool IsExploded([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isExploded : false;

        [ScriptFunction("get_factor")]
        public static float Factor([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.factor : float.NaN;

        [ScriptFunction("get_lastDead")]
        public static float LastDead([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.lastDead : float.NaN;

        [ScriptFunction("get_lastExploded")]
        public static float LastExploded([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.lastExploded : float.NaN;

        [ScriptFunction("get_lastSeat")]
        public static float LastSeat([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.lastSeat : float.NaN;

        [ScriptFunction("get_lastUnderwater")]
        public static float LastUnderwater([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.lastUnderwater : float.NaN;

        [ScriptFunction("get_physicsSpeed")]
        public static float PhysicsSpeed([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.physicsSpeed : float.NaN;

        [ScriptFunction("get_roadPosition")]
        public static float RoadPosition([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.roadPosition : float.NaN;

        [ScriptFunction("get_slip")]
        public static float Slip([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.slip : float.NaN;

        [ScriptFunction("get_spedometer")]
        public static float Spedometer([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.spedometer : float.NaN;

        [ScriptFunction("get_speed")]
        public static float Speed([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.speed : float.NaN;

        [ScriptFunction("get_steer")]
        public static float Steer([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.steer : float.NaN;

        [ScriptFunction("get_timeInsideSafezone")]
        public static float TimeInsideSafezone([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.timeInsideSafezone : float.NaN;

        [ScriptFunction("get_batteryCharge")]
        public static ushort BatteryCharge([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.batteryCharge : ushort.MinValue;

        [ScriptFunction("get_fuel")]
        public static ushort Fuel([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.fuel : ushort.MinValue;

        [ScriptFunction("get_health")]
        public static ushort Health([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.health : ushort.MinValue;

        [ScriptFunction("get_id")]
        public static ushort Id([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.id : ushort.MinValue;

        [ScriptFunction("get_mythicID")]
        public static ushort MythicID([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.mythicID : ushort.MinValue;

        [ScriptFunction("get_roadIndex")]
        public static ushort RoadIndex([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.roadIndex : ushort.MinValue;

        [ScriptFunction("get_anySeatsOccupied")]
        public static bool AnySeatsOccupied([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.anySeatsOccupied : false;

        [ScriptFunction("get_canBeDamaged")]
        public static bool CanBeDamaged([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.canBeDamaged : false;

        [ScriptFunction("get_canTurnOnLights")]
        public static bool CanTurnOnLights([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.canTurnOnLights : false;

        [ScriptFunction("get_canUseHorn")]
        public static bool CanUseHorn([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.canUseHorn : false;

        [ScriptFunction("get_canUseTurret")]
        public static bool CanUseTurret([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.canUseTurret : false;

        [ScriptFunction("get_hasBattery")]
        public static bool HasBattery([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.hasBattery : false;

        [ScriptFunction("get_headlightsOn")]
        public static bool HeadlightsOn([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.headlightsOn : false;

        [ScriptFunction("get_isAutoClearable")]
        public static bool IsAutoClearable([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isAutoClearable : false;

        [ScriptFunction("get_isBatteryFull")]
        public static bool IsBatteryFull([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isBatteryFull : false;

        [ScriptFunction("get_isBatteryReplaceable")]
        public static bool IsBatteryReplaceable([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isBatteryReplaceable : false;

        [ScriptFunction("get_isBoosting")]
        public static bool IsBoosting([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isBoosting : false;

        [ScriptFunction("get_isDead")]
        public static bool IsDead([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isDead : false;

        [ScriptFunction("get_isDriven")]
        public static bool IsDriven([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isDriven : false;

        [ScriptFunction("get_isDriver")]
        public static bool IsDriver([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isDriver : false;

        [ScriptFunction("get_isDrowned")]
        public static bool IsDrowned([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isDrowned : false;

        [ScriptFunction("get_isEmpty")]
        public static bool IsEmpty([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isEmpty : false;

        [ScriptFunction("get_isEngineOn")]
        public static bool IsEngineOn([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isEngineOn : false;

        [ScriptFunction("get_isEnginePowered")]
        public static bool IsEnginePowered([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isEnginePowered : false;

        [ScriptFunction("get_isExitable")]
        public static bool IsExitable([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isExitable : false;

        [ScriptFunction("get_isGoingToRespawn")]
        public static bool IsGoingToRespawn([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isGoingToRespawn : false;

        [ScriptFunction("get_isInsideNoDamageZone")]
        public static bool IsInsideNoDamageZone([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isInsideNoDamageZone : false;

        [ScriptFunction("get_isInsideSafezone")]
        public static bool IsInsideSafezone([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isInsideSafezone : false;

        [ScriptFunction("get_isLocked")]
        public static bool IsLocked([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isLocked : false;

        [ScriptFunction("get_isRefillable")]
        public static bool IsRefillable([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isRefillable : false;

        [ScriptFunction("get_isRepaired")]
        public static bool IsRepaired([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isRepaired : false;

        [ScriptFunction("get_isSiphonable")]
        public static bool IsSiphonable([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isSiphonable : false;

        [ScriptFunction("get_isSkinned")]
        public static bool IsSkinned([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isSkinned : false;

        [ScriptFunction("get_isTireReplaceable")]
        public static bool IsTireReplaceable([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isTireReplaceable : false;

        [ScriptFunction("get_isUnderwater")]
        public static bool IsUnderwater([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.isUnderwater : false;

        [ScriptFunction("get_sirensOn")]
        public static bool SirensOn([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.sirensOn : false;

        [ScriptFunction("get_taillightsOn")]
        public static bool TaillightsOn([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.taillightsOn : false;

        [ScriptFunction("get_usesBattery")]
        public static bool UsesBattery([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.usesBattery : false;

        [ScriptFunction("get_usesFuel")]
        public static bool UsesFuel([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.usesFuel : false;

        [ScriptFunction("get_usesHealth")]
        public static bool UsesHealth([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.usesHealth : false;

        [ScriptFunction("get_defaultCenterOfMass")]
        public static Vector3Class DefaultCenterOfMass([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? new Vector3Class(vehicle.Vehicle.defaultCenterOfMass) : null;

        [ScriptFunction("get_asset")]
        public static VehicleAssetClass Asset([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? new VehicleAssetClass(vehicle.Vehicle.asset) : null;

        [ScriptFunction("get_lockedOwner")]
        public static string LockedOwner([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.lockedOwner.ToString() : null;

        [ScriptFunction("get_lockedGroup")]
        public static string LockedGroup([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.lockedGroup.ToString() : null;

        [ScriptFunction("get_tireAliveMask")]
        public static byte TireAliveMask([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.tireAliveMask : byte.MinValue;

        [ScriptFunction("get_turn")]
        public static int Turn([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.turn : int.MinValue;

        [ScriptFunction("get_instanceID")]
        public static uint InstanceID([ScriptInstance] ExpressionValue instance) => instance.Data is VehicleClass vehicle ? vehicle.Vehicle.instanceID : uint.MaxValue;

        // Functions

        [ScriptFunction("getHitTireIndex")]
        public static int GetHitTireIndex([ScriptInstance] ExpressionValue instance, Vector3Class position)
        {
            if (!(instance.Data is VehicleClass vehicle)) return int.MinValue;
            return vehicle.Vehicle.getHitTireIndex(position.Vector3);
        }

        [ScriptFunction("getClosestAliveTireIndex")]
        public static int GetClosestAliveTireIndex([ScriptInstance] ExpressionValue instance, Vector3Class position, bool isAlive)
        {
            if (!(instance.Data is VehicleClass vehicle)) return int.MinValue;
            return vehicle.Vehicle.getClosestAliveTireIndex(position.Vector3, isAlive);
        }


        [ScriptFunction("canPlayerRepair")]
        public static bool CanPlayerRepair([ScriptInstance] ExpressionValue instance, PlayerClass player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return false;
            return vehicle.Vehicle.canPlayerRepair(player.Player);
        }


        [ScriptFunction("checkDriver")]
        public static bool CheckDriver([ScriptInstance] ExpressionValue instance, string player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return false;
            return vehicle.Vehicle.checkDriver(new CSteamID(ulong.Parse(player)));
        }

        [ScriptFunction("checkEnter")]
        public static bool CheckEnter([ScriptInstance] ExpressionValue instance, PlayerClass player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return false;
            return vehicle.Vehicle.checkEnter(player.Player);
        }

        [ScriptFunction("checkEnter")]
        public static bool CheckEnter([ScriptInstance] ExpressionValue instance, string enemyPlayer, string enemyGroup)
        {
            if (!(instance.Data is VehicleClass vehicle)) return false;
            return vehicle.Vehicle.checkEnter(new CSteamID(ulong.Parse(enemyPlayer)), new CSteamID(ulong.Parse(enemyGroup)));
        }

        [ScriptFunction("findPlayerSeat")]
        public static ExpressionValue FindPlayerSeat([ScriptInstance] ExpressionValue instance, PlayerClass player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return ExpressionValue.Null;
            bool seatBool = false;
            byte seat = 0;

            List<ExpressionValue> resultArray = new List<ExpressionValue>() { seatBool, seat };
            seatBool = vehicle.Vehicle.findPlayerSeat(player.Player, out seat);
            return ExpressionValue.Array(resultArray.ToArray());
        }

        [ScriptFunction("forceRemovePlayer")]
        public static ExpressionValue ForceRemovePlayer([ScriptInstance] ExpressionValue instance, PlayerClass player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return ExpressionValue.Null;

            bool forceRemovePlayerResult = vehicle.Vehicle.forceRemovePlayer(out byte seat, player.Player.channel.owner.playerID.steamID, out Vector3 point, out byte angle);
            List<ExpressionValue> resultArray = new List<ExpressionValue>() { ExpressionValue.CreateObject(new Vector3Class(point)), forceRemovePlayerResult, seat, angle };
            return ExpressionValue.Array(resultArray.ToArray());
        }

        [ScriptFunction("isTireCompatible")]
        public static bool IsTireCompatible([ScriptInstance] ExpressionValue instance, ushort itemID)
        {
            if (!(instance.Data is VehicleClass vehicle)) return false;
            return vehicle.Vehicle.isTireCompatible(itemID);
        }

        [ScriptFunction("tryAddPlayer")]
        public static ExpressionValue TryAddPlayer([ScriptInstance] ExpressionValue instance, PlayerClass player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return ExpressionValue.Null;
            bool tryAddPlayerResult = vehicle.Vehicle.tryAddPlayer(out byte seat, player.Player);
            List<ExpressionValue> resultArray = new List<ExpressionValue>() { tryAddPlayerResult, seat };
            return ExpressionValue.Array(resultArray.ToArray());
        }

        [ScriptFunction("trySwapPlayer")]
        public static ExpressionValue TrySwapPlayer([ScriptInstance] ExpressionValue instance, PlayerClass player, byte toSeat)
        {
            if (!(instance.Data is VehicleClass vehicle)) return ExpressionValue.Null;
            bool trySwapPlayerResult = vehicle.Vehicle.trySwapPlayer(player.Player, toSeat, out byte fromSeat);
            List<ExpressionValue> resultArray = new List<ExpressionValue>() { trySwapPlayerResult, fromSeat };
            return ExpressionValue.Array(resultArray.ToArray());
        }

        [ScriptFunction("addPlayer")]
        public static void AddPlayer([ScriptInstance] ExpressionValue instance, PlayerClass player, byte seat)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.addPlayer(seat, player.Player.channel.owner.playerID.steamID);
        }

        [ScriptFunction("askBurnBattery")]
        public static void AskBurnBattery([ScriptInstance] ExpressionValue instance, ushort amount)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.askBurnBattery(amount);
        }

        [ScriptFunction("askBurnFuel")]
        public static void AskBurnFuel([ScriptInstance] ExpressionValue instance, ushort amount)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.askBurnFuel(amount);
        }

        [ScriptFunction("askChargeBattery")]
        public static void AskChargeBattery([ScriptInstance] ExpressionValue instance, ushort amount)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.askChargeBattery(amount);
        }

        [ScriptFunction("askDamage")]
        public static void AskDamage([ScriptInstance] ExpressionValue instance, ushort amount, bool canRepair)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.askDamage(amount, canRepair);
        }

        [ScriptFunction("askDamageTire")]
        public static void AskDamageTire([ScriptInstance] ExpressionValue instance, int index)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.askDamageTire(index);
        }

        [ScriptFunction("askFillFuel")]
        public static void AskFillFuel([ScriptInstance] ExpressionValue instance, ushort amount)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.askFillFuel(amount);
        }

        [ScriptFunction("askRepair")]
        public static void AskRepair([ScriptInstance] ExpressionValue instance, ushort amount)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.askRepair(amount);
        }

        [ScriptFunction("askRepairTire")]
        public static void AskRepairTire([ScriptInstance] ExpressionValue instance, int index)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.askRepairTire(index);
        }

        [ScriptFunction("getDisplayFuel")]
        public static ExpressionValue GetDisplayFuel([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return ExpressionValue.Null;
            vehicle.Vehicle.getDisplayFuel(out ushort currentFuel, out ushort maxFuel);
            List<ExpressionValue> resultArray = new List<ExpressionValue>() { currentFuel, maxFuel };
            return ExpressionValue.Array(resultArray.ToArray());

        }

        [ScriptFunction("grantTrunkAccess")]
        public static void GrantTrunkAccess([ScriptInstance] ExpressionValue instance, PlayerClass player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.grantTrunkAccess(player.Player);
        }

        [ScriptFunction("removePlayer")]
        public static void RemovePlayer([ScriptInstance] ExpressionValue instance, byte seatIndex, Vector3Class point, byte angle, bool forceUpdate)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.removePlayer(seatIndex, point.Vector3, angle, forceUpdate);
        }

        [ScriptFunction("replaceBattery")]
        public static void ReplaceBattery([ScriptInstance] ExpressionValue instance, PlayerClass player, byte quality)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.replaceBattery(player.Player, quality);
        }

        [ScriptFunction("replaceBattery")]
        public static void ReplaceBattery([ScriptInstance] ExpressionValue instance, PlayerClass player, byte quality, string newBatteryItemGuid)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.replaceBattery(player.Player, quality, Guid.Parse(newBatteryItemGuid));
        }

        [ScriptFunction("revokeTrunkAccess")]
        public static void RevokeTrunkAccess([ScriptInstance] ExpressionValue instance, PlayerClass player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.revokeTrunkAccess(player.Player);
        }

        [ScriptFunction("simulate")]
        public static void Simulate([ScriptInstance] ExpressionValue instance, uint simulation, int recov, bool inputStamina, Vector3Class point, Vector3Class angle, float newSpeed, float newPhysicsSpeed, int newTurn, float delta)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.simulate(simulation, recov, inputStamina, point.Vector3, Quaternion.Euler(angle.Vector3), newSpeed, newPhysicsSpeed, newTurn, delta);
        }

        [ScriptFunction("simulate")]
        public static void Simulate([ScriptInstance] ExpressionValue instance, uint simulation, int recov, int input_x, int input_y, float look_x, float look_y, bool inputBrake, bool inputStamina, float delta)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.simulate(simulation, recov, input_x, input_y, look_x, look_y, inputBrake, inputStamina, delta);
        }

        [ScriptFunction("stealBattery")]
        public static void StealBattery([ScriptInstance] ExpressionValue instance, PlayerClass player)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.stealBattery(player.Player);
        }

        [ScriptFunction("swapPlayer")]
        public static void SwapPlayer([ScriptInstance] ExpressionValue instance, byte fromSeatIndex, byte toSeatIndex)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.swapPlayer(fromSeatIndex, toSeatIndex);
        }

        [ScriptFunction("tellBatteryCharge")]
        public static void TellBatteryCharge([ScriptInstance] ExpressionValue instance, ushort newBatteryCharge)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellBatteryCharge(newBatteryCharge);
        }

        [ScriptFunction("tellBlimp")]
        public static void TellBlimp([ScriptInstance] ExpressionValue instance, bool on)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellBlimp(on);
        }

        [ScriptFunction("tellFuel")]
        public static void TellFuel([ScriptInstance] ExpressionValue instance, ushort newFuel)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellFuel(newFuel);
        }

        [ScriptFunction("tellHeadlights")]
        public static void TellHeadlights([ScriptInstance] ExpressionValue instance, bool on)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellHeadlights(on);
        }

        [ScriptFunction("tellHealth")]
        public static void TellHealth([ScriptInstance] ExpressionValue instance, ushort newHealth)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellHealth(newHealth);
        }

        [ScriptFunction("tellLocked")]
        public static void TellLocked([ScriptInstance] ExpressionValue instance, string owner, string group, bool locked)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellLocked(new CSteamID(ulong.Parse(owner)), new CSteamID(ulong.Parse(group)), locked);
        }

        [ScriptFunction("tellRecov")]
        public static void TellRecov([ScriptInstance] ExpressionValue instance, Vector3Class newPosition, int newRecov)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellRecov(newPosition.Vector3, newRecov);
        }

        [ScriptFunction("tellSirens")]
        public static void TellSirens([ScriptInstance] ExpressionValue instance, bool on)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellSirens(on);
        }

        [ScriptFunction("tellSkin")]
        public static void TellSkin([ScriptInstance] ExpressionValue instance, ushort newSkinID, ushort newMythicID)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellSkin(newSkinID, newMythicID);
        }

        [ScriptFunction("tellState")]
        public static void TellState([ScriptInstance] ExpressionValue instance, Vector3Class newPosition, Vector3Class newRotation, byte newSpeed, byte newPhysicsSpeed, byte newTurn)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellState(newPosition.Vector3, Quaternion.Euler(newRotation.Vector3), newSpeed, newPhysicsSpeed, newTurn);
        }

        [ScriptFunction("tellTaillights")]
        public static void TellTaillights([ScriptInstance] ExpressionValue instance, bool on)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellTaillights(on);
        }

        [ScriptFunction("forceRemoveAllPlayers")]
        public static void ForceRemoveAllPlayers([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.forceRemoveAllPlayers();
        }

        [ScriptFunction("clearHooked")]
        public static void ClearHooked([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.clearHooked();
        }

        [ScriptFunction("dropTrunkItems")]
        public static void DropTrunkItems([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.dropTrunkItems();
        }

        [ScriptFunction("sendBatteryChargeUpdate")]
        public static void SendBatteryChargeUpdate([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.sendBatteryChargeUpdate();
        }

        [ScriptFunction("sendTireAliveMaskUpdate")]
        public static void SendTireAliveMaskUpdate([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.sendTireAliveMaskUpdate();
        }

        [ScriptFunction("tellExploded")]
        public static void TellExploded([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellExploded();
        }

        [ScriptFunction("ResetDecayTimer")]
        public static void ResetDecayTimer([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.ResetDecayTimer();
        }

        [ScriptFunction("tellHorn")]
        public static void TellHorn([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.tellHorn();
        }

        [ScriptFunction("updateEngine")]
        public static void UpdateEngine([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.updateEngine();
        }

        [ScriptFunction("updateFires")]
        public static void UpdateFires([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.updateFires();
        }

        [ScriptFunction("updatePhysics")]
        public static void UpdatePhysics([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.updatePhysics();
        }

        [ScriptFunction("updateSkin")]
        public static void UpdateSkin([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.updateSkin();
        }

        [ScriptFunction("updateVehicle")]
        public static void UpdateVehicle([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicle)) return;
            vehicle.Vehicle.updateVehicle();
        }

        [ScriptFunction("updateVehicle")]
        public static Vector3Class UpdateVehicle([ScriptInstance] ExpressionValue instance, Vector3Class position)
        {
            if (!(instance.Data is VehicleClass vehicle)) return null;
            return new Vector3Class(vehicle.Vehicle.getClosestPointOnHull(position.Vector3));
        }

        [ScriptFunction("getSqrDistanceFromHull")]
        public static float GetSqrDistanceFromHull([ScriptInstance] ExpressionValue instance, Vector3Class position)
        {
            if (!(instance.Data is VehicleClass vehicle)) return float.NaN;
            return vehicle.Vehicle.getSqrDistanceFromHull(position.Vector3);
        }
    }
}
