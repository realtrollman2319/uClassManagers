using SDG.Unturned;
using System;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerStance")]
    public class PlayerStanceClass
    {
        public PlayerStance playerStance { get; private set; }
        public PlayerStanceClass(PlayerStance c_PlayerStance) => playerStance = c_PlayerStance;

        [ScriptProperty("COOLDOWN")]
        public static float COOLDOWN => PlayerStance.COOLDOWN;

        [ScriptProperty("RADIUS")]
        public static float RADIUS => PlayerStance.RADIUS;

        [ScriptProperty("DETECT_MOVE")]
        public static float DETECT_MOVE => PlayerStance.DETECT_MOVE;

        [ScriptProperty("DETECT_FORWARD")]
        public static float DETECT_FORWARD => PlayerStance.DETECT_FORWARD;

        [ScriptProperty("DETECT_BACKWARD")]
        public static float DETECT_BACKWARD => PlayerStance.DETECT_BACKWARD;

        [ScriptProperty("DETECT_SPRINT")]
        public static float DETECT_SPRINT => PlayerStance.DETECT_SPRINT;

        [ScriptProperty("DETECT_STAND")]
        public static float DETECT_STAND => PlayerStance.DETECT_STAND;

        [ScriptProperty("DETECT_CROUCH")]
        public static float DETECT_CROUCH => PlayerStance.DETECT_CROUCH;

        [ScriptProperty("DETECT_PRONE")]
        public static float DETECT_PRONE => PlayerStance.DETECT_PRONE;

        [ScriptProperty("initialStance")]
        public string InitialStance => playerStance.initialStance.ToString();

        [ScriptProperty("areEyesUnderwater")]
        public bool AreEyesUnderwater => playerStance.areEyesUnderwater;

        [ScriptProperty("areFeetUnderwater")]
        public bool AreFeetUnderwater => playerStance.areFeetUnderwater;

        [ScriptProperty("isSubmerged")]
        public bool IsSubmerged => playerStance.isSubmerged;

        [ScriptProperty("sprint")]
        public bool Sprint => playerStance.sprint;

        [ScriptProperty("prone")]
        public bool Prone => playerStance.prone;

        [ScriptProperty("crouch")]
        public bool Crouch => playerStance.crouch;

        [ScriptProperty("stance")]
        public string Stance
        {
            get => playerStance.stance.ToString();
            set
            {
                EPlayerStance? stance = EnumTool.playerStances.GetEnum(value);
                if (stance == null) return;
                playerStance.stance = stance.Value;
            }
        }

        [ScriptProperty("isBodyUnderwater")]
        public bool IsBodyUnderwater => playerStance.isBodyUnderwater;

        [ScriptFunction("drawCapsule")]
        public static void DrawCapsule(Vector3Class position, float height, string hexColor, float lifespan = 0)
        {
            Color? color = ColorTool.ParseString(hexColor);
            if (color == null) return;
            PlayerStance.drawCapsule(position.Vector3, height, color.Value, lifespan);
        }

        [ScriptFunction("drawStandingCapsule")]
        public static void DrawStandingCapsule(Vector3Class position, string hexColor, float lifespan = 0)
        {
            Color? color = ColorTool.ParseString(hexColor);
            if (color == null) return;
            PlayerStance.drawStandingCapsule(position.Vector3, color.Value, lifespan);
        }

        [ScriptFunction("getStanceForPosition")]
        public static bool GetStanceForPosition(Vector3Class position, string stance)
        {
            EPlayerStance? _stance = EnumTool.playerStances.GetEnum(stance);
            if (stance == null) return false;
            EPlayerStance stanceValue = _stance.Value;
            return PlayerStance.getStanceForPosition(position.Vector3, ref stanceValue);
        }

        [ScriptFunction("hasCrouchingHeightClearanceAtPosition")]
        public static bool HasCrouchingHeightClearanceAtPosition(Vector3Class position)
        {
            return PlayerStance.hasCrouchingHeightClearanceAtPosition(position.Vector3);
        }

        [ScriptFunction("hasHeightClearanceAtPosition")]
        public static bool HasHeightClearanceAtPosition(Vector3Class position, float height)
        {
            return PlayerStance.hasHeightClearanceAtPosition(position.Vector3, height);
        }

        [ScriptFunction("hasProneHeightClearanceAtPosition")]
        public static bool HasProneHeightClearanceAtPosition(Vector3Class position)
        {
            return PlayerStance.hasProneHeightClearanceAtPosition(position.Vector3);
        }

        [ScriptFunction("hasStandingHeightClearanceAtPosition")]
        public static bool HasStandingHeightClearanceAtPosition(Vector3Class position)
        {
            return PlayerStance.hasStandingHeightClearanceAtPosition(position.Vector3);
        }

        [ScriptFunction("hasTeleportClearanceAtPosition")]
        public static bool HasTeleportClearanceAtPosition(Vector3Class position)
        {
            return PlayerStance.hasTeleportClearanceAtPosition(position.Vector3);
        }

        [ScriptFunction("adjustStanceOrTeleportIfStuck")]
        public bool AdjustStanceOrTeleportIfStuck()
        {
            return playerStance.adjustStanceOrTeleportIfStuck();
        }

        [ScriptFunction("checkStance")]
        public void CheckStance(string newStance)
        {
            EPlayerStance? stance = EnumTool.playerStances.GetEnum(newStance);
            if (stance == null) return;
            playerStance.checkStance(stance.Value);
        }

        [ScriptFunction("checkStance")]
        public void CheckStance(string newStance, bool all)
        {
            EPlayerStance? stance = EnumTool.playerStances.GetEnum(newStance);
            if (stance == null) return;
            playerStance.checkStance(stance.Value, all);
        }

        [ScriptFunction("GetStealthDetectionRadius")]
        public float GetStealthDetectionRadius()
        {
            return playerStance.GetStealthDetectionRadius();
        }

        [ScriptFunction("hasHeightClearance")]
        public bool HasHeightClearance(float height)
        {
            return playerStance.hasHeightClearance(height);
        }

        [ScriptFunction("simulate")]
        public void Simulate(uint simulation, bool inputCrouch, bool inputProne, bool inputSprint)
        {
            playerStance.simulate(simulation, inputCrouch, inputProne, inputSprint);
        }

        [ScriptFunction("wouldHaveHeightClearanceAtPosition")]
        public bool WouldHaveHeightClearanceAtPosition(Vector3Class position, float padding = 0)
        {
            return playerStance.wouldHaveHeightClearanceAtPosition(position.Vector3, padding);
        }
    }
}