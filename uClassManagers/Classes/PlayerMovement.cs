using SDG.Unturned;
using System.Collections.Generic;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerMovement")]
    public class PlayerMovementClass
    {
        public PlayerMovement playerMovement { get; private set; }
        public PlayerMovementClass(PlayerMovement c_PlayerMovement) => playerMovement = c_PlayerMovement;

        [ScriptProperty("HEIGHT_STAND")]
        public static float HEIGHT_STAND => PlayerMovement.HEIGHT_STAND;

        [ScriptProperty("HEIGHT_CROUCH")]
        public static float HEIGHT_CROUCH => PlayerMovement.HEIGHT_CROUCH;

        [ScriptProperty("HEIGHT_PRONE")]
        public static float HEIGHT_PRONE => PlayerMovement.HEIGHT_PRONE;

        [ScriptProperty("canAddSimulationResultsToUpdates")]
        public bool CanAddSimulationResultsToUpdates => playerMovement.canAddSimulationResultsToUpdates;

        [ScriptProperty("updates")]
        public ExpressionValue Updates
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (PlayerStateUpdate update in playerMovement.updates)
                {
                    list.Add(ExpressionValue.CreateObject(new PlayerStateUpdateClass(update)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        /*
        [ScriptProperty("snapshot")]
        public PitchYawSnapshotInfo Snapshot => playerMovement.snapshot;
        */

        [ScriptProperty("pendingLaunchVelocity")]
        public Vector3Class PendingLaunchVelocity => new Vector3Class(playerMovement.pendingLaunchVelocity);

        [ScriptProperty("ground")] // Originally RaycastHit
        public Vector3Class Ground => new Vector3Class(playerMovement.ground.point);

        [ScriptProperty("inSnow")]
        public bool InSnow => playerMovement.inSnow;

        [ScriptProperty("isSafeInfo")]
        public SafezoneNodeClass IsSafeInfo => new SafezoneNodeClass(playerMovement.isSafeInfo);

        [ScriptProperty("pluginJumpMultiplier")]
        public float PluginJumpMultiplier => playerMovement.pluginJumpMultiplier;

        [ScriptProperty("pluginSpeedMultiplier")]
        public float PluginSpeedMultiplier => playerMovement.pluginSpeedMultiplier;

        [ScriptProperty("bypassUndergroundWhitelist")]
        public bool BypassUndergroundWhitelist => playerMovement.bypassUndergroundWhitelist;

        [ScriptProperty("itemGravityMultiplier")]
        public float ItemGravityMultiplier => playerMovement.itemGravityMultiplier;

        [ScriptProperty("pluginGravityMultiplier")]
        public float PluginGravityMultiplier => playerMovement.pluginGravityMultiplier;

        [ScriptProperty("bool")]
        public bool ForceTrustClient
        {
            get => PlayerMovement.forceTrustClient;
            set => PlayerMovement.forceTrustClient = value;
        }

        /*
        [ScriptProperty("effectNode")]
        public IAmbianceNode EffectNode => playerMovement.effectNode;

        [ScriptProperty("purchaseNode")]
        public HordePurchaseVolume PurchaseNode => playerMovement.purchaseNode;

        [ScriptProperty("ActiveDeadzone")]
        public IDeadzoneNode ActiveDeadzone => playerMovement.ActiveDeadzone;
        */

        [ScriptProperty("totalSpeedMultiplier")]
        public float TotalSpeedMultiplier => playerMovement.totalSpeedMultiplier;

        [ScriptProperty("isSafe")]
        public bool IsSafe
        {
            get => playerMovement.isSafe;
            set => playerMovement.isSafe = value;
        }

        [ScriptProperty("controller")]
        public CharacterControllerClass Controller => new CharacterControllerClass(playerMovement.controller);

        [ScriptProperty("totalGravityMultiplier")]
        public float TotalGravityMultiplier => playerMovement.totalGravityMultiplier;

        [ScriptProperty("WeatherMask")]
        public uint WeatherMask => playerMovement.WeatherMask;

        [ScriptProperty("isRadiated")]
        public bool IsRadiated => playerMovement.isRadiated;

        [ScriptProperty("isMoving")]
        public bool IsMoving => playerMovement.isMoving;

        [ScriptProperty("bound")]
        public byte Bound => playerMovement.bound;

        [ScriptProperty("move")]
        public Vector3Class Move => new Vector3Class(playerMovement.move);

        [ScriptProperty("region_x")]
        public byte Region_x => playerMovement.region_x;

        [ScriptProperty("jump")]
        public bool Jump => playerMovement.jump;

        [ScriptProperty("region_y")]
        public byte Region_y => playerMovement.region_y;

        [ScriptProperty("nav")]
        public byte Nav => playerMovement.nav;

        /*
        [ScriptProperty("loadedRegions")]
        public LoadedRegion[,] LoadedRegions => playerMovement.loadedRegions;

        [ScriptProperty("loadedBounds")]
        public LoadedBound[] LoadedBounds => playerMovement.loadedBounds;
        */

        [ScriptProperty("fall")]
        public float Fall => playerMovement.fall;

        [ScriptProperty("horizontal")]
        public byte Horizontal => playerMovement.horizontal;

        [ScriptProperty("vertical")]
        public byte Vertical => playerMovement.vertical;

        [ScriptProperty("speed")]
        public float Speed => playerMovement.speed;

        [ScriptProperty("isGrounded")]
        public bool IsGrounded => playerMovement.isGrounded;

        [ScriptFunction("forceRemoveFromVehicle")]
        public bool ForceRemoveFromVehicle()
        {
            return playerMovement.forceRemoveFromVehicle();
        }

        [ScriptFunction("getSeat")]
        public byte GetSeat()
        {
            return playerMovement.getSeat();
        }

        [ScriptFunction("getVehicle")]
        public InteractableVehicleClass GetVehicle()
        {
            return new InteractableVehicleClass(playerMovement.getVehicle());
        }

        [ScriptFunction("getVehicleSeat")]
        public PassengerClass GetVehicleSeat()
        {
            return new PassengerClass(playerMovement.getVehicleSeat());
        }

        [ScriptFunction("sendPluginGravityMultiplier")]
        public void SendPluginGravityMultiplier(float newPluginGravityMultiplier)
        {
            playerMovement.sendPluginGravityMultiplier(newPluginGravityMultiplier);
        }

        [ScriptFunction("sendPluginJumpMultiplier")]
        public void SendPluginJumpMultiplier(float newPluginJumpMultiplier)
        {
            playerMovement.sendPluginJumpMultiplier(newPluginJumpMultiplier);
        }

        [ScriptFunction("sendPluginSpeedMultiplier")]
        public void SendPluginSpeedMultiplier(float newPluginSpeedMultiplier)
        {
            playerMovement.sendPluginSpeedMultiplier(newPluginSpeedMultiplier);
        }

        [ScriptFunction("setSize")]
        public void SetSize(string newHeight)
        {
            EPlayerHeight? height = EnumTool.playerHeights.GetEnum(newHeight);
            if (height == null) return;
            playerMovement.setSize(height.Value);
        }

        [ScriptFunction("setVehicle")]
        public void SetVehicle(InteractableVehicleClass newVehicle, byte newSeat, TransformClass newSeatingTransform, Vector3Class newSeatingPosition, byte newSeatingAngle, bool forceUpdate)
        {
            playerMovement.setVehicle(newVehicle.vehicle, newSeat, newSeatingTransform.transform, newSeatingPosition.Vector3, newSeatingAngle, forceUpdate);
        }

        [ScriptFunction("simulate")] // Dedicated server input
        public void Simulate(uint simulation, int recov, bool inputBrake, bool inputStamina, Vector3Class point, Vector3Class rotation, float speed, float physicsSpeed, int turn, float delta)
        {
            playerMovement.simulate(simulation, recov, inputBrake, inputStamina, point.Vector3, Quaternion.Euler(rotation.Vector3), speed, physicsSpeed, turn, delta);
        }

        [ScriptFunction("simulate")]  // Client/Dedicated input
        public void Simulate(uint simulation, int recov, int input_x, int input_y, float look_x, float look_y, bool inputJump, bool inputSprint, float deltaTime)
        {
            playerMovement.simulate(simulation, recov, input_x, input_y, look_x, look_y, inputJump, inputSprint, deltaTime);
        }

        [ScriptFunction("simulate")]
        public void Simulate()
        {
            playerMovement.simulate();
        }

        [ScriptFunction("tellState")]
        public void TellState(Vector3Class newPosition, byte newPitch, byte newYaw)
        {
            playerMovement.tellState(newPosition.Vector3, newPitch, newYaw);
        }

        [ScriptFunction("updateMovement")]
        public void UpdateMovement()
        {
            playerMovement.updateMovement();
        }
    }
}
