using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;
using uScript.Core;

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
            Guid parsedGuid = GuidTool.ParseGuid(guid);
            switch (assetType.Value)
            {
                case AssetType.ANIMAL:
                    return Assets.find<AnimalAsset>(parsedGuid) is AnimalAsset animalAsset ? ExpressionValue.CreateObject(new AnimalAssetClass(animalAsset)) : ExpressionValue.Null;
                case AssetType.EFFECT:
                    return Assets.find<EffectAsset>(parsedGuid) is EffectAsset effectAsset ? ExpressionValue.CreateObject(new EffectAssetClass(effectAsset)) : ExpressionValue.Null;
                case AssetType.ITEM:
                    return Assets.find<ItemAsset>(parsedGuid) is ItemAsset itemAsset ? ExpressionValue.CreateObject(new ItemAssetClass(itemAsset)) : ExpressionValue.Null;
                case AssetType.VEHICLE:
                    return Assets.find<VehicleAsset>(parsedGuid) is VehicleAsset vehicleAsset ? ExpressionValue.CreateObject(new VehicleAssetClass(vehicleAsset)) : ExpressionValue.Null;
                case AssetType.QUEST:
                    return Assets.find<QuestAsset>(parsedGuid) is QuestAsset questAsset ? ExpressionValue.CreateObject(new QuestAssetClass(questAsset)) : ExpressionValue.Null;
                default:
                    return ExpressionValue.Null;
            }
        }

        [ScriptFunction("find")]
        public static ExpressionValue Find(string type, ushort id)
        {
            AssetType? assetType = EnumTool.assetTypes.GetEnum(type);
            if (assetType == null) return ExpressionValue.Null;
            switch (assetType.Value)
            {
                case AssetType.ANIMAL:
                    return Assets.find(EAssetType.ANIMAL, id) is AnimalAsset animalAsset? ExpressionValue.CreateObject(new AnimalAssetClass(animalAsset)) : ExpressionValue.Null;
                case AssetType.EFFECT:
                    return Assets.find(EAssetType.EFFECT, id) is EffectAsset effectAsset? ExpressionValue.CreateObject(new EffectAssetClass(effectAsset)) : ExpressionValue.Null;
                case AssetType.ITEM:
                    return Assets.find(EAssetType.ITEM, id) is ItemAsset itemAsset ? ExpressionValue.CreateObject(new ItemAssetClass(itemAsset)) : ExpressionValue.Null;
                case AssetType.VEHICLE:
                    return Assets.find(EAssetType.VEHICLE, id) is VehicleAsset vehicleAsset ? ExpressionValue.CreateObject(new VehicleAssetClass(vehicleAsset)) : ExpressionValue.Null;
                default:
                    return ExpressionValue.Null;
            }
        }

        [ScriptFunction("findName")]
        public static ExpressionValue FindName(string type, string name, bool findMultiple = false)
        {
            AssetType? assetType = EnumTool.assetTypes.GetEnum(type);
            if (assetType == null) return ExpressionValue.Null;

            List<ExpressionValue> list = new List<ExpressionValue>();

            if (assetType == AssetType.ANIMAL)
            {
                List<AnimalAsset> results = new List<AnimalAsset>();
                Assets.find(results);
                foreach (AnimalAsset animalAsset in results)
                {
                    if (!findMultiple)
                    {
                        if (animalAsset.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                            return ExpressionValue.CreateObject(new AnimalAssetClass(animalAsset));
                    }
                    else
                    {
                        if (animalAsset.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                            list.Add(ExpressionValue.CreateObject(new AnimalAssetClass(animalAsset)));
                    }
                }
            }
            else if (assetType == AssetType.EFFECT)
            {
                List<EffectAsset> results = new List<EffectAsset>();
                Assets.find(results);
                foreach (EffectAsset effectAsset in results)
                {
                    if (!findMultiple)
                    {
                        if (effectAsset.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                            return ExpressionValue.CreateObject(new EffectAssetClass(effectAsset));
                    }
                    else
                    {
                        if (effectAsset.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                            list.Add(ExpressionValue.CreateObject(new EffectAssetClass(effectAsset)));
                    }
                }
            }
            else if (assetType == AssetType.ITEM)
            {
                List<ItemAsset> results = new List<ItemAsset>();
                Assets.find(results);
                foreach (ItemAsset itemAsset in results)
                {
                    if (!findMultiple)
                    {
                        if (itemAsset.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                            return ExpressionValue.CreateObject(new ItemAssetClass(itemAsset));
                    }
                    else
                    {
                        if (itemAsset.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                            list.Add(ExpressionValue.CreateObject(new ItemAssetClass(itemAsset)));
                    }
                }
            }
            else if (assetType == AssetType.VEHICLE)
            {
                List<VehicleAsset> results = new List<VehicleAsset>();
                Assets.find(results);
                foreach (VehicleAsset vehicleAsset in results)
                {
                    if (!findMultiple)
                    {
                        if (vehicleAsset.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                            return ExpressionValue.CreateObject(new VehicleAssetClass(vehicleAsset));
                    }
                    else
                    {
                        if (vehicleAsset.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                            list.Add(ExpressionValue.CreateObject(new VehicleAssetClass(vehicleAsset)));
                    }
                }
            }

            return list.Count > 0 ? ExpressionValue.Array(list.ToArray()) : ExpressionValue.Null;
        }

        [ScriptFunction("findByAbsolutePath")]
        public static AssetClass FindByAbsolutePath(string path) => new AssetClass(Assets.findByAbsolutePath(path));

        [ScriptFunction("findEffectAssetByGuidOrLegacyId")]
        public static EffectAssetClass FindEffectAssetByGuidOrLegacyId(string guid, ushort legacyId) => new EffectAssetClass(Assets.FindEffectAssetByGuidOrLegacyId(GuidTool.ParseGuid(guid), legacyId));

        [ScriptFunction("findVehicleAssetByGuidOrLegacyId")]
        public static VehicleAssetClass FindVehicleAssetByGuidOrLegacyId(string guid, ushort legacyId) => new VehicleAssetClass(Assets.FindVehicleAssetByGuidOrLegacyId(GuidTool.ParseGuid(guid), legacyId));

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