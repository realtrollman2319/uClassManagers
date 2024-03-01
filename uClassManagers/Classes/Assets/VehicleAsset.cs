using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

#pragma warning disable CS0612
namespace uClassManagers.Classes.Assets
{
    [ScriptClass("VehicleAsset")]
    public class VehicleAssetClass
    {
        public VehicleAsset vehicleAsset { get; private set; }
        public VehicleAssetClass(VehicleAsset c_vehicleAsset) => vehicleAsset = c_vehicleAsset;

        [ScriptProperty("asset")]
        public AssetClass Asset => new AssetClass(vehicleAsset);

        [ScriptProperty("canTiresBeDamaged")]
        public bool CanTiresBeDamaged => vehicleAsset.canTiresBeDamaged;

        [ScriptProperty("isVulnerableToBumper")]
        public bool IsVulnerableToBumper => vehicleAsset.isVulnerableToBumper;

        [ScriptProperty("isVulnerableToEnvironment")]
        public bool IsVulnerableToEnvironment => vehicleAsset.isVulnerableToEnvironment;

        [ScriptProperty("isVulnerableToExplosions")]
        public bool IsVulnerableToExplosions => vehicleAsset.isVulnerableToExplosions;

        [ScriptProperty("isVulnerable")]
        public bool IsVulnerable => vehicleAsset.isVulnerable;

        [ScriptProperty("CanDecay")]
        public bool CanDecay => vehicleAsset.CanDecay;

        [ScriptProperty("hasSleds")]
        public bool HasSleds => vehicleAsset.hasSleds;

        [ScriptProperty("hasTraction")]
        public bool HasTraction => vehicleAsset.hasTraction;

        [ScriptProperty("hasLockMouse")]
        public bool HasLockMouse => vehicleAsset.hasLockMouse;

        [ScriptProperty("hasCrawler")]
        public bool HasCrawler => vehicleAsset.hasCrawler;

        [ScriptProperty("hasBicycle")]
        public bool HasBicycle => vehicleAsset.hasBicycle;

        [ScriptProperty("shouldVerifyHash")]
        public bool ShouldVerifyHash => vehicleAsset.shouldVerifyHash;

        [ScriptProperty("hasHook")]
        public bool HasHook => vehicleAsset.hasHook;

        [ScriptProperty("hasSirens")]
        public bool HasSirens => vehicleAsset.hasSirens;

        [ScriptProperty("hasZip")]
        public bool HasZip => vehicleAsset.hasZip;

        [ScriptProperty("canRepairWhileSeated")]
        public bool CanRepairWhileSeated => vehicleAsset.canRepairWhileSeated;

        [ScriptProperty("isReclined")]
        public bool IsReclined => vehicleAsset.isReclined;

        [ScriptProperty("hasCenterOfMassOverride")]
        public bool HasCenterOfMassOverride => vehicleAsset.hasCenterOfMassOverride;

        [ScriptProperty("canBeLocked")]
        public bool CanBeLocked => vehicleAsset.canBeLocked;

        [ScriptProperty("shouldSpawnSeatCapsules")]
        public bool ShouldSpawnSeatCapsules => vehicleAsset.shouldSpawnSeatCapsules;

        [ScriptProperty("supportsMobileBuildables")]
        public bool SupportsMobileBuildables => vehicleAsset.supportsMobileBuildables;

        [ScriptProperty("isBatteryPowered")]
        public bool IsBatteryPowered => vehicleAsset.isBatteryPowered;

        [ScriptProperty("isStaminaPowered")]
        public bool IsStaminaPowered => vehicleAsset.isStaminaPowered;

        [ScriptProperty("useStaminaBoost")]
        public bool UseStaminaBoost => vehicleAsset.useStaminaBoost;

        [ScriptProperty("canStealBattery")]
        public bool CanStealBattery => vehicleAsset.canStealBattery;

        [ScriptProperty("hasHorn")]
        public bool HasHorn => vehicleAsset.hasHorn;

        [ScriptProperty("canSpawnWithBattery")]
        public bool CanSpawnWithBattery => vehicleAsset.canSpawnWithBattery;

        [ScriptProperty("shouldExplosionCauseDamage")]
        public bool ShouldExplosionCauseDamage => vehicleAsset.ShouldExplosionCauseDamage;

