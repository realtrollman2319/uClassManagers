using UnityEngine;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("CharacterController")]
    public class CharacterControllerClass
    {
        public CharacterController characterController { get; private set; }
        public CharacterControllerClass(CharacterController c_CharacterController) => characterController = c_CharacterController;

        [ScriptProperty("velocity")]
        public Vector3Class Velocity => new Vector3Class(characterController.velocity);

        [ScriptProperty("isGrounded")]
        public bool IsGrounded => characterController.isGrounded;

        [ScriptProperty("collisionFlags")]
        public string CollisionFlags => characterController.collisionFlags.ToString();

        [ScriptProperty("radius")]
        public float Radius => characterController.radius;

        [ScriptProperty("height")]
        public float Height => characterController.height;

        [ScriptProperty("center")]
        public Vector3Class Center => new Vector3Class(characterController.center);

        [ScriptProperty("slopeLimit")]
        public float SlopeLimit => characterController.slopeLimit;

        [ScriptProperty("stepOffset")]
        public float StepOffset => characterController.stepOffset;

        [ScriptProperty("skinWidth")]
        public float SkinWidth => characterController.skinWidth;

        [ScriptProperty("minMoveDistance")]
        public float MinMoveDistance => characterController.minMoveDistance;

        [ScriptProperty("detectCollisions")]
        public bool DetectCollisions => characterController.detectCollisions;

        [ScriptProperty("enableOverlapRecovery")]
        public bool EnableOverlapRecovery => characterController.enableOverlapRecovery;

        [ScriptFunction("Move")]
        public string Move(Vector3Class motion)
        {
            return characterController.Move(motion.Vector3).ToString();
        }

        [ScriptFunction("SimpleMove")]
        public bool SimpleMove(Vector3Class speed)
        {
            return characterController.SimpleMove(speed.Vector3);
        }
    }
}
