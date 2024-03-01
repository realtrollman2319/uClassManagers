using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes.Assets
{
    [ScriptClass("QuestAsset")]
    public class QuestAssetClass
    {
        public QuestAsset questAsset { get; private set; }
        public QuestAssetClass(QuestAsset c_QuestAsset) => questAsset = c_QuestAsset;

        [ScriptProperty("questName")]
        public string QuestName => questAsset.questName;

        [ScriptProperty("questDescription")]
        public string QuestDescription => questAsset.questDescription;

        [ScriptProperty("assetCategory")]
        public string AssetCategory => questAsset.assetCategory.ToString();

        [ScriptFunction("ApplyConditions")]
        public void ApplyConditions(PlayerClass player)
        {
            questAsset.ApplyConditions(player.Player);
        }

        [ScriptFunction("areConditionsMet")]
        public bool AreConditionsMet(PlayerClass player)
        {
            return questAsset.areConditionsMet(player.Player);
        }

        [ScriptFunction("GrantRewards")]
        public void GrantRewards(PlayerClass player)
        {
            questAsset.GrantRewards(player.Player);
        }
    }
}
