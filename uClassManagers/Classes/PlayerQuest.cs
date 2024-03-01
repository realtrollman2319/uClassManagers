using SDG.Unturned;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerQuest")]
    public class PlayerQuestClass
    {
        public PlayerQuest playerQuest { get; private set; }
        public PlayerQuestClass(PlayerQuest c_PlayerQuest) => playerQuest = c_PlayerQuest;

        [ScriptConstructor]
        public PlayerQuestClass(ushort newID) => playerQuest = new PlayerQuest(newID);

        [ScriptProperty("id")]
        public ushort Id => playerQuest.id;

        [ScriptProperty("asset")]
        public QuestAssetClass Asset => new QuestAssetClass(playerQuest.asset);
    }
}