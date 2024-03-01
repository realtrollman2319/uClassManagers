using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerQuestFlag")]
    public class PlayerQuestFlagClass
    {
        public PlayerQuestFlag playerQuestFlag { get; private set; }
        public PlayerQuestFlagClass(PlayerQuestFlag c_PlayerQuestFlag) => playerQuestFlag = c_PlayerQuestFlag;

        [ScriptConstructor]
        public PlayerQuestFlagClass(ushort newID, short newValue) => playerQuestFlag = new PlayerQuestFlag(newID, newValue);

        [ScriptProperty("value")]
        public short Value => playerQuestFlag.value;

        [ScriptProperty("id")]
        public ushort Id => playerQuestFlag.id;
    }
}