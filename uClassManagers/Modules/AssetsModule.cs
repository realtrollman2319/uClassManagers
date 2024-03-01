using SDG.Unturned;
using System;
using System.Linq;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;
using uScript.Core;

#pragma warning disable CS0612
namespace uClassManagers.Modules
{
    [ScriptModule("Assets")]
    public static class AssetsModule
    {
        [ScriptProperty("isLoading")]
        public static bool IsLoading => Assets.isLoading;

        [ScriptProperty("hasLoadedMaps")]
        public static bool HasLoadedMaps => Assets.hasLoadedMaps;

        [ScriptProperty("hasLoadedUgc")]
        public static bool HasLoadedUgc => Assets.hasLoadedUgc;

        [ScriptProperty("shouldDeferLoadingAssets")]
        public static bool ShouldDeferLoadingAssets => Assets.shouldDeferLoadingAssets;

        [ScriptFunction("find")]
        public static ExpressionValue Find(string type, string guid)
        {
            AssetType? assetType = EnumTool.assetTypes.GetEnum(type);
            if (assetType == null) return ExpressionValue.Null;
            switch (assetType)
            {
                case AssetType.ANIMAL:
                    return ExpressionValue.CreateObject(new AnimalAssetClass(Assets.find<AnimalAsset>(Guid.Parse(guid))));
                case AssetType.EFFECT:
                    return ExpressionValue.CreateObject(new EffectAssetClass(Assets.find<EffectAsset>(Guid.Parse(guid))));
                case AssetType.ITEM:
                    return ExpressionValue.CreateObject(new ItemAssetClass(Assets.find<ItemAsset>(Guid.Parse(guid))));
                case AssetType.VEHICLE:
                    return ExpressionValue.CreateObject(new VehicleAssetClass(Assets.find<VehicleAsset>(Guid.Parse(guid))));
                case AssetType.QUEST:
                    return ExpressionValue.CreateObject(new QuestAssetClass(Assets.find<QuestAsset>(Guid.Parse(guid))));
            }
            return ExpressionValue.Null;
        }

        [ScriptFunction("find")]
        public static ExpressionValue Find(string type, ushort id)
        {
            AssetType? assetType = EnumTool.assetTypes.GetEnum(type);
            if (assetType == null) return ExpressionValue.Null;
            switch (assetType)
            {
                case AssetType.ANIMAL:
                    return ExpressionValue.CreateObject(new AnimalAssetClass(Assets.find(EAssetType.ANIMAL, id) as AnimalAsset));
                case AssetType.EFFECT:
                    return ExpressionValue.CreateObject(new EffectAssetClass(Assets.find(EAssetType.EFFECT, id) as EffectAsset));
                case AssetType.ITEM:
                    return ExpressionValue.CreateObject(new ItemAssetClass(Assets.find(EAssetType.ITEM, id) as ItemAsset));
                case AssetType.VEHICLE:
                    return ExpressionValue.CreateObject(new VehicleAssetClass(Assets.find(EAssetType.VEHICLE, id) as VehicleAsset));
            }
            return ExpressionValue.Null;
        }

        [ScriptFunction("findName")]
        public static ExpressionValue FindName(string type, string name)
        {
            AssetType? assetType = EnumTool.assetTypes.GetEnum(type);
            if (assetType == null) return ExpressionValue.Null;
            switch (assetType)
            {
                case AssetType.ANIMAL:
                    return ExpressionValue.CreateObject(new AnimalAssetClass(Assets.find(EAssetType.ANIMAL, name) as AnimalAsset));
                case AssetType.EFFECT:
                    return ExpressionValue.CreateObject(new EffectAssetClass(Assets.find(EAssetType.EFFECT, name) as EffectAsset));
                case AssetType.ITEM:
                    return ExpressionValue.CreateObject(new ItemAssetClass(Assets.find(EAssetType.ITEM, name) as ItemAsset));
                case AssetType.VEHICLE:
                    return ExpressionValue.CreateObject(new VehicleAssetClass(Assets.find(EAssetType.VEHICLE, name) as VehicleAsset));
            }
            return ExpressionValue.Null;
        }

        /*
            public static T find<T>(Guid guid) where T : Asset;
            public static Asset find(EAssetType type, string name);
            public static Asset find(EAssetType type, ushort id);
        */

        [ScriptFunction("findByAbsolutePath")]
        public static AssetClass FindByAbsolutePath(string path) => new AssetClass(Assets.findByAbsolutePath(path));

        [ScriptFunction("findEffectAssetByGuidOrLegacyId")]
        public static EffectAssetClass FindEffectAssetByGuidOrLegacyId(string guid, ushort legacyId) => new EffectAssetClass(Assets.FindEffectAssetByGuidOrLegacyId(Guid.Parse(guid), legacyId));

        [ScriptFunction("findVehicleAssetByGuidOrLegacyId")]
        public static VehicleAssetClass FindVehicleAssetByGuidOrLegacyId(string guid, ushort legacyId) => new VehicleAssetClass(Assets.FindVehicleAssetByGuidOrLegacyId(Guid.Parse(guid), legacyId));

        [ScriptFunction("getReportedErrorsList")]
        public static ExpressionValue GetReportedErrorsList() => ExpressionValue.Array(Assets.getReportedErrorsList().Select(s => (ExpressionValue)s));

        [ScriptFunction("initializeMasterBundleValidation")]
        public static void InitializeMasterBundleValidation() => Assets.initializeMasterBundleValidation();

        [ScriptFunction("reload")]
        public static void Reload(string absolutePath) => Assets.reload(absolutePath);

        [ScriptFunction("reportError")]
        public static void ReportError(string error) => Assets.reportError(error);

        [ScriptFunction("requestReloadAllAssets")]
        public static void RequestReloadAllAssets() => Assets.RequestReloadAllAssets();
    }
}