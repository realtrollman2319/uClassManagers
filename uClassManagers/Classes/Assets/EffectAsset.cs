using SDG.Unturned;
using uScript.API.Attributes;

#pragma warning disable CS0612
namespace uClassManagers.Classes.Assets
{
    [ScriptClass("EffectAsset")]
    public class EffectAssetClass
    {
        public EffectAsset effectAsset { get; private set; }
        public EffectAssetClass(EffectAsset c_EffectAsset) => effectAsset = c_EffectAsset;

        [ScriptProperty("asset")]
        public AssetClass Asset => new AssetClass(effectAsset);

        [ScriptProperty("blastmarkEffectGuid")]
        public string BlastmarkEffectGuid => effectAsset.blastmarkEffectGuid.ToString("N");

        [ScriptProperty("splatterTemperature")]
        public string SplatterTemperature => effectAsset.splatterTemperature.ToString();

        [ScriptProperty("assetCategory")]
        public string AssetCategory => effectAsset.assetCategory.ToString();

        [ScriptProperty("spawnOnDedicatedServer")]
        public bool SpawnOnDedicatedServer => effectAsset.spawnOnDedicatedServer;

        [ScriptProperty("cameraShakeRadius")]
        public float CameraShakeRadius => effectAsset.cameraShakeRadius;

        [ScriptProperty("cameraShakeMagnitudeDegrees")]
        public float CameraShakeMagnitudeDegrees => effectAsset.cameraShakeMagnitudeDegrees;

        [ScriptProperty("relevantDistance")]
        public float RelevantDistance => effectAsset.relevantDistance;

        [ScriptProperty("lifetimeSpread")]
        public float LifetimeSpread => effectAsset.lifetimeSpread;

        [ScriptProperty("lifetime")]
        public float Lifetime => effectAsset.lifetime;

        [ScriptProperty("splatterLifetimeSpread")]
        public float SplatterLifetimeSpread => effectAsset.splatterLifetimeSpread;

        [ScriptProperty("splatterLifetime")]
        public float SplatterLifetime => effectAsset.splatterLifetime;

        [ScriptProperty("blast")]
        public ushort Blast => effectAsset.blast;

        [ScriptProperty("preload")]
        public byte Preload => effectAsset.preload;

        [ScriptProperty("splatterPreload")]
        public byte SplatterPreload => effectAsset.splatterPreload;

        [ScriptProperty("splatter")]
        public byte Splatter => effectAsset.splatter;

        [ScriptProperty("isMusic")]
        public bool IsMusic => effectAsset.isMusic;

        [ScriptProperty("isStatic")]
        public bool IsStatic => effectAsset.isStatic;

        [ScriptProperty("splatterLiquid")]
        public bool SplatterLiquid => effectAsset.splatterLiquid;

        [ScriptProperty("randomizeRotation")]
        public bool RandomizeRotation => effectAsset.randomizeRotation;

        [ScriptProperty("gore")]
        public bool Gore => effectAsset.gore;

        [ScriptFunction("FindBlastmarkEffectAsset")]
        public EffectAssetClass FindBlastmarkEffectAsset() => new EffectAssetClass(effectAsset.FindBlastmarkEffectAsset());
    }
}