        [ScriptProperty("shouldExplosionBurnMaterials")]
        public bool ShouldExplosionBurnMaterials => vehicleAsset.ShouldExplosionBurnMaterials;

        [ScriptProperty("passengerExplosionArmor")]
        public float PassengerExplosionArmor => vehicleAsset.passengerExplosionArmor;

        [ScriptProperty("bumperMultiplier")]
        public float BumperMultiplier => vehicleAsset.bumperMultiplier;

        [ScriptProperty("sqrDelta")]
        public float SqrDelta => vehicleAsset.sqrDelta;

        [ScriptProperty("exit")]
        public float Exit => vehicleAsset.exit;

        [ScriptProperty("camFollowDistance")]
        public float CamFollowDistance => vehicleAsset.camFollowDistance;

        [ScriptProperty("brake")]
        public float Brake => vehicleAsset.brake;

        [ScriptProperty("steerMin")]
        public float SteerMin => vehicleAsset.steerMin;

        [ScriptProperty("speedMax")]
        public float SpeedMax => vehicleAsset.speedMax;

        [ScriptProperty("speedMin")]
        public float SpeedMin => vehicleAsset.speedMin;

        [ScriptProperty("pitchDrive")]
        public float PitchDrive => vehicleAsset.pitchDrive;

        [ScriptProperty("pitchIdle")]
        public float PitchIdle => vehicleAsset.pitchIdle;

        [ScriptProperty("lift")]
        public float Lift => vehicleAsset.lift;

        [ScriptProperty("size2_z")]
        public float Size2_z => vehicleAsset.size2_z;

        [ScriptProperty("steerMax")]
        public float SteerMax => vehicleAsset.steerMax;

        [ScriptProperty("camPassengerOffset")]
        public float CamPassengerOffset => vehicleAsset.camPassengerOffset;

        [ScriptProperty("childExplosionArmorMultiplier")]
        public float ChildExplosionArmorMultiplier => vehicleAsset.childExplosionArmorMultiplier;

        [ScriptProperty("camDriverOffset")]
        public float CamDriverOffset => vehicleAsset.camDriverOffset;

        [ScriptProperty("fuelBurnRate")]
        public float FuelBurnRate => vehicleAsset.fuelBurnRate;

        [ScriptProperty("validSpeedDown")]
        public float ValidSpeedDown => vehicleAsset.validSpeedDown;

        [ScriptProperty("validSpeedUp")]
        public float ValidSpeedUp => vehicleAsset.validSpeedUp;

        [ScriptProperty("airSteerMin")]
        public float AirSteerMin => vehicleAsset.airSteerMin;

        [ScriptProperty("bicycleAnimSpeed")]
        public float BicycleAnimSpeed => vehicleAsset.bicycleAnimSpeed;

        [ScriptProperty("wheelColliderMassOverride")]
        public float WheelColliderMassOverride => vehicleAsset.wheelColliderMassOverride != null ? (float)vehicleAsset.wheelColliderMassOverride : 0;

        [ScriptProperty("airSteerMax")]
        public float AirSteerMax => vehicleAsset.airSteerMax;

        [ScriptProperty("staminaBoost")]
        public float StaminaBoost => vehicleAsset.staminaBoost;

        [ScriptProperty("trainCarLength")]
        public float TrainCarLength => vehicleAsset.trainCarLength;

        [ScriptProperty("trainWheelOffset")]
        public float TrainWheelOffset => vehicleAsset.trainWheelOffset;

        [ScriptProperty("trainTrackOffset")]
        public float TrainTrackOffset => vehicleAsset.trainTrackOffset;

        [ScriptProperty("airTurnResponsiveness")]
        public float AirTurnResponsiveness => vehicleAsset.airTurnResponsiveness;

        [ScriptProperty("batteryChargeRate")]
        public float BatteryChargeRate => vehicleAsset.batteryChargeRate;

        [ScriptProperty("batteryBurnRate")]
        public float BatteryBurnRate => vehicleAsset.batteryBurnRate;

        [ScriptProperty("batterySpawnChargeMultiplier")]
        public float BatterySpawnChargeMultiplier => vehicleAsset.batterySpawnChargeMultiplier;

