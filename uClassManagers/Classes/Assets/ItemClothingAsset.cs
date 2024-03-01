using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes.Assets
{
    [ScriptClass("ItemClothingAsset")]
    public class ItemClothingAssetClass
    {
        public ItemClothingAsset itemClothingAsset { get; private set; }
        public ItemClothingAssetClass(ItemClothingAsset c_ItemClothingAsset) => itemClothingAsset = c_ItemClothingAsset;

        [ScriptProperty("movementSpeedMultiplier")]
        public float MovementSpeedMultiplier => itemClothingAsset.movementSpeedMultiplier;

        [ScriptProperty("shouldDestroyClothingColliders")]
        public bool ShouldDestroyClothingColliders => itemClothingAsset.shouldDestroyClothingColliders;

        [ScriptProperty("beardVisible")]
        public bool BeardVisible => itemClothingAsset.beardVisible;

        [ScriptProperty("hairVisible")]
        public bool HairVisible => itemClothingAsset.hairVisible;

        [ScriptProperty("visibleOnRagdoll")]
        public bool VisibleOnRagdoll => itemClothingAsset.visibleOnRagdoll;

        [ScriptProperty("preventsFallingBrokenBones")]
        public bool PreventsFallingBrokenBones => itemClothingAsset.preventsFallingBrokenBones;

        [ScriptProperty("proofRadiation")]
        public bool ProofRadiation => itemClothingAsset.proofRadiation;

        [ScriptProperty("proofFire")]
        public bool ProofFire => itemClothingAsset.proofFire;

        [ScriptProperty("proofWater")]
        public bool ProofWater => itemClothingAsset.proofWater;

        [ScriptProperty("armor")]
        public float Armor => itemClothingAsset.armor;

        [ScriptProperty("fallingDamageMultiplier")]
        public float FallingDamageMultiplier => itemClothingAsset.fallingDamageMultiplier;

        [ScriptProperty("explosionArmor")]
        public float ExplosionArmor => itemClothingAsset.explosionArmor;

        [ScriptProperty("skinOverride")]
        public string SkinOverride => itemClothingAsset.skinOverride;

        [ScriptProperty("showQuality")]
        public bool ShowQuality => itemClothingAsset.showQuality;

        [ScriptProperty("TakesPriorityOverCosmetic")]
        public bool TakesPriorityOverCosmetic => itemClothingAsset.TakesPriorityOverCosmetic;

        [ScriptFunction("shouldBeVisible")]
        public bool ShouldBeVisible(bool isRagdoll)
        {
            return itemClothingAsset.shouldBeVisible(isRagdoll);
        }
    }
}
