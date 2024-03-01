using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerVoice")]
    public class PlayerVoiceClass
    {
        public PlayerVoice playerVoice { get; private set; }
        public PlayerVoiceClass(PlayerVoice c_PlayerVoice) => playerVoice = c_PlayerVoice;

        [ScriptProperty("hasUseableWalkieTalkie")]
        public bool HasUseableWalkieTalkie => playerVoice.hasUseableWalkieTalkie;

        [ScriptProperty("isTalking")]
        public bool IsTalking => playerVoice.isTalking;

        [ScriptProperty("canHearRadio")]
        public bool CanHearRadio => playerVoice.canHearRadio;

        [ScriptProperty("hasEarpiece")]
        public bool HasEarpiece => playerVoice.hasEarpiece;

        [ScriptFunction("handleRelayVoiceCulling_Proximity")]
        public bool HandleRelayVoiceCulling_Proximity(PlayerVoiceClass speaker, PlayerVoiceClass listener)
        {
            return PlayerVoice.handleRelayVoiceCulling_Proximity(speaker.playerVoice, listener.playerVoice);
        }

        [ScriptFunction("handleRelayVoiceCulling_RadioFrequency")]
        public bool HandleRelayVoiceCulling_RadioFrequency(PlayerVoiceClass speaker, PlayerVoiceClass listener)
        {
            return PlayerVoice.handleRelayVoiceCulling_RadioFrequency(speaker.playerVoice, listener.playerVoice);
        }

        [ScriptFunction("GetAllowTalkingWhileDead")]
        public bool GetAllowTalkingWhileDead()
        {
            return playerVoice.GetAllowTalkingWhileDead();
        }

        [ScriptFunction("GetCustomAllowTalking")]
        public bool GetCustomAllowTalking()
        {
            return playerVoice.GetCustomAllowTalking();
        }

        [ScriptFunction("ServerSetPermissions")]
        public void ServerSetPermissions(bool allowTalkingWhileDead, bool customAllowTalking)
        {
            playerVoice.ServerSetPermissions(allowTalkingWhileDead, customAllowTalking);
        }
    }
}