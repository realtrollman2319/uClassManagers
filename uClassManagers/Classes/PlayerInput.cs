using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerInput")]
    public class PlayerInputClass
    {
        public PlayerInput playerInput { get; private set; }
        public PlayerInputClass(PlayerInput c_PlayerInput) => playerInput = c_PlayerInput;

        // public static PluginKeyTickHandler onPluginKeyTick;

        [ScriptProperty("SAMPLES")]
        public uint SAMPLES => PlayerInput.SAMPLES;

        [ScriptProperty("RATE")]
        public float RATE => PlayerInput.RATE;

        [ScriptProperty("TOCK_PER_SECOND")]
        public uint TOCK_PER_SECOND => PlayerInput.TOCK_PER_SECOND;

        [ScriptProperty("recov")]
        public int Recov => playerInput.recov;

        [ScriptProperty("IsUnderFakeLagPenalty")]
        public bool IsUnderFakeLagPenalty => playerInput.IsUnderFakeLagPenalty;

        [ScriptProperty("simulation")]
        public uint Simulation => playerInput.simulation;

        [ScriptProperty("tick")]
        public float Tick => playerInput.tick;

        [ScriptProperty("clock")]
        public uint Clock => playerInput.clock;

        [ScriptProperty("keys")]
        public ExpressionValue Keys => BoolTool.FromArray(playerInput.keys);

        [ScriptFunction("getInput")]
        public InputInfoClass GetInput(bool doOcclusionCheck, string usage)
        {
            ERaycastInfoUsage? _usage = EnumTool.raycastInfoUsages.GetEnum(usage);
            if (_usage == null) return null;
            return new InputInfoClass(playerInput.getInput(doOcclusionCheck, _usage.Value));
        }

        [ScriptFunction("getInputCount")]
        public int GetInputCount()
        {
            return playerInput.getInputCount();
        }

        [ScriptFunction("hasInputs")]
        public bool HasInputs()
        {
            return playerInput.hasInputs();
        }

        [ScriptFunction("IsPluginKeyHeld")]
        public bool IsPluginKeyHeld(int index)
        {
            return playerInput.IsPluginKeyHeld(index);
        }
    }
}
