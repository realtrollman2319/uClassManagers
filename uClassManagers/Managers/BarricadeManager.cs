using SDG.Unturned;
using System;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

#pragma warning disable CS0612
namespace uClassManagers.Managers
{
    [ScriptModule("BarricadeManager")]
    public class BarricadeManagerClass
    {
        [ScriptFunction("askClearAllBarricades")]
        public static void AskClearAllBarricades()
        {
            BarricadeManager.askClearAllBarricades();
        }

        [ScriptFunction("askClearRegionBarricades")]
        public static void AskClearRegionBarricades(byte x, byte y)
        {
            BarricadeManager.askClearRegionBarricades(x, y);
        }

        [ScriptFunction("changeOwnerAndGroup")]
        public static void ChangeOwnerAndGroup(BarricadeClass barricade, string newOwner = "0", string newGroup = "0")
        {
            BarricadeManager.changeOwnerAndGroup(barricade.BarricadeTransform, ulong.Parse(newOwner), ulong.Parse(newGroup));;
        }

        [ScriptFunction("clearPlants")]
        public static void clearPlants()
        {
            BarricadeManager.clearPlants();
        }

        // Barricade section
        [ScriptFunction("dropPlantedBarricade")] // For vehicles
        public static BarricadeClass DropPlantedBarricade(ushort id, VehicleClass vehicle, Vector3Class localPosition, float rx, float ry, float rz, string owner = "0", string group = "0")
        {
            Barricade barricade = new Barricade(id);
            if (barricade.asset == null) return (BarricadeClass)null;
            ItemBarricadeAsset itemBarricadeAsset = barricade.asset;

            ulong parsedOwner = Convert.ToUInt64(owner);
            ulong parsedGroup = Convert.ToUInt64(group);

            if (barricade.state.Length >= 8)
            {
                BitConverter.GetBytes(parsedOwner).CopyTo(barricade.state, 0);
                if (barricade.state.Length >= 16)
                    BitConverter.GetBytes(parsedGroup).CopyTo(barricade.state, 8);
            }

            Transform tBarricade = BarricadeManager.dropPlantedBarricade(vehicle.Vehicle.transform, barricade, localPosition.Vector3, Quaternion.Euler(rx, ry, rz), parsedOwner, parsedGroup);
            BarricadeClass uBarricade = new BarricadeClass(tBarricade);
            return uBarricade;
        }

        [ScriptFunction("dropNonPlantedBarricade")] // Normal barricade spawning
        public static BarricadeClass DropNonPlantedBarricade(ushort id, Vector3Class position, float rx, float ry, float rz, string ownerGiven = "0", string groupGiven = "0")
        {
            Barricade barricade = new Barricade(id);
            if (barricade.asset == null) return (BarricadeClass)null;
            ItemBarricadeAsset itemBarricadeAsset = barricade.asset;

            ulong parsedOwner = Convert.ToUInt64(ownerGiven);
            ulong parsedGroup = Convert.ToUInt64(groupGiven);

            if (barricade.state.Length >= 8)
            {
                BitConverter.GetBytes(parsedOwner).CopyTo(barricade.state, 0);
                if (barricade.state.Length >= 16)
                    BitConverter.GetBytes(parsedGroup).CopyTo(barricade.state, 8);
            }

            Transform tBarricade = BarricadeManager.dropNonPlantedBarricade(barricade, position.Vector3, Quaternion.Euler(rx, ry, rz), parsedOwner, parsedGroup);
            BarricadeClass uBarricade = new BarricadeClass(tBarricade);
            return uBarricade;
        }

        /*
        [ScriptFunction("getBarricadesInRadius")]
        public static ExpressionValue getBarricadesInRadius(Vector3Class v3Class, float radius)
        {
            // Already exists. Use server.getBarricadesInRadius(); instead.
        }
        */

        // Void section #2
        [ScriptFunction("receiveClearRegionBarricades")]
        public static void ReceiveClearRegionBarricades(byte x, byte y)
        {
            BarricadeManager.ReceiveClearRegionBarricades(x, y);
        }

        [ScriptFunction("repairInstigator")] // Instigator means the person who started something
        public static void RepairInstigator(BarricadeClass barricade, float damageGiven, float multiplier, PlayerClass instigator)
        {
            BarricadeManager.repair(barricade.BarricadeTransform, damageGiven, multiplier, instigator.Player.channel.owner.playerID.steamID);
        }

        [ScriptFunction("repair")]
        public static void Repair(BarricadeClass barricade, float damageGiven, float multiplier)
        {
            BarricadeManager.repair(barricade.BarricadeTransform, damageGiven, multiplier);
        }

        [ScriptFunction("salvageBarricade")]
        public static void SalvageBarricade(BarricadeClass barricade)
        {
            BarricadeManager.salvageBarricade(barricade.BarricadeTransform);
        }

