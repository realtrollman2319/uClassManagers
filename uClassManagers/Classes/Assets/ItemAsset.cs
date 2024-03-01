using SDG.Unturned;
using System.Linq;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes.Assets
{
    [ScriptClass("ItemAsset")]
    public class ItemAssetClass
    {
        public ItemAsset itemAsset { get; private set; }
        public ItemAssetClass(ItemAsset c_ItemAsset) => itemAsset = c_ItemAsset;

        [ScriptProperty("asset")]
        public AssetClass Asset => new AssetClass(itemAsset);

        [ScriptProperty("size_x")]
        public byte Size_x => itemAsset.size_x;

        [ScriptProperty("size_y")]
        public byte Size_y => itemAsset.size_y;

        [ScriptProperty("count")]
        public byte Count => itemAsset.count;

        [ScriptProperty("quality")]
        public byte Quality => itemAsset.quality;

        [ScriptProperty("amount")]
        public byte Amount => itemAsset.amount;

        [ScriptProperty("countMin")]
        public byte CountMin => itemAsset.countMin;

        [ScriptProperty("countMax")]
        public byte CountMax => itemAsset.countMax;

        [ScriptProperty("qualityMin")]
        public byte QualityMin => itemAsset.qualityMin;

        [ScriptProperty("qualityMax")]
        public byte QualityMax => itemAsset.qualityMax;

        [ScriptProperty("shouldProcedurallyAnimateInertia")]
        public bool ShouldProcedurallyAnimateInertia => itemAsset.shouldProcedurallyAnimateInertia;

        [ScriptProperty("isEligibleForAutomaticIconMeasurements")]
        public bool IsEligibleForAutomaticIconMeasurements => itemAsset.isEligibleForAutomaticIconMeasurements;

        [ScriptProperty("shouldLeftHandedCharactersMirrorEquippedItem")]
        public bool ShouldLeftHandedCharactersMirrorEquippedItem => itemAsset.shouldLeftHandedCharactersMirrorEquippedItem;

        [ScriptProperty("econIconUseId")]
        public bool EconIconUseId => itemAsset.econIconUseId;

        [ScriptProperty("ShouldAttachEquippedModelToLeftHand")]
        public bool ShouldAttachEquippedModelToLeftHand => itemAsset.ShouldAttachEquippedModelToLeftHand;

        [ScriptProperty("overrideShowQuality")]
        public bool OverrideShowQuality => itemAsset.overrideShowQuality;

        [ScriptProperty("canPlayerEquip")]
        public bool CanPlayerEquip => itemAsset.canPlayerEquip;

        [ScriptProperty("isEligibleForAutoStatDescriptions")]
        public bool IsEligibleForAutoStatDescriptions => itemAsset.isEligibleForAutoStatDescriptions;

        [ScriptProperty("isPro")]
        public bool IsPro => itemAsset.isPro;

        [ScriptProperty("canUseUnderwater")]
        public bool CanUseUnderwater => itemAsset.canUseUnderwater;

        [ScriptProperty("shouldVerifyHash")]
        public bool ShouldVerifyHash => itemAsset.shouldVerifyHash;

        [ScriptProperty("shouldDeleteAtZeroQuality")]
        public bool ShouldDeleteAtZeroQuality => itemAsset.shouldDeleteAtZeroQuality;

        [ScriptProperty("shouldDestroyItemColliders")]
        public bool ShouldDestroyItemColliders => itemAsset.shouldDestroyItemColliders;

        [ScriptProperty("shouldDropOnDeath")]
        public bool ShouldDropOnDeath => itemAsset.shouldDropOnDeath;

        [ScriptProperty("allowManualDrop")]
        public bool AllowManualDrop => itemAsset.allowManualDrop;

        [ScriptProperty("iconCameraOrthographicSize")]
        public float IconCameraOrthographicSize => itemAsset.iconCameraOrthographicSize;

        [ScriptProperty("econIconCameraOrthographicSize")]
        public float EconIconCameraOrthographicSize => itemAsset.econIconCameraOrthographicSize;

        [ScriptProperty("equipableMovementSpeedMultiplier")]
        public float EquipableMovementSpeedMultiplier => itemAsset.equipableMovementSpeedMultiplier;

        [ScriptProperty("instantiatedItemName")]
        public string InstantiatedItemName => itemAsset.instantiatedItemName;

        [ScriptProperty("itemName")]
        public string ItemName => itemAsset.itemName;

        [ScriptProperty("itemDescription")]
        public string ItemDescription => itemAsset.itemDescription;

        [ScriptProperty("proPath")]
        public string ProPath => itemAsset.proPath;

        [ScriptProperty("useable")]
        public string Useable => itemAsset.useable;

        [ScriptProperty("sharedSkinLookupID")]
        public ushort SharedSkinLookupID => itemAsset.sharedSkinLookupID;

        [ScriptProperty("friendlyName")]
        public string FriendlyName => itemAsset.FriendlyName;

        [ScriptProperty("assetCategory")]
        public string AssetCategory => itemAsset.assetCategory.ToString();

        [ScriptProperty("showQuality")]
        public bool ShowQuality => itemAsset.showQuality;

        [ScriptProperty("shouldFriendlySentryTargetUser")]
        public bool ShouldFriendlySentryTargetUser => itemAsset.shouldFriendlySentryTargetUser;

        [ScriptProperty("slot")]
        public string Slot => itemAsset.slot.ToString();

        [ScriptProperty("rarity")]
        public string Rarity => itemAsset.rarity.ToString();

        [ScriptProperty("type")]
        public string Type => itemAsset.type.ToString();

        [ScriptFunction("getState")]
        public ExpressionValue GetState(bool isFull) => ByteTool.FromArray(itemAsset.getState(isFull));

        [ScriptFunction("getState")]
        public ExpressionValue GetState() => ByteTool.FromArray(itemAsset.getState());
    }
}