        [ScriptProperty("fuelMin")]
        public ushort FuelMin => vehicleAsset.fuelMin;

        [ScriptProperty("sharedSkinLookupID")]
        public ushort SharedSkinLookupID => vehicleAsset.sharedSkinLookupID;

        [ScriptProperty("healthMax")]
        public ushort HealthMax => vehicleAsset.healthMax;

        [ScriptProperty("health")]
        public ushort Health => vehicleAsset.health;

        [ScriptProperty("healthMin")]
        public ushort HealthMin => vehicleAsset.healthMin;

        [ScriptProperty("explosion")]
        public ushort Explosion => vehicleAsset.explosion;

        [ScriptProperty("fuel")]
        public ushort Fuel => vehicleAsset.fuel;

        [ScriptProperty("fuelMax")]
        public ushort FuelMax => vehicleAsset.fuelMax;

        [ScriptProperty("tireID")]
        public ushort TireID => vehicleAsset.tireID;

        [ScriptProperty("dropsTableId")]
        public ushort DropsTableId => vehicleAsset.dropsTableId;

        [ScriptProperty("friendlyName")]
        public string FriendlyName => vehicleAsset.FriendlyName;

        [ScriptProperty("vehicleName")]
        public string VehicleName => vehicleAsset.vehicleName;

        [ScriptProperty("sharedSkinName")]
        public string SharedSkinName => vehicleAsset.sharedSkinName;

        [ScriptProperty("batterySirens")]
        public string BatterySirens => vehicleAsset.batterySirens.ToString(); // EBatteryMode

        [ScriptProperty("batteryHeadlights")]
        public string BatteryHeadlights => vehicleAsset.batteryHeadlights.ToString(); // EBatteryMode

        [ScriptProperty("batteryDriving")]
        public string BatteryDriving => vehicleAsset.batteryDriving.ToString(); // EBatteryMode

        [ScriptProperty("batteryEmpty")]
        public string BatteryEmpty => vehicleAsset.batteryEmpty.ToString(); // EBatteryMode

        [ScriptProperty("assetCategory")]
        public string AssetCategory => vehicleAsset.assetCategory.ToString(); // EAssetType

        [ScriptProperty("engine")]
        public string Engine => vehicleAsset.engine.ToString(); // EEngine

        [ScriptProperty("rarity")]
        public string Rarity => vehicleAsset.rarity.ToString(); // EItemRarity

        [ScriptProperty("explosionEffectGuid")]
        public string ExplosionEffectGuid => vehicleAsset.ExplosionEffectGuid.ToString("N"); // GUID

        [ScriptProperty("dropsMax")]
        public byte DropsMax => vehicleAsset.dropsMin;

        [ScriptProperty("dropsMin")]
        public byte DropsMin => vehicleAsset.dropsMax;

        [ScriptProperty("numSteeringTires")]
        public int NumSteeringTires => vehicleAsset.numSteeringTires;

        [ScriptProperty("centerOfMass")]
        public Vector3Class CenterOfMass => new Vector3Class(vehicleAsset.centerOfMass);

        [ScriptProperty("trunkStorage_Y")]
        public byte TrunkStorage_Y
        {
            get => vehicleAsset.trunkStorage_Y;
            set => vehicleAsset.trunkStorage_Y = value;
        }

        [ScriptProperty("trunkStorage_X")]
        public byte TrunkStorage_X
        {
            get => vehicleAsset.trunkStorage_X;
            set => vehicleAsset.trunkStorage_X = value;
        }

        [ScriptProperty("MinExplosionForce")]
        public Vector3Class minExplosionForce
        {
            get => new Vector3Class(vehicleAsset.minExplosionForce);
            set => vehicleAsset.minExplosionForce = value.Vector3;
        }

        [ScriptProperty("maxExplosionForce")]
        public Vector3Class MaxExplosionForce
        {
            get => new Vector3Class(vehicleAsset.maxExplosionForce);
            set => vehicleAsset.maxExplosionForce = value.Vector3;
        }

        [ScriptFunction("IsExplosionEffectRefNull")]
        public bool IsExplosionEffectRefNull()
        {
            return vehicleAsset.IsExplosionEffectRefNull();
        }
    }
}