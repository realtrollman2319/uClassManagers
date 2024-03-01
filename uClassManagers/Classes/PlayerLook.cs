using SDG.Unturned;
using System;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerLook")]
    public class PlayerLookClass
    {
        public PlayerLook playerLook { get; private set; }
        public PlayerLookClass(PlayerLook c_PlayerLook) => playerLook = c_PlayerLook;

        [ScriptProperty("targetExplosionLocalRotation")]
        public Rk4SpringQClass TargetExplosionLocalRotation => new Rk4SpringQClass(playerLook.targetExplosionLocalRotation);

        [ScriptProperty("characterYaw")]
        public static float CharacterYaw => PlayerLook.characterYaw;

        [ScriptProperty("shouldUseZoomFactorForSensitivity")]
        public bool ShouldUseZoomFactorForSensitivity => playerLook.shouldUseZoomFactorForSensitivity;

        [ScriptProperty("explosionSmoothingSpeed")]
        public float ExplosionSmoothingSpeed => playerLook.explosionSmoothingSpeed;

        [ScriptProperty("lastRot")]
        public byte LastRot => playerLook.lastRot;

        [ScriptProperty("lastAngle")]
        public byte LastAngle => playerLook.lastAngle;

        [ScriptProperty("rot")]
        public byte Rot => playerLook.rot;

        [ScriptProperty("angle")]
        public byte Angle => playerLook.angle;

        [ScriptProperty("isIgnoringInput")]
        public bool IsIgnoringInput => playerLook.isIgnoringInput;

        [ScriptProperty("isSmoothing")]
        public bool IsSmoothing => playerLook.isSmoothing;

        [ScriptProperty("isFocusing")]
        public bool IsFocusing => playerLook.isFocusing;

        [ScriptProperty("isLocking")]
        public bool IsLocking => playerLook.isLocking;

        [ScriptProperty("isTracking")]
        public bool IsTracking => playerLook.isTracking;

        [ScriptProperty("isOrbiting")]
        public bool IsOrbiting => playerLook.isOrbiting;

        [ScriptProperty("orbitPosition")]
        public Vector3Class OrbitPosition => new Vector3Class(playerLook.orbitPosition);

        [ScriptProperty("lockPosition")]
        public Vector3Class LockPosition => new Vector3Class(playerLook.lockPosition);

        [ScriptProperty("orbitSpeed")]
        public float OrbitSpeed => playerLook.orbitSpeed;

        [ScriptProperty("perspective")]
        public string Perspective => playerLook.perspective.ToString();

        [ScriptProperty("isCam")]
        public bool IsCam => playerLook.isCam;

        [ScriptProperty("areSpecStatsVisible")]
        public bool AreSpecStatsVisible => playerLook.areSpecStatsVisible;

        [ScriptProperty("orbitYaw")]
        public float OrbitYaw => playerLook.orbitYaw;

        [ScriptProperty("orbitPitch")]
        public float OrbitPitch => playerLook.orbitPitch;

        [ScriptProperty("look_y")]
        public float Look_y => playerLook.look_y;

        [ScriptProperty("heightLook")]
        public float HeightLook => playerLook.heightLook;

        [ScriptProperty("yaw")]
        public float Yaw => playerLook.yaw;

        [ScriptProperty("pitch")]
        public float Pitch => playerLook.pitch;

        [ScriptProperty("aim")]
        public TransformClass Aim => new TransformClass(playerLook.aim);

        [ScriptProperty("isScopeActive")]
        public bool IsScopeActive => playerLook.isScopeActive;

        [ScriptProperty("canUseFreecam")]
        public bool CanUseFreecam => playerLook.canUseFreecam;

        [ScriptProperty("look_x")]
        public float Look_x => playerLook.look_x;

        [ScriptProperty("canUseSpecStats")]
        public bool CanUseSpecStats => playerLook.canUseSpecStats;

        [ScriptProperty("canUseWorkzone")]
        public bool CanUseWorkzone => playerLook.canUseWorkzone;

        [ScriptFunction("disableOverlay")]
        public void DisableOverlay()
        {
            playerLook.disableOverlay();
        }

        [ScriptFunction("disableScope")]
        public void DisableScope()
        {
            playerLook.disableScope();
        }

        [ScriptFunction("disableZoom")]
        public void DisableZoom()
        {
            playerLook.disableZoom();
        }

        [ScriptFunction("enableOverlay")]
        public void EnableOverlay()
        {
            playerLook.enableOverlay();
        }

        [ScriptFunction("enableScope")]
        public void EnableScope(float zoom, ItemClass sightAsset)
        {
            ItemSightAsset sight = sightAsset.Item.GetAsset() as ItemSightAsset;
            if (sight != null)
            {
                playerLook.enableScope(zoom, sight);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("uClassManagers module from uScript => Failed to cast item into sight asset! Check the item and try again.");
                Console.ResetColor();
            }
        }

        [ScriptFunction("enableZoom")]
        public void EnableZoom(float zoom)
        {
            playerLook.enableZoom(zoom);
        }

        [ScriptFunction("getEyesPosition")]
        public Vector3Class GetEyesPosition()
        {
            return new Vector3Class(playerLook.getEyesPosition());
        }

        [ScriptFunction("GetEyesPositionWithoutLeaning")]
        public Vector3Class GetEyesPositionWithoutLeaning()
        {
            return new Vector3Class(playerLook.GetEyesPositionWithoutLeaning());
        }

        [ScriptFunction("recoil")]
        public void Recoil(float x, float y, float h, float v)
        {
            playerLook.recoil(x, y, h, v);
        }

        [ScriptFunction("sendFreecamAllowed")]
        public void SendFreecamAllowed(bool isAllowed)
        {
            playerLook.sendFreecamAllowed(isAllowed);
        }

        [ScriptFunction("sendSpecStatsAllowed")]
        public void SendSpecStatsAllowed(bool isAllowed)
        {
            playerLook.sendSpecStatsAllowed(isAllowed);
        }

        [ScriptFunction("sendWorkzoneAllowed")]
        public void SendWorkzoneAllowed(bool isAllowed)
        {
            playerLook.sendWorkzoneAllowed(isAllowed);
        }

        [ScriptFunction("simulate")]
        public void Simulate(float look_x, float look_y, float delta)
        {
            playerLook.simulate(look_x, look_y, delta);
        }

        [ScriptFunction("updateAim")]
        public void UpdateAim(float delta)
        {
            playerLook.updateAim(delta);
        }

        [ScriptFunction("updateLook")]
        public void UpdateLook()
        {
            playerLook.updateLook();
        }

        [ScriptFunction("updateRot")]
        public void UpdateRot()
        {
            playerLook.updateRot();
        }

        [ScriptFunction("updateScope")]
        public void UpdateScope(string quality)
        {
            EGraphicQuality? graphicQuality = EnumTool.graphicQualities.GetEnum(quality);
            if (graphicQuality == null) return;
            playerLook.updateScope(graphicQuality.Value);
        }
    }
}
