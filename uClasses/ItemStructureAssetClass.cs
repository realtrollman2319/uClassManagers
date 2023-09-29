using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.uClasses
{
    [ScriptClass("ItemStructureAsset")]
    public class ItemStructureAssetClass
    {
        public ItemStructureAsset itemStructureAsset { get; private set; }
        public ItemStructureAssetClass(ItemStructureAsset c_ItemStructureAsset) => itemStructureAsset = c_ItemStructureAsset;

        [ScriptProperty("canBeDamaged")]
        public bool CanBeDamaged => itemStructureAsset.canBeDamaged;

        [ScriptProperty("eligibleForPooling")]
        public bool EligibleForPooling => itemStructureAsset.eligibleForPooling;

        [ScriptProperty("requiresPillars")]
        public bool RequiresPillars => itemStructureAsset.requiresPillars;

        [ScriptProperty("isVulnerable")]
        public bool IsVulnerable => itemStructureAsset.isVulnerable;

        [ScriptProperty("isRepairable")]
        public bool IsRepairable => itemStructureAsset.isRepairable;

        [ScriptProperty("proofExplosion")]
        public bool ProofExplosion => itemStructureAsset.proofExplosion;

        [ScriptProperty("isUnpickupable")]
        public bool IsUnpickupable => itemStructureAsset.isUnpickupable;

        [ScriptProperty("isSaveable")]
        public bool IsSaveable => itemStructureAsset.isSaveable;

        [ScriptProperty("isSalvageable")]
        public bool IsSalvageable => itemStructureAsset.isSalvageable;

        [ScriptProperty("shouldFriendlySentryTargetUser")]
        public bool ShouldFriendlySentryTargetUser => itemStructureAsset.shouldFriendlySentryTargetUser;

        [ScriptProperty("foliageCutRadius")]
        public float FoliageCutRadius => itemStructureAsset.foliageCutRadius;

        [ScriptProperty("salvageDurationMultiplier")]
        public float SalvageDurationMultiplier => itemStructureAsset.salvageDurationMultiplier;

        [ScriptProperty("terrainTestHeight")]
        public float TerrainTestHeight => itemStructureAsset.terrainTestHeight;

        [ScriptProperty("range")]
        public float Range => itemStructureAsset.range;

        [ScriptProperty("health")]
        public ushort Health => itemStructureAsset.health;

        [ScriptProperty("explosion")]
        public ushort Explosion => itemStructureAsset.explosion;

        [ScriptProperty("explosionGuid")]
        public string ExplosionGuid => itemStructureAsset.explosionGuid.ToString();

        [ScriptProperty("armorTier")]
        public string ArmorTier => itemStructureAsset.armorTier.ToString();

        [ScriptProperty("construct")]
        public string Construct => itemStructureAsset.construct.ToString();
    }
}