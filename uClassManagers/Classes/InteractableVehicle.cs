using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using uClassManagers.Classes.Assets;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("InteractableVehicle")]
    public class InteractableVehicleClass
    {
        public InteractableVehicle vehicle { get; private set; }
        public InteractableVehicleClass(InteractableVehicle c_Vehicle) => vehicle = c_Vehicle;

        [ScriptProperty("trunkItems")]
        public ItemsClass TrunkItems => new ItemsClass(vehicle.trunkItems);

        [ScriptProperty("defaultCenterOfMass")]
        public Vector3Class DefaultCenterOfMass => new Vector3Class(vehicle.defaultCenterOfMass);

        [ScriptProperty("turn")]
        public int Turn => vehicle.turn;

        [ScriptProperty("instanceID")]
        public uint InstanceID => vehicle.instanceID;

        [ScriptProperty("roadIndex")]
        public ushort RoadIndex => vehicle.roadIndex;

        [ScriptProperty("id")]
        public ushort Id => vehicle.id;

        [ScriptProperty("skinID")]
        public ushort SkinID => vehicle.skinID;

        [ScriptProperty("mythicID")]
        public ushort MythicID => vehicle.mythicID;

        [ScriptProperty("batteryCharge")]
        public ushort BatteryCharge => vehicle.batteryCharge;

        [ScriptProperty("health")]
        public ushort Health => vehicle.health;

        [ScriptProperty("fuel")]
        public ushort Fuel => vehicle.fuel;

        [ScriptProperty("roadPosition")]
        public float RoadPosition => vehicle.roadPosition;

        [ScriptProperty("lastSeat")]
        public float LastSeat => vehicle.lastSeat;

        [ScriptProperty("timeInsideSafezone")]
        public float TimeInsideSafezone => vehicle.timeInsideSafezone;

        [ScriptProperty("lastDead")]
        public float LastDead => vehicle.lastDead;

        [ScriptProperty("lastExploded")]
        public float LastExploded => vehicle.lastExploded;

        [ScriptProperty("lastUnderwater")]
        public float LastUnderwater => vehicle.lastUnderwater;

        [ScriptProperty("slip")]
        public float Slip => vehicle.slip;

        [ScriptProperty("speed")]
        public float Speed => vehicle.speed;

        [ScriptProperty("physicsSpeed")]
        public float PhysicsSpeed => vehicle.physicsSpeed;

        [ScriptProperty("factor")]
        public float Factor => vehicle.factor;

        [ScriptProperty("steer")]
        public float Steer => vehicle.steer;

        [ScriptProperty("spedometer")]
        public float Spedometer => vehicle.spedometer;

        [ScriptProperty("hasDefaultCenterOfMass")]
        public bool HasDefaultCenterOfMass => vehicle.hasDefaultCenterOfMass;

        [ScriptProperty("isBlimpFloating")]
        public bool IsBlimpFloating => vehicle.isBlimpFloating;

        [ScriptProperty("isHooked")]
        public bool IsHooked => vehicle.isHooked;

        [ScriptProperty("isExploded")]
        public bool IsExploded => vehicle.isExploded;

        [ScriptProperty("isSiphonable")]
        public bool IsSiphonable => vehicle.isSiphonable;

        [ScriptProperty("anySeatsOccupied")]
        public bool AnySeatsOccupied => vehicle.anySeatsOccupied;

        [ScriptProperty("isRepaired")]
        public bool IsRepaired => vehicle.isRepaired;

        [ScriptProperty("isDriven")]
        public bool IsDriven => vehicle.isDriven;

        [ScriptProperty("isDriver")]
        public bool IsDriver => vehicle.isDriver;

        [ScriptProperty("canBeDamaged")]
        public bool CanBeDamaged => vehicle.canBeDamaged;

        [ScriptProperty("isDrowned")]
        public bool IsDrowned => vehicle.isDrowned;

        [ScriptProperty("isUnderwater")]
        public bool IsUnderwater => vehicle.isUnderwater;

        [ScriptProperty("isBatteryReplaceable")]
        public bool IsBatteryReplaceable => vehicle.isBatteryReplaceable;

        [ScriptProperty("isTireReplaceable")]
        public bool IsTireReplaceable => vehicle.isTireReplaceable;

        [ScriptProperty("isGoingToRespawn")]
        public bool IsGoingToRespawn => vehicle.isGoingToRespawn;

        [ScriptProperty("isRefillable")]
        public bool IsRefillable => vehicle.isRefillable;

        [ScriptProperty("isEmpty")]
        public bool IsEmpty => vehicle.isEmpty;

        [ScriptProperty("canTurnOnLights")]
        public bool CanTurnOnLights => vehicle.canTurnOnLights;

        [ScriptProperty("canUseHorn")]
        public bool CanUseHorn => vehicle.canUseHorn;

        [ScriptProperty("isBatteryFull")]
        public bool IsBatteryFull => vehicle.isBatteryFull;

        [ScriptProperty("hasBattery")]
        public bool HasBattery => vehicle.hasBattery;

        [ScriptProperty("isEnginePowered")]
        public bool IsEnginePowered => vehicle.isEnginePowered;

        [ScriptProperty("isEngineOn")]
        public bool IsEngineOn => vehicle.isEngineOn;

        [ScriptProperty("isBoosting")]
        public bool IsBoosting => vehicle.isBoosting;

        [ScriptProperty("usesHealth")]
        public bool UsesHealth => vehicle.usesHealth;

        [ScriptProperty("usesBattery")]
        public bool UsesBattery => vehicle.usesBattery;

        [ScriptProperty("usesFuel")]
        public bool UsesFuel => vehicle.usesFuel;

        [ScriptProperty("isInsideNoDamageZone")]
        public bool IsInsideNoDamageZone => vehicle.isInsideNoDamageZone;

        [ScriptProperty("isAutoClearable")]
        public bool IsAutoClearable => vehicle.isAutoClearable;

        [ScriptProperty("isInsideSafezone")]
        public bool IsInsideSafezone => vehicle.isInsideSafezone;

        [ScriptProperty("canUseTurret")]
        public bool CanUseTurret => vehicle.canUseTurret;

        [ScriptProperty("sirensOn")]
        public bool SirensOn => vehicle.sirensOn;

        [ScriptProperty("isExitable")]
        public bool IsExitable => vehicle.isExitable;

        [ScriptProperty("isSkinned")]
        public bool IsSkinned => vehicle.isSkinned;

        [ScriptProperty("isLocked")]
        public bool IsLocked => vehicle.isLocked;

        [ScriptProperty("taillightsOn")]
        public bool TaillightsOn => vehicle.taillightsOn;

        [ScriptProperty("headlightsOn")]
        public bool HeadlightsOn => vehicle.headlightsOn;

        [ScriptProperty("isDead")]
        public bool IsDead => vehicle.isDead;

        [ScriptProperty("tireAliveMask")]
        public byte TireAliveMask
        {
            get => vehicle.tireAliveMask;
            set => vehicle.tireAliveMask = value;
        }

        [ScriptProperty("asset")]
        public VehicleAssetClass Asset => new VehicleAssetClass(vehicle.asset);

        [ScriptProperty("tires")]
        public ExpressionValue Tires
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (Wheel wheel in vehicle.tires)
                {
                    list.Add(ExpressionValue.CreateObject(new WheelClass(wheel)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptProperty("turrets")]
        public ExpressionValue Turrets
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (Passenger passenger in vehicle.turrets)
                {
                    list.Add(ExpressionValue.CreateObject(new PassengerClass(passenger)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptProperty("passengers")]
        public ExpressionValue Passengers
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (Passenger passenger in vehicle.passengers)
                {
                    list.Add(ExpressionValue.CreateObject(new PassengerClass(passenger)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptProperty("headlights")]
        public TransformClass Headlights => new TransformClass(vehicle.headlights);

        [ScriptProperty("taillights")]
        public TransformClass Taillights => new TransformClass(vehicle.taillights);

        [ScriptProperty("lockedGroup")]
        public string LockedGroup => vehicle.lockedGroup.m_SteamID.ToString();

        [ScriptProperty("lockedOwner")]
        public string LockedOwner => vehicle.lockedOwner.m_SteamID.ToString();

        [ScriptFunction("use")]
        public void Use() => vehicle.use();

        [ScriptFunction("checkUseable")]
        public void CheckUseable() => vehicle.checkUseable();

        [ScriptFunction("getHitTireIndex")]
        public int GetHitTireIndex(Vector3Class position) => vehicle.getHitTireIndex(position.Vector3);

        [ScriptFunction("getClosestAliveTireIndex")]
        public int GetClosestAliveTireIndex(Vector3Class position, bool isAlive) => vehicle.getClosestAliveTireIndex(position.Vector3, isAlive);

        [ScriptFunction("getSqrDistanceFromHull")]
        public float GetSqrDistanceFromHull(Vector3Class position) => vehicle.getSqrDistanceFromHull(position.Vector3);

        [ScriptFunction("getClosestPointOnHull")]
        public Vector3Class GetClosestPointOnHull(Vector3Class position) => new Vector3Class(vehicle.getClosestPointOnHull(position.Vector3));

        [ScriptFunction("addPlayer")]
        public void AddPlayer(byte seat, PlayerClass player)
        {
            vehicle.addPlayer(seat, player.Player.channel.owner.playerID.steamID);
        }

        [ScriptFunction("askBurnBattery")]
        public void AskBurnBattery(ushort amount)
        {
            vehicle.askBurnBattery(amount);
        }

        [ScriptFunction("askBurnFuel")]
        public void AskBurnFuel(ushort amount)
        {
            vehicle.askBurnFuel(amount);
        }

        [ScriptFunction("askChargeBattery")]
        public void AskChargeBattery(ushort amount)
        {
            vehicle.askChargeBattery(amount);
        }

        [ScriptFunction("askDamage")]
        public void AskDamage(ushort amount, bool canRepair)
        {
            vehicle.askDamage(amount, canRepair);
        }

        [ScriptFunction("askDamageTire")]
        public void AskDamageTire(int index)
        {
            vehicle.askDamageTire(index);
        }

        [ScriptFunction("askFillFuel")]
        public void AskFillFuel(ushort amount)
        {
            vehicle.askFillFuel(amount);
        }

        [ScriptFunction("askRepair")]
        public void AskRepair(ushort amount)
        {
            vehicle.askRepair(amount);
        }

        [ScriptFunction("askRepairTire")]
        public void AskRepairTire(int index)
        {
            vehicle.askRepairTire(index);
        }

        [ScriptFunction("clearHooked")]
        public void ClearHooked()
        {
            vehicle.clearHooked();
        }

        [ScriptFunction("dropTrunkItems")]
        public void DropTrunkItems()
        {
            vehicle.dropTrunkItems();
        }

        [ScriptFunction("forceRemoveAllPlayers")]
        public void ForceRemoveAllPlayers()
        {
            vehicle.forceRemoveAllPlayers();
        }

        [ScriptFunction("grantTrunkAccess")]
        public void GrantTrunkAccess(PlayerClass player)
        {
            vehicle.grantTrunkAccess(player.Player);
        }

        [ScriptFunction("removePlayer")]
        public void RemovePlayer(byte seatIndex, Vector3Class point, byte angle, bool forceUpdate)
        {
            vehicle.removePlayer(seatIndex, point.Vector3, angle, forceUpdate);
        }

        [ScriptFunction("replaceBattery")]
        public void ReplaceBattery(PlayerClass player, byte quality)
        {
            vehicle.replaceBattery(player.Player, quality);
        }

        [ScriptFunction("replaceBattery")]
        public void ReplaceBattery(PlayerClass player, byte quality, string newBatteryItemGuid)
        {
            vehicle.replaceBattery(player.Player, quality, Guid.Parse(newBatteryItemGuid));
        }

        [ScriptFunction("ResetDecayTimer")]
        public void ResetDecayTimer()
        {
            vehicle.ResetDecayTimer();
        }

        [ScriptFunction("revokeTrunkAccess")]
        public void RevokeTrunkAccess(PlayerClass player)
        {
            vehicle.revokeTrunkAccess(player.Player);
        }

        [ScriptFunction("sendBatteryChargeUpdate")]
        public void SendBatteryChargeUpdate()
        {
            vehicle.sendBatteryChargeUpdate();
        }

        [ScriptFunction("sendTireAliveMaskUpdate")]
        public void SendTireAliveMaskUpdate()
        {
            vehicle.sendTireAliveMaskUpdate();
        }

        [ScriptFunction("simulate")]
        public void Simulate(uint simulation, int recov, bool inputStamina, Vector3Class point, Vector3Class angle, float newSpeed, float newPhysicsSpeed, int newTurn, float delta)
        {
            vehicle.simulate(simulation, recov, inputStamina, point.Vector3, Quaternion.Euler(angle.Vector3), newSpeed, newPhysicsSpeed, newTurn, delta);
        }

        [ScriptFunction("simulateClient")]
        public void Simulate(uint simulation, int recov, int input_x, int input_y, float look_x, float look_y, bool inputBrake, bool inputStamina, float delta)
        {
            vehicle.simulate(simulation, recov, input_x, input_y, look_x, look_y, inputBrake, inputStamina, delta);
        }

        [ScriptFunction("stealBattery")]
        public void StealBattery(PlayerClass player)
        {
            vehicle.stealBattery(player.Player);
        }

        [ScriptFunction("swapPlayer")]
        public void SwapPlayer(byte fromSeatIndex, byte toSeatIndex)
        {
            vehicle.swapPlayer(fromSeatIndex, toSeatIndex);
        }

        [ScriptFunction("tellBatteryCharge")]
        public void TellBatteryCharge(ushort newBatteryCharge)
        {
            vehicle.tellBatteryCharge(newBatteryCharge);
        }

        [ScriptFunction("tellBlimp")]
        public void TellBlimp(bool on)
        {
            vehicle.tellBlimp(on);
        }

        [ScriptFunction("tellExploded")]
        public void TellExploded()
        {
            vehicle.tellExploded();
        }

        [ScriptFunction("tellFuel")]
        public void TellFuel(ushort newFuel)
        {
            vehicle.tellFuel(newFuel);
        }

        [ScriptFunction("tellHeadlights")]
        public void TellHeadlights(bool on)
        {
            vehicle.tellHeadlights(on);
        }

        [ScriptFunction("tellHealth")]
        public void TellHealth(ushort newHealth)
        {
            vehicle.tellHealth(newHealth);
        }

        [ScriptFunction("tellHorn")]
        public void TellHorn()
        {
            vehicle.tellHorn();
        }

        [ScriptFunction("tellLocked")]
        public void TellLocked(PlayerClass owner, PlayerClass group, bool locked)
        {
            vehicle.tellLocked(owner.Player.channel.owner.playerID.steamID, group.Player.channel.owner.playerID.steamID, locked);
        }

        [ScriptFunction("tellRecov")]
        public void TellRecov(Vector3Class newPosition, int newRecov)
        {
            vehicle.tellRecov(newPosition.Vector3, newRecov);
        }

        [ScriptFunction("tellSirens")]
        public void TellSirens(bool on)
        {
            vehicle.tellSirens(on);
        }

        [ScriptFunction("tellSkin")]
        public void TellSkin(ushort newSkinID, ushort newMythicID)
        {
            vehicle.tellSkin(newSkinID, newMythicID);
        }

        [ScriptFunction("tellState")]
        public void TellState(Vector3Class newPosition, Vector3Class newRotation, byte newSpeed, byte newPhysicsSpeed, byte newTurn)
        {
            vehicle.tellState(newPosition.Vector3, Quaternion.Euler(newRotation.Vector3), newSpeed, newPhysicsSpeed, newTurn);
        }

        [ScriptFunction("tellTaillights")]
        public void TellTaillights(bool on)
        {
            vehicle.tellTaillights(on);
        }

        [ScriptFunction("updateEngine")]
        public void UpdateEngine()
        {
            vehicle.updateEngine();
        }

        [ScriptFunction("updateFires")]
        public void UpdateFires()
        {
            vehicle.updateFires();
        }

        [ScriptFunction("updatePhysics")]
        public void UpdatePhysics()
        {
            vehicle.updatePhysics();
        }

        [ScriptFunction("updateSkin")]
        public void UpdateSkin()
        {
            vehicle.updateSkin();
        }

        [ScriptFunction("updateVehicle")]
        public void UpdateVehicle()
        {
            vehicle.updateVehicle();
        }

        [ScriptFunction("useHook")]
        public void UseHook()
        {
            vehicle.useHook();
        }

        [ScriptFunction("canPlayerRepair")]
        public bool CanPlayerRepair(PlayerClass player)
        {
            return vehicle.canPlayerRepair(player.Player);
        }

        [ScriptFunction("checkDriver")]
        public bool CheckDriver(string steamID)
        {
            return vehicle.checkDriver(new CSteamID(ulong.Parse(steamID)));
        }

        [ScriptFunction("checkEnter")]
        public bool CheckEnter(PlayerClass player)
        {
            return vehicle.checkEnter(player.Player);
        }

        [ScriptFunction("checkEnter")]
        public bool CheckEnter(string enemyPlayer, string enemyGroup)
        {
            return vehicle.checkEnter(new CSteamID(ulong.Parse(enemyPlayer)), new CSteamID(ulong.Parse(enemyGroup)));
        }

        [ScriptFunction("isTireCompatible")]
        public bool IsTireCompatible(ushort itemID)
        {
            return vehicle.isTireCompatible(itemID);
        }

        [ScriptFunction("findPlayerSeat")]
        public ExpressionValue FindPlayerSeat(PlayerClass player)
        {
            bool hasFoundSeat = vehicle.findPlayerSeat(player.Player, out byte seat);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasFoundSeat, seat };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("findPlayerSeat")]
        public ExpressionValue FindPlayerSeat(string playerId)
        {
            bool hasFoundSeat = vehicle.findPlayerSeat(new CSteamID(ulong.Parse(playerId)), out byte seat);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasFoundSeat, seat };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("forceRemovePlayer")]
        public ExpressionValue ForceRemovePlayer(PlayerClass player)
        {
            bool hasRemovedPlayer = vehicle.forceRemovePlayer(out byte seat, player.Player.channel.owner.playerID.steamID, out Vector3 point, out byte angle);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasRemovedPlayer, seat, ExpressionValue.CreateObject(new Vector3Class(point)), angle };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("tryAddPlayer")]
        public ExpressionValue TryAddPlayer(PlayerClass player)
        {
            bool hasAddedPlayer = vehicle.tryAddPlayer(out byte seat, player.Player);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasAddedPlayer, seat };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("trySwapPlayer")]
        public ExpressionValue TrySwapPlayer(PlayerClass player, byte toSeat)
        {
            bool hasSwapped = vehicle.trySwapPlayer(player.Player, toSeat, out byte fromSeat);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasSwapped, fromSeat };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("getDisplayFuel")]
        public ExpressionValue GetDisplayFuel()
        {
            vehicle.getDisplayFuel(out ushort currentFuel, out ushort maxFuel);
            List<ExpressionValue> list = new List<ExpressionValue>() { currentFuel, maxFuel };
            return ExpressionValue.Array(list.ToArray());
        }
    }
}