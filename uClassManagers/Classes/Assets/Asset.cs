using SDG.Unturned;
using System.Linq;
using uScript.API.Attributes;
using uScript.Core;

#pragma warning disable CS0618
namespace uClassManagers.Classes.Assets
{
    [ScriptClass("Asset")]
    public class AssetClass
    {
        public Asset asset { get; private set; }
        public AssetClass(Asset c_Asset) => asset = c_Asset;

        [ScriptProperty("name")]
        public string Name => asset.name;

        [ScriptProperty("id")]
        public ushort Id => asset.id;

        [ScriptProperty("guid")]
        public string GUID => asset.GUID.ToString("N");

        [ScriptProperty("absoluteOriginFilePath")]
        public string AbsoluteOriginFilePath => asset.absoluteOriginFilePath;

        [ScriptProperty("requiredShaderUpgrade")]
        public bool RequiredShaderUpgrade => asset.requiredShaderUpgrade;

        [ScriptProperty("ignoreNPOT")]
        public bool IgnoreNPOT => asset.ignoreNPOT;

        [ScriptProperty("FriendlyName")]
        public string FriendlyName => asset.FriendlyName;

        [ScriptProperty("hash")]
        public ExpressionValue Hash => ByteTool.FromArray(asset.hash);

        [ScriptProperty("assetOrigin")]
        public string AssetOrigin => asset.assetOrigin.ToString();

        [ScriptProperty("assetCategory")]
        public string AssetCategory => asset.assetCategory.ToString();

        [ScriptFunction("appendHash")]
        public void AppendHash(ExpressionValue otherHash)
        {
            asset.appendHash(ByteTool.FromExpressionValue(otherHash));
        }

        [ScriptFunction("clearHash")]
        public void ClearHash()
        {
            asset.clearHash();
        }

        [ScriptFunction("getFilePath")]
        public string GetFilePath()
        {
            return asset.getFilePath();
        }

        [ScriptFunction("GetOriginName")]
        public string GetOriginName()
        {
            return asset.GetOriginName();
        }

        [ScriptFunction("GetTypeFriendlyName")]
        public string GetTypeFriendlyName()
        {
            return asset.GetTypeFriendlyName();
        }

        [ScriptFunction("getTypeNameAndIdDisplayString")]
        public string GetTypeNameAndIdDisplayString()
        {
            return asset.getTypeNameAndIdDisplayString();
        }

        [ScriptFunction("getTypeNameWithoutSuffix")]
        public string GetTypeNameWithoutSuffix()
        {
            return asset.GetTypeNameWithoutSuffix();
        }

        [ScriptFunction("toString")]
        public override string ToString()
        {
            return asset.ToString();
        }
    }
}