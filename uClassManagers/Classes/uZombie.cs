using SDG.Unturned;
using System.Collections.Generic;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("uZombie")] // Conflict with uScriptExtended
    public class uZombieClass
    {
        public Zombie zombie { get; private set; }
        public uZombieClass(Zombie c_Zombie) => zombie = c_Zombie;

        [ScriptProperty("id")]
        public ushort Id => zombie.id;

        [ScriptProperty("isUpdated")]
        public bool IsUpdated => zombie.isUpdated;

        [ScriptProperty("idleAnim")]
        public string IdleAnim => zombie.idleAnim;

        [ScriptProperty("gear")]
        public byte Gear => zombie.gear;

        [ScriptProperty("hat")]
        public byte Hat => zombie.hat;

        [ScriptProperty("isDead")]
        public bool IsDead => zombie.isDead;

        [ScriptProperty("shirt")]
        public byte Shirt => zombie.shirt;

        [ScriptProperty("speciality")]
        public string Speciality => zombie.speciality.ToString();

        [ScriptProperty("type")]
        public byte Type => zombie.type;

        [ScriptProperty("bound")]
        public byte Bound => zombie.bound;

        [ScriptProperty("pants")]
        public byte Pants => zombie.pants;

        [ScriptProperty("isMega")]
        public bool IsMega => zombie.isMega;

        [ScriptProperty("isBoss")]
        public bool IsBoss => zombie.isBoss;

        [ScriptProperty("isRadioactive")]
        public bool IsRadioactive => zombie.isRadioactive;

        [ScriptProperty("isHyper")]
        public bool IsHyper => zombie.isHyper;

        [ScriptProperty("lastDead")]
        public float LastDead => zombie.lastDead;

        [ScriptProperty("isHunting")]
        public bool IsHunting => zombie.isHunting;

        [ScriptProperty("idle")]
        public byte Idle => zombie.idle;

        [ScriptProperty("move")]
        public byte Move => zombie.move;

        [ScriptProperty("isCutesy")]
        public bool IsCutesy => zombie.isCutesy;

        [ScriptFunction("alert")]
        public void Alert(Vector3Class newPosition, bool isStartling)
        {
            zombie.alert(newPosition.Vector3, isStartling);
        }

        [ScriptFunction("alert")]
        public void Alert(PlayerClass newPlayer)
        {
            zombie.alert(newPlayer.Player);
        }

        [ScriptFunction("askAcid")]
        public void AskAcid(Vector3Class origin, Vector3Class direction)
        {
            zombie.askAcid(origin.Vector3, direction.Vector3);
        }

        [ScriptFunction("askAttack")]
        public void AskAttack(byte id)
        {
            zombie.askAttack(id);
        }

        [ScriptFunction("askBoulder")]
        public void AskBoulder(Vector3Class origin, Vector3Class direction)
        {
            zombie.askBoulder(origin.Vector3, direction.Vector3);
        }

        [ScriptFunction("askBreath")]
        public void AskBreath()
        {
            zombie.askBreath();
        }

        [ScriptFunction("askCharge")]
        public void AskCharge()
        {
            zombie.askCharge();
        }

        [ScriptFunction("askDamage")]
        public ExpressionValue AskDamage(ushort amount, Vector3Class newRagdoll, bool trackKill = true, bool dropLoot = true, string stunOverride = "none", string ragdollEffect = "none")
        {
            EZombieStunOverride? sOverride = EnumTool.zombieStunOverrides.GetEnum(stunOverride);
            ERagdollEffect? rEffect = EnumTool.ragdollEffects.GetEnum(ragdollEffect);
            if (stunOverride == null) return ExpressionValue.Null;
            if (rEffect == null) return ExpressionValue.Null;
            zombie.askDamage(amount, newRagdoll.Vector3, out EPlayerKill kill, out uint xp, trackKill, dropLoot, sOverride.Value, rEffect.Value);
            List<ExpressionValue> list = new List<ExpressionValue>() { kill.ToString(), xp };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("askSpark")]
        public void AskSpark(Vector3Class target)
        {
            zombie.askSpark(target.Vector3);
        }

        [ScriptFunction("askSpit")]
        public void AskSpit()
        {
            zombie.askSpit();
        }

        [ScriptFunction("askStartle")]
        public void AskStartle(byte id)
        {
            zombie.askStartle(id);
        }

        [ScriptFunction("askStomp")]
        public void AskStomp()
        {
            zombie.askStomp();
        }

        [ScriptFunction("askStun")]
        public void AskStun(byte id)
        {
            zombie.askStun(id);
        }

        [ScriptFunction("askThrow")]
        public void AskThrow()
        {
            zombie.askThrow();
        }

        [ScriptFunction("checkAlert")]
        public bool CheckAlert(PlayerClass newPlayer)
        {
            return zombie.checkAlert(newPlayer.Player);
        }

        [ScriptFunction("getBulletResistance")]
        public float GetBulletResistance()
        {
            return zombie.getBulletResistance();
        }

        [ScriptFunction("GetHealth")]
        public float GetHealth()
        {
            return zombie.GetHealth();
        }

        [ScriptFunction("GetMaxHealth")]
        public float GetMaxHealth()
        {
            return zombie.GetMaxHealth();
        }

        [ScriptFunction("getStunDamageThreshold")]
        public int GetStunDamageThreshold()
        {
            return zombie.getStunDamageThreshold();
        }

        [ScriptFunction("init")]
        public void Init()
        {
            zombie.init();
        }

        [ScriptFunction("killWithFireExplosion")]
        public void KillWithFireExplosion()
        {
            zombie.killWithFireExplosion();
        }

        [ScriptFunction("sendRevive")]
        public void SendRevive(byte type, byte speciality, byte shirt, byte pants, byte hat, byte gear, Vector3Class position, float angle)
        {
            zombie.sendRevive(type, speciality, shirt, pants, hat, gear, position.Vector3, angle);
        }

        [ScriptFunction("tellAlive")]
        public void TellAlive(byte newType, byte newSpeciality, byte newShirt, byte newPants, byte newHat, byte newGear, Vector3Class newPosition, byte newAngle)
        {
            zombie.tellAlive(newType, newSpeciality, newShirt, newPants, newHat, newGear, newPosition.Vector3, newAngle);
        }

        [ScriptFunction("tellDead")]
        public void TellDead(Vector3Class newRagdoll, string ragdollEffect)
        {
            ERagdollEffect? rEffect = EnumTool.ragdollEffects.GetEnum(ragdollEffect);
            if (rEffect == null) return;
            zombie.tellDead(newRagdoll.Vector3, rEffect.Value);
        }

        [ScriptFunction("tellSpeciality")]
        public void TellSpeciality(string newSpeciality)
        {
            EZombieSpeciality? speciality = EnumTool.zombieSpecialities.GetEnum(newSpeciality);
            if (speciality == null) return;
            zombie.tellSpeciality(speciality.Value);
        }

        [ScriptFunction("tellState")]
        public void TellState(Vector3Class newPosition, float newYaw)
        {
            zombie.tellState(newPosition.Vector3, newYaw);
        }

        [ScriptFunction("tick")]
        public void Tick()
        {
            zombie.tick();
        }

        [ScriptFunction("updateStates")]
        public void UpdateStates()
        {
            zombie.updateStates();
        }
    }
}
