﻿using SDG.Unturned;
using uScript.API.Attributes;

#pragma warning disable CS0612
namespace uClassManagers.Classes.Assets
{
    [ScriptClass("ItemBarricadeAsset")]
    public class ItemBarricadeAssetClass
    {
        public ItemBarricadeAsset itemBarricadeAsset { get; private set; }
        public ItemBarricadeAssetClass(ItemBarricadeAsset c_ItemBarricadeAsset) => itemBarricadeAsset = c_ItemBarricadeAsset;

        [ScriptProperty("asset")]
        public AssetClass Asset => new AssetClass(itemBarricadeAsset);

        [ScriptProperty("shouldBypassPickupOwnership")]
        public bool ShouldBypassPickupOwnership => itemBarricadeAsset.shouldBypassPickupOwnership;

        [ScriptProperty("canBeDamaged")]
        public bool CanBeDamaged => itemBarricadeAsset.canBeDamaged;

        [ScriptProperty("eligibleForPooling")]
        public bool EligibleForPooling => itemBarricadeAsset.eligibleForPooling;

        [ScriptProperty("isSaveable")]
        public bool IsSaveable => itemBarricadeAsset.isSaveable;

        [ScriptProperty("isUnpickupable")]
        public bool IsUnpickupable => itemBarricadeAsset.isUnpickupable;

        [ScriptProperty("proofExplosion")]
        public bool ProofExplosion => itemBarricadeAsset.proofExplosion;

        [ScriptProperty("isRepairable")]
        public bool IsRepairable => itemBarricadeAsset.isRepairable;

        [ScriptProperty("bypassClaim")]
        public bool BypassClaim => itemBarricadeAsset.bypassClaim;

        [ScriptProperty("isVulnerable")]
        public bool IsVulnerable => itemBarricadeAsset.isVulnerable;

        [ScriptProperty("isSalvageable")]
        public bool IsSalvageable => itemBarricadeAsset.isSalvageable;

        [ScriptProperty("isLocked")]
        public bool IsLocked => itemBarricadeAsset.isLocked;

        [ScriptProperty("allowPlacementOnVehicle")]
        public bool AllowPlacementOnVehicle => itemBarricadeAsset.allowPlacementOnVehicle;

        [ScriptProperty("useWaterHeightTransparentSort")]
        public bool UseWaterHeightTransparentSort => itemBarricadeAsset.useWaterHeightTransparentSort;

        [ScriptProperty("allowCollisionWhileAnimating")]
        public bool AllowCollisionWhileAnimating => itemBarricadeAsset.allowCollisionWhileAnimating;

        [ScriptProperty("shouldFriendlySentryTargetUser")]
        public bool ShouldFriendlySentryTargetUser => itemBarricadeAsset.shouldFriendlySentryTargetUser;

        [ScriptProperty("health")]
        public ushort Health => itemBarricadeAsset.health;

        [ScriptProperty("explosion")]
        public ushort Explosion => itemBarricadeAsset.explosion;

        [ScriptProperty("vehicleId")]
        public ushort VehicleId => itemBarricadeAsset.VehicleId;

        [ScriptProperty("salvageDurationMultiplier")]
        public float SalvageDurationMultiplier => itemBarricadeAsset.salvageDurationMultiplier;

        [ScriptProperty("offset")]
        public float Offset => itemBarricadeAsset.offset;

        [ScriptProperty("radius")]
        public float Radius => itemBarricadeAsset.radius;

        [ScriptProperty("range")]
        public float Range => itemBarricadeAsset.range;

        [ScriptProperty("build")]
        public string Build => itemBarricadeAsset.build.ToString();

        [ScriptProperty("explosionGuid")]
        public string ExplosionGuid => itemBarricadeAsset.explosionGuid.ToString("N");

        [ScriptProperty("vehicleGuid")]
        public string VehicleGuid => itemBarricadeAsset.VehicleGuid.ToString("N");

        [ScriptProperty("armorTier")]
        public string ArmorTier => itemBarricadeAsset.armorTier.ToString();
    }
}