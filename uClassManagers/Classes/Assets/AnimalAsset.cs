using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes.Assets
{
    [ScriptClass("AnimalAsset")]
    public class AnimalAssetClass
    {
        public AnimalAsset animalAsset { get; private set; }
        public AnimalAssetClass(AnimalAsset c_AnimalAsset) => animalAsset = c_AnimalAsset;

        [ScriptProperty("asset")]
        public AssetClass Asset => new AssetClass(animalAsset);

        [ScriptProperty("attackInterval")]
        public float AttackInterval => animalAsset.attackInterval;

        [ScriptProperty("rewardMin")]
        public byte RewardMin => animalAsset.rewardMin;

        [ScriptProperty("rewardMax")]
        public byte RewardMax => animalAsset.rewardMax;

        [ScriptProperty("rewardID")]
        public ushort RewardID => animalAsset.rewardID;

        [ScriptProperty("attackAnimVariantsCount")]
        public int AttackAnimVariantsCount => animalAsset.attackAnimVariantsCount;

        [ScriptProperty("horizontalAttackRangeSquared")]
        public float HorizontalAttackRangeSquared => animalAsset.horizontalAttackRangeSquared;

        [ScriptProperty("glanceAnimVariantsCount")]
        public int GlanceAnimVariantsCount => animalAsset.glanceAnimVariantsCount;

        [ScriptProperty("startleAnimVariantsCount")]
        public int StartleAnimVariantsCount => animalAsset.startleAnimVariantsCount;

        [ScriptProperty("horizontalVehicleAttackRangeSquared")]
        public float HorizontalVehicleAttackRangeSquared => animalAsset.horizontalVehicleAttackRangeSquared;

        [ScriptProperty("verticalAttackRange")]
        public float VerticalAttackRange => animalAsset.verticalAttackRange;

        [ScriptProperty("pelt")]
        public ushort Pelt => animalAsset.pelt;

        [ScriptProperty("eatAnimVariantsCount")]
        public int EatAnimVariantsCount => animalAsset.eatAnimVariantsCount;

        [ScriptProperty("meat")]
        public ushort Meat => animalAsset.meat;

        [ScriptProperty("regen")]
        public float Regen => animalAsset.regen;

        [ScriptProperty("rewardXP")]
        public uint RewardXP => animalAsset.rewardXP;

        [ScriptProperty("health")]
        public ushort Health => animalAsset.health;

        [ScriptProperty("behaviour")]
        public string Behaviour => animalAsset.behaviour.ToString();

        [ScriptProperty("speedWalk")]
        public float SpeedWalk => animalAsset.speedWalk;

        [ScriptProperty("speedRun")]
        public float SpeedRun => animalAsset.speedRun;

        [ScriptProperty("animalName")]
        public string AnimalName => animalAsset.animalName;

        [ScriptProperty("damage")]
        public byte Damage => animalAsset.damage;

        [ScriptProperty("shouldPlayAnimsOnDedicatedServer")]
        public bool ShouldPlayAnimsOnDedicatedServer => animalAsset.shouldPlayAnimsOnDedicatedServer;

        [ScriptProperty("assetCategory")]
        public string AssetCategory => animalAsset.assetCategory.ToString();

        [ScriptProperty("friendlyName")]
        public string FriendlyName => animalAsset.FriendlyName;
    }
}