        [ScriptFunction("save")]
        public static void Save()
        {
            BarricadeManager.save();
        }

        [ScriptFunction("load")]
        public static void Load()
        {
            BarricadeManager.load();
        }

        [ScriptFunction("sendAlertSentry")]
        public static void SendAlertSentry(BarricadeClass sentry, float yaw, float pitch)
        {
            BarricadeManager.sendAlertSentry(sentry.BarricadeTransform, yaw, pitch);
        }

        [ScriptFunction("sendFuel")]
        public static void SendFuel(BarricadeClass fuel, ushort fuelAmount)
        {
            BarricadeManager.sendFuel(fuel.BarricadeTransform, fuelAmount);
        }

        [ScriptFunction("sendOil")]
        public static void SendOil(BarricadeClass oil, ushort oilAmount)
        {
            BarricadeManager.sendOil(oil.BarricadeTransform, oilAmount);
        }

        [ScriptFunction("sendShootSentry")]
        public static void SendShootSentry(BarricadeClass sentry)
        {
            BarricadeManager.sendShootSentry(sentry.BarricadeTransform);
        }

        [ScriptFunction("sendStorageDisplay")]
        public static void SendStorageDisplay(BarricadeClass storage, ItemClass item, ushort skinID = 0, ushort mythicID = 0, string tags = "", string dynamicProps = "")
        {
            BarricadeManager.sendStorageDisplay(storage.BarricadeTransform, item.Item.item, skinID, mythicID, tags, dynamicProps);
        }

        // Bool section
        [ScriptFunction("serverClaimBedForPlayer")]
        public static bool ServerClaimBedForPlayer(BarricadeClass bed, PlayerClass player)
        {
            InteractableBed interactableBed = (InteractableBed)BarricadeManager.FindBarricadeByRootTransform(bed.BarricadeTransform).interactable;
            bool hasClaimed = BarricadeManager.ServerClaimBedForPlayer(interactableBed, player.Player);
            return hasClaimed;
        }

        [ScriptFunction("serverSetBarricadeTransform")]
        public static bool ServerSetBarricadeTransform(BarricadeClass barricade, Vector3Class position, Vector3Class rotation)
        {
            bool hasMoved = BarricadeManager.ServerSetBarricadeTransform(barricade.BarricadeTransform, position.Vector3, Quaternion.Euler(rotation.Vector3.x, rotation.Vector3.y, rotation.Vector3.z));
            return hasMoved;
        }

        [ScriptFunction("serverSetDoorOpen")]
        public static bool ServerSetDoorOpen(DoorClass door, bool isOpen)
        {
            InteractableDoor interactableDoor = (InteractableDoor)BarricadeManager.FindBarricadeByRootTransform(door.Barricade.BarricadeTransform).interactable;
            bool hasOpened = BarricadeManager.ServerSetDoorOpen(interactableDoor, isOpen);
            return hasOpened;
        }

        [ScriptFunction("serverSetFireLit")]
        public static bool ServerSetFireLit(BarricadeClass fire, bool isLit)
        {
            InteractableFire interactableFire = (InteractableFire)BarricadeManager.FindBarricadeByRootTransform(fire.BarricadeTransform).interactable;
            bool hasLit = BarricadeManager.ServerSetFireLit(interactableFire, isLit);
            return hasLit;
        }

        [ScriptFunction("serverSetGeneratorPowered")]
        public static bool ServerSetGeneratorPowered(BarricadeClass generator, bool isPowered)
        {
            InteractableGenerator interactableGenerator = (InteractableGenerator)BarricadeManager.FindBarricadeByRootTransform(generator.BarricadeTransform).interactable;
            bool hasPowered = BarricadeManager.ServerSetGeneratorPowered(interactableGenerator, isPowered);
            return hasPowered;
        }

        [ScriptFunction("serverSetMannequinPose")]
        public static bool ServerSetMannequinPose(BarricadeClass mannequin, byte poseComp)
        {
            InteractableMannequin interactableMannequin = (InteractableMannequin)BarricadeManager.FindBarricadeByRootTransform(mannequin.BarricadeTransform).interactable;
            bool hasPosed = BarricadeManager.ServerSetMannequinPose(interactableMannequin, poseComp);
            return hasPosed;
        }

        [ScriptFunction("serverSetOvenLit")]
        public static bool ServerSetOvenLit(BarricadeClass oven, bool isLit)
        {
            InteractableOven interactableOven = (InteractableOven)BarricadeManager.FindBarricadeByRootTransform(oven.BarricadeTransform).interactable;
            bool hasLit = BarricadeManager.ServerSetOvenLit(interactableOven, isLit);
            return hasLit;
        }

