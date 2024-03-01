using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerAnimator")]
    public class PlayerAnimatorClass
    {
        public PlayerAnimator playerAnimator { get; private set; }
        public PlayerAnimatorClass(PlayerAnimator c_PlayerAnimator) => playerAnimator = c_PlayerAnimator;

        [ScriptProperty("SAVEDATA_VERSION")]
        public static byte SAVEDATA_VERSION => PlayerAnimator.SAVEDATA_VERSION;

        [ScriptProperty("captorItem")]
        public ushort CaptorItem => playerAnimator.captorItem;

        [ScriptProperty("captorID")]
        public string CaptorID => playerAnimator.captorID.m_SteamID.ToString();

        [ScriptProperty("viewmodelItemInertiaMask")]
        public Vector3Class ViewmodelItemInertiaMask => new Vector3Class(playerAnimator.viewmodelItemInertiaMask);

        [ScriptProperty("viewmodelExplosionSmoothingSpeed")]
        public float ViewmodelExplosionSmoothingSpeed => playerAnimator.viewmodelExplosionSmoothingSpeed;

        [ScriptProperty("recoilViewmodelCameraMask")]
        public Vector3Class RecoilViewmodelCameraMask => new Vector3Class(playerAnimator.recoilViewmodelCameraMask);

        [ScriptProperty("viewmodelOffsetPreferenceMultiplier")]
        public float ViewmodelOffsetPreferenceMultiplier => playerAnimator.viewmodelOffsetPreferenceMultiplier;

        [ScriptProperty("viewmodelSwayMultiplier")]
        public float ViewmodelSwayMultiplier => playerAnimator.viewmodelSwayMultiplier;

        [ScriptProperty("scopeSway")]
        public Vector3Class ScopeSway => new Vector3Class(playerAnimator.scopeSway);

        [ScriptProperty("turretViewmodelCameraLocalPositionOffset")]
        public Vector3Class TurretViewmodelCameraLocalPositionOffset => new Vector3Class(playerAnimator.turretViewmodelCameraLocalPositionOffset);

        [ScriptProperty("viewmodelCameraLocalPositionOffset")]
        public Vector3Class ViewmodelCameraLocalPositionOffset => new Vector3Class(playerAnimator.viewmodelCameraLocalPositionOffset);

        [ScriptProperty("viewmodelCameraTransform")]
        public TransformClass ViewmodelCameraTransform => new TransformClass(playerAnimator.viewmodelCameraTransform);

        [ScriptProperty("viewmodelParentTransform")]
        public TransformClass ViewmodelParentTransform => new TransformClass(playerAnimator.viewmodelParentTransform);

        [ScriptProperty("captorStrength")]
        public ushort CaptorStrength => playerAnimator.captorStrength;

        [ScriptProperty("speed")]
        public float Speed => playerAnimator.speed;

        [ScriptProperty("firstSkeleton")]
        public TransformClass FirstSkeleton => new TransformClass(playerAnimator.firstSkeleton);

        [ScriptProperty("thirdSkeleton")]
        public TransformClass ThirdSkeleton => new TransformClass(playerAnimator.thirdSkeleton);

        [ScriptProperty("leanLeft")]
        public bool LeanLeft => playerAnimator.leanLeft;

        [ScriptProperty("roll")]
        public float Roll => playerAnimator.roll;

        [ScriptProperty("tilt")]
        public float Tilt => playerAnimator.tilt;

        [ScriptProperty("bob")]
        public float Bob => playerAnimator.bob;

        [ScriptProperty("gesture")]
        public string Gesture => playerAnimator.gesture.ToString();

        [ScriptProperty("leanRight")]
        public bool LeanRight => playerAnimator.leanRight;

        [ScriptProperty("lean")]
        public int Lean => playerAnimator.lean;

        [ScriptProperty("shoulder")]
        public float Shoulder => playerAnimator.shoulder;

        [ScriptProperty("side")]
        public bool Side => playerAnimator.side;

        [ScriptProperty("shoulder2")]
        public float Shoulder2 => playerAnimator.shoulder2;

        [ScriptFunction("AddBayonetViewmodelCameraOffset")]
        public void AddBayonetViewmodelCameraOffset(float fling_x, float fling_y, float fling_z)
        {
            playerAnimator.AddBayonetViewmodelCameraOffset(fling_x, fling_y, fling_z);
        }

        [ScriptFunction("AddRecoilViewmodelCameraOffset")]
        public void AddRecoilViewmodelCameraOffset(float shake_x, float shake_y, float shake_z)
        {
            playerAnimator.AddRecoilViewmodelCameraOffset(shake_x, shake_y, shake_z);
        }

        [ScriptFunction("AddRecoilViewmodelCameraRotation")]
        public void AddRecoilViewmodelCameraRotation(float cameraYaw, float cameraPitch)
        {
            playerAnimator.AddRecoilViewmodelCameraRotation(cameraYaw, cameraPitch);
        }

        [ScriptFunction("checkExists")]
        public bool CheckExists(string name)
        {
            return playerAnimator.checkExists(name);
        }

        [ScriptFunction("GetAnimationLength")]
        public float GetAnimationLength(string name, bool scaled = true)
        {
            return playerAnimator.GetAnimationLength(name, scaled);
        }

        [ScriptFunction("getAnimationLength")]
        public float GetAnimationLength(string name)
        {
            return playerAnimator.getAnimationLength(name);
        }

        [ScriptFunction("load")]
        public void Load()
        {
            playerAnimator.load();
        }

        [ScriptFunction("mixAnimation")]
        public void MixAnimation(string name, bool mixLeftShoulder, bool mixRightShoulder)
        {
            playerAnimator.mixAnimation(name, mixLeftShoulder, mixRightShoulder);
        }

        [ScriptFunction("mixAnimation")]
        public void MixAnimation(string name, bool mixLeftShoulder, bool mixRightShoulder, bool mixSkull)
        {
            playerAnimator.mixAnimation(name, mixLeftShoulder, mixRightShoulder, mixSkull);
        }

        [ScriptFunction("mixAnimation")]
        public void MixAnimation(string name)
        {
            playerAnimator.mixAnimation(name);
        }

        [ScriptFunction("NotifyClothingIsVisible")]
        public void NotifyClothingIsVisible()
        {
            playerAnimator.NotifyClothingIsVisible();
        }

        [ScriptFunction("play")]
        public void Play(string name, bool smooth)
        {
            playerAnimator.play(name, smooth);
        }

        [ScriptFunction("save")]
        public void Save()
        {
            playerAnimator.save();
        }

        [ScriptFunction("sendGesture")]
        public void SendGesture(string gesture, bool all)
        {
            EPlayerGesture? eGesture = EnumTool.playerGestures.GetEnum(gesture);
            if (eGesture == null) return;
            playerAnimator.sendGesture(eGesture.Value, all);
        }

        [ScriptFunction("setAnimationSpeed")]
        public void SetAnimationSpeed(string name, float speed)
        {
            playerAnimator.setAnimationSpeed(name, speed);
        }

        [ScriptFunction("simulate")]
        public void Simulate(uint simulation, bool inputLeanLeft, bool inputLeanRight)
        {
            playerAnimator.simulate(simulation, inputLeanLeft, inputLeanRight);
        }

        [ScriptFunction("stop")]
        public void Stop(string name)
        {
            playerAnimator.stop(name);
        }
    }
}
