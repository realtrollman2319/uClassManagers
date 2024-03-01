using SDG.Unturned;
using Steamworks;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerLife")]
    public class PlayerLifeClass
    {
        public PlayerLife playerLife { get; private set; }
        public PlayerLifeClass(PlayerLife c_PlayerLife) => playerLife = c_PlayerLife;

        [ScriptProperty("SAVEDATA_VERSION_LATEST")]
        public byte SAVEDATA_VERSION_LATEST => PlayerLife.SAVEDATA_VERSION_LATEST;

        [ScriptProperty("SAVEDATA_VERSION_WITH_OXYGEN")]
        public byte SAVEDATA_VERSION_WITH_OXYGEN => PlayerLife.SAVEDATA_VERSION_WITH_OXYGEN;

        [ScriptProperty("deathCause")]
        public string DeathCause => PlayerLife.deathCause.ToString();

        [ScriptProperty("deathKiller")]
        public string DeathKiller => PlayerLife.deathKiller.m_SteamID.ToString();

        [ScriptProperty("deathLimb")]
        public string DeathLimb => PlayerLife.deathLimb.ToString();

        [ScriptProperty("isDead")]
        public bool IsDead => playerLife.isDead;

        [ScriptProperty("IsAlive")]
        public bool IsAlive => playerLife.IsAlive;

        [ScriptProperty("health")]
        public byte Health => playerLife.health;

        [ScriptProperty("wasPvPDeath")]
        public bool WasPvPDeath => playerLife.wasPvPDeath;

        [ScriptProperty("isBleeding")]
        public bool IsBleeding => playerLife.isBleeding;

        [ScriptProperty("virus")]
        public byte Virus => playerLife.virus;

        [ScriptProperty("vision")]
        public byte Vision => playerLife.vision;

        [ScriptProperty("warmth")]
        public uint Warmth => playerLife.warmth;

        [ScriptProperty("stamina")]
        public byte Stamina => playerLife.stamina;

        [ScriptProperty("food")]
        public byte Food => playerLife.food;

        [ScriptProperty("oxygen")]
        public byte Oxygen => playerLife.oxygen;

        [ScriptProperty("isAggressor")]
        public bool IsAggressor => playerLife.isAggressor;

        [ScriptProperty("isBroken")]
        public bool IsBroken => playerLife.isBroken;

        [ScriptProperty("water")]
        public byte Water => playerLife.water;

        [ScriptProperty("temperature")]
        public string Temperature => playerLife.temperature.ToString();

        [ScriptProperty("lastRespawn")]
        public float LastRespawn => playerLife.lastRespawn;

        [ScriptProperty("lastDeath")]
        public float LastDeath => playerLife.lastDeath;

        [ScriptFunction("askBlind")]
        public void AskBlind(byte amount)
        {
            playerLife.askBlind(amount);
        }

        [ScriptFunction("askBreath")]
        public void AskBreath(byte amount)
        {
            playerLife.askBreath(amount);
        }

        [ScriptFunction("askDamage")]
        public string AskDamage(byte amount, Vector3Class newRagdoll, string newCause, string newLimb, string newKiller)
        {
            EDeathCause? cause = EnumTool.deathCauses.GetEnum(newCause);
            ELimb? limb = EnumTool.limbs.GetEnum(newLimb);
            if (cause == null) return null;
            if (limb == null) return null;
            playerLife.askDamage(amount, newRagdoll.Vector3, cause.Value, limb.Value, new CSteamID(ulong.Parse(newKiller)), out EPlayerKill kill);
            return kill.ToString();
        }

        [ScriptFunction("askDamage")]
        public string AskDamage(byte amount, Vector3Class newRagdoll, string newCause, string newLimb, string newKiller, bool trackKill = false, string newRagdollEffect = "none", bool canCauseBleeding = true, bool bypassSafezone = false)
        {
            EDeathCause? cause = EnumTool.deathCauses.GetEnum(newCause);
            ELimb? limb = EnumTool.limbs.GetEnum(newLimb);
            ERagdollEffect? ragdollEffect = EnumTool.ragdollEffects.GetEnum(newRagdollEffect);
            if (cause == null) return null;
            if (limb == null) return null;
            if (ragdollEffect == null) return null;
            playerLife.askDamage(amount, newRagdoll.Vector3, cause.Value, limb.Value, new CSteamID(ulong.Parse(newKiller)), out EPlayerKill kill, trackKill, ragdollEffect.Value, canCauseBleeding, bypassSafezone);
            return kill.ToString();
        }

        [ScriptFunction("askDamage")]
        public string AskDamage(byte amount, Vector3Class newRagdoll, string newCause, string newLimb, string newKiller, bool trackKill = false, string newRagdollEffect = "none", bool canCauseBleeding = true)
        {
            EDeathCause? cause = EnumTool.deathCauses.GetEnum(newCause);
            ELimb? limb = EnumTool.limbs.GetEnum(newLimb);
            ERagdollEffect? ragdollEffect = EnumTool.ragdollEffects.GetEnum(newRagdollEffect);
            if (cause == null) return null;
            if (limb == null) return null;
            if (ragdollEffect == null) return null;
            playerLife.askDamage(amount, newRagdoll.Vector3, cause.Value, limb.Value, new CSteamID(ulong.Parse(newKiller)), out EPlayerKill kill, trackKill, ragdollEffect.Value, canCauseBleeding);
            return kill.ToString();
        }

        [ScriptFunction("askDamage")]
        public string AskDamage(byte amount, Vector3Class newRagdoll, string newCause, string newLimb, string newKiller, bool trackKill = false, string newRagdollEffect = "none")
        {
            EDeathCause? cause = EnumTool.deathCauses.GetEnum(newCause);
            ELimb? limb = EnumTool.limbs.GetEnum(newLimb);
            ERagdollEffect? ragdollEffect = EnumTool.ragdollEffects.GetEnum(newRagdollEffect);
            if (cause == null) return null;
            if (limb == null) return null;
            if (ragdollEffect == null) return null;
            playerLife.askDamage(amount, newRagdoll.Vector3, cause.Value, limb.Value, new CSteamID(ulong.Parse(newKiller)), out EPlayerKill kill, trackKill, ragdollEffect.Value);
            return kill.ToString();
        }

        [ScriptFunction("askDehydrate")]
        public void AskDehydrate(byte amount)
        {
            playerLife.askDehydrate(amount);
        }

        [ScriptFunction("askDisinfect")]
        public void AskDisinfect(byte amount)
        {
            playerLife.askDisinfect(amount);
        }

        [ScriptFunction("askDrink")]
        public void AskDrink(byte amount)
        {
            playerLife.askDrink(amount);
        }

        [ScriptFunction("askEat")]
        public void AskEat(byte amount)
        {
            playerLife.askEat(amount);
        }

        [ScriptFunction("askHeal")]
        public void AskHeal(byte amount, bool healBleeding, bool healBroken)
        {
            playerLife.askHeal(amount, healBleeding, healBroken);
        }

        [ScriptFunction("askInfect")]
        public void AskInfect(byte amount)
        {
            playerLife.askInfect(amount);
        }

        [ScriptFunction("askRadiate")]
        public void AskRadiate(byte amount)
        {
            playerLife.askRadiate(amount);
        }

        [ScriptFunction("askRest")]
        public void AskRest(byte amount)
        {
            playerLife.askRest(amount);
        }

        [ScriptFunction("askStarve")]
        public void AskStarve(byte amount)
        {
            playerLife.askStarve(amount);
        }

        [ScriptFunction("askSuffocate")]
        public void AskSuffocate(byte amount)
        {
            playerLife.askSuffocate(amount);
        }

        [ScriptFunction("askTire")]
        public void AskTire(byte amount)
        {
            playerLife.askTire(amount);
        }

        [ScriptFunction("askView")]
        public void AskView(byte amount)
        {
            playerLife.askView(amount);
        }

        [ScriptFunction("breakLegs")]
        public void BreakLegs()
        {
            playerLife.breakLegs();
        }

        [ScriptFunction("load")]
        public void Load()
        {
            playerLife.load();
        }

        [ScriptFunction("markAggressive")]
        public void MarkAggressive(bool force, bool spreadToGroup = true)
        {
            playerLife.markAggressive(force, spreadToGroup);
        }

        [ScriptFunction("save")]
        public void Save()
        {
            playerLife.save();
        }

        [ScriptFunction("sendRespawn")]
        public void SendRespawn(bool atHome)
        {
            playerLife.sendRespawn(atHome);
        }

        [ScriptFunction("sendRevive")]
        public void SendRevive()
        {
            playerLife.sendRevive();
        }

        [ScriptFunction("sendSuicide")]
        public void SendSuicide()
        {
            playerLife.sendSuicide();
        }

        [ScriptFunction("serverModifyFood")]
        public void ServerModifyFood(float delta)
        {
            playerLife.serverModifyFood(delta);
        }

        [ScriptFunction("serverModifyHallucination")]
        public void ServerModifyHallucination(float delta)
        {
            playerLife.serverModifyHallucination(delta);
        }

        [ScriptFunction("serverModifyHealth")]
        public void ServerModifyHealth(float delta)
        {
            playerLife.serverModifyHealth(delta);
        }

        [ScriptFunction("serverModifyStamina")]
        public void ServerModifyStamina(float delta)
        {
            playerLife.serverModifyStamina(delta);
        }

        [ScriptFunction("serverModifyVirus")]
        public void ServerModifyVirus(float delta)
        {
            playerLife.serverModifyVirus(delta);
        }

        [ScriptFunction("serverModifyWarmth")]
        public void ServerModifyWarmth(float delta)
        {
            playerLife.serverModifyWarmth(delta);
        }

        [ScriptFunction("serverModifyWater")]
        public void ServerModifyWater(float delta)
        {
            playerLife.serverModifyWater(delta);
        }

        [ScriptFunction("ServerRespawn")]
        public void ServerRespawn(bool atHome)
        {
            playerLife.ServerRespawn(atHome);
        }

        [ScriptFunction("serverSetBleeding")]
        public void ServerSetBleeding(bool newBleeding)
        {
            playerLife.serverSetBleeding(newBleeding);
        }

        [ScriptFunction("serverSetLegsBroken")]
        public void ServerSetLegsBroken(bool newLegsBroken)
        {
            playerLife.serverSetLegsBroken(newLegsBroken);
        }

        [ScriptFunction("simulate")]
        public void Simulate(uint simulation)
        {
            playerLife.simulate(simulation);
        }

        [ScriptFunction("simulatedModifyOxygen")]
        public void SimulatedModifyOxygen(float delta)
        {
            playerLife.simulatedModifyOxygen(delta);
        }
    }
}