        [ScriptFunction("serverSetOxygenatorPowered")]
        public static bool ServerSetOxygenatorPowered(BarricadeClass oxygenator, bool isPowered)
        {
            InteractableOxygenator interactableOxygenator = (InteractableOxygenator)BarricadeManager.FindBarricadeByRootTransform(oxygenator.BarricadeTransform).interactable;
            bool hasPowered = BarricadeManager.ServerSetOxygenatorPowered(interactableOxygenator, isPowered);
            return hasPowered;
        }

        [ScriptFunction("serverSetSafezonePowered")]
        public static bool ServerSetSafezonePowered(BarricadeClass szGenerator, bool isPowered)
        {
            InteractableSafezone interactableSafezone = (InteractableSafezone)BarricadeManager.FindBarricadeByRootTransform(szGenerator.BarricadeTransform).interactable;
            bool hasPowered = BarricadeManager.ServerSetSafezonePowered(interactableSafezone, isPowered);
            return hasPowered;
        }

        [ScriptFunction("serverSetSignText")]
        public static bool ServerSetSignText(SignClass sign, string newText) // barricade.sign.text. If it dosen't work, try this method.
        {
            InteractableSign interactableSign = (InteractableSign)BarricadeManager.FindBarricadeByRootTransform(sign.Barricade.BarricadeTransform).interactable;
            bool hasChangedText = BarricadeManager.ServerSetSignText(interactableSign, newText);
            return hasChangedText;
        }

        [ScriptFunction("serverSetSpotPowered")]
        public static bool ServerSetSpotPowered(BarricadeClass spotlight, bool isPowered)
        {
            InteractableSpot interactableSpot = (InteractableSpot)BarricadeManager.FindBarricadeByRootTransform(spotlight.BarricadeTransform).interactable;
            bool hasPowered = BarricadeManager.ServerSetSpotPowered(interactableSpot, isPowered);
            return hasPowered;
        }

        [ScriptFunction("serverSetStereoTrack")]
        public static bool ServerSetStereoTrack(BarricadeClass stereo, string guidGiven)
        {
            InteractableStereo interactableStereo = (InteractableStereo)BarricadeManager.FindBarricadeByRootTransform(stereo.BarricadeTransform).interactable;
            bool hasSetTrack = BarricadeManager.ServerSetStereoTrack(interactableStereo, Guid.Parse(guidGiven));
            return hasSetTrack;
        }

        [ScriptFunction("serverUnclaimBed")]
        public static bool ServerUnclaimBed(BarricadeClass bed)
        {
            InteractableBed interactableBed = (InteractableBed)BarricadeManager.FindBarricadeByRootTransform(bed.BarricadeTransform).interactable;
            bool hasUnclaimed = BarricadeManager.ServerUnclaimBed(interactableBed);
            return hasUnclaimed;
        }

        [ScriptFunction("transformBarricade")]
        public static void TransformBarricade(BarricadeClass barricade, Vector3Class point, float ax, float ay, float az)
        {
            BarricadeManager.transformBarricade(barricade.BarricadeTransform, point.Vector3, ax, ay, az);
        }

        [ScriptFunction("trimPlant")]
        public static void TrimPlant(BarricadeClass plant) // This probably means like harvest the plant
        {
            BarricadeManager.trimPlant(plant.BarricadeTransform);
        }

        /*
        [ScriptFunction("tryGetBed")]
        public static ExpressionValue tryGetBed(PlayerClass pClass) // Already exists. Use player.HasBed / bedPosition
        {
            bool hasBed = BarricadeManager.tryGetBed(pClass.Player.channel.owner.playerID.steamID, vClass, angle);
            return hasBed;
        }
        */

        [ScriptFunction("unclaimBeds")]
        public static void UnclaimBeds(PlayerClass player)
        {
            BarricadeManager.unclaimBeds(player.Player.channel.owner.playerID.steamID);
        }

        [ScriptFunction("updateFarm")]
        public static void UpdateFarm(BarricadeClass barricade, uint planted, bool shouldSend)
        {
            BarricadeManager.updateFarm(barricade.BarricadeTransform, planted, shouldSend);
        }

        [ScriptFunction("updateRainBarrel")]
        public static void UpdateRainBarrel(BarricadeClass barricade, bool isFull, bool shouldSend)
        {
            BarricadeManager.updateRainBarrel(barricade.BarricadeTransform, isFull, shouldSend);
        }

        [ScriptFunction("updateReplicatedState")]
        public static void UpdateReplicatedState(BarricadeClass barricade, ExpressionValue state)
        {
            byte[] newState = ByteTool.FromExpressionValue(state);
            BarricadeManager.updateReplicatedState(barricade.BarricadeTransform, newState, newState.Length);
        }

        [ScriptFunction("uprootPlant")]
        public static void UprootPlant(BarricadeClass barricade)
        {
            BarricadeManager.uprootPlant(barricade.BarricadeTransform);
        }
    }
}