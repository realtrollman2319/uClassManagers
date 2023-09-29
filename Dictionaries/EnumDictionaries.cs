using SDG.Unturned;
using System.Collections.Generic;

namespace uClassManagers.Dictionaries
{
    public static class EnumDictionaries
    {
        public static readonly Dictionary<string, ERagdollEffect> ERagdollEffects = new Dictionary<string, ERagdollEffect>() // Thanks Molyi
        {
            { "NONE", ERagdollEffect.NONE },
            { "BRONZE", ERagdollEffect.BRONZE },
            { "SILVER", ERagdollEffect.SILVER },
            { "GOLD", ERagdollEffect.GOLD },
            { "ZERO", ERagdollEffect.ZERO_KELVIN }
        };

        public static readonly Dictionary<string, EPlayerKill> EPlayerKills = new Dictionary<string, EPlayerKill>()
        {
            { "NONE", EPlayerKill.NONE },
            { "PLAYER", EPlayerKill.PLAYER },
            { "ZOMBIE", EPlayerKill.ZOMBIE },
            { "MEGA", EPlayerKill.MEGA },
            { "ANIMAL", EPlayerKill.ANIMAL },
            { "RESOURCE", EPlayerKill.RESOURCE },
            { "OBJECT", EPlayerKill.OBJECT }
        };

        public static readonly Dictionary<string, EDamageOrigin> EDamageOrigins = new Dictionary<string, EDamageOrigin>()
        {
            { "Unknown", EDamageOrigin.Unknown },
            { "Mega_Zombie_Boulder", EDamageOrigin.Mega_Zombie_Boulder },
            { "Vehicle_Bumper", EDamageOrigin.Vehicle_Bumper },
            { "Horde_Beacon_Self_Destruct", EDamageOrigin.Horde_Beacon_Self_Destruct },
            { "Trap_Wear_And_Tear", EDamageOrigin.Trap_Wear_And_Tear },
            { "Carepackage_Timeout", EDamageOrigin.Carepackage_Timeout },
            { "Plant_Harvested", EDamageOrigin.Plant_Harvested },
            { "Charge_Self_Destruct", EDamageOrigin.Charge_Self_Destruct },
            { "Zombie_Swipe", EDamageOrigin.Zombie_Swipe },
            { "Grenade_Explosion", EDamageOrigin.Grenade_Explosion },
            { "Rocket_Explosion", EDamageOrigin.Rocket_Explosion },
            { "Food_Explosion", EDamageOrigin.Food_Explosion },
            { "Vehicle_Explosion", EDamageOrigin.Vehicle_Explosion },
            { "Charge_Explosion", EDamageOrigin.Charge_Explosion },
            { "Trap_Explosion", EDamageOrigin.Trap_Explosion },
            { "Bullet_Explosion", EDamageOrigin.Bullet_Explosion },
            { "Radioactive_Zombie_Explosion", EDamageOrigin.Radioactive_Zombie_Explosion },
            { "Flamable_Zombie_Explosion", EDamageOrigin.Flamable_Zombie_Explosion },
            { "Zombie_Electric_Shock", EDamageOrigin.Zombie_Electric_Shock },
            { "Zombie_Stomp", EDamageOrigin.Zombie_Stomp },
            { "Zombie_Fire_Breath", EDamageOrigin.Zombie_Fire_Breath },
            { "Sentry", EDamageOrigin.Sentry },
            { "Useable_Gun", EDamageOrigin.Useable_Gun },
            { "Useable_Melee", EDamageOrigin.Useable_Melee },
            { "Punch", EDamageOrigin.Punch },
            { "Animal_Attack", EDamageOrigin.Animal_Attack },
            { "Kill_Volume", EDamageOrigin.Kill_Volume },
            { "Vehicle_Collision_Self_Damage", EDamageOrigin.Vehicle_Collision_Self_Damage },
            { "Lightning", EDamageOrigin.Lightning },
            { "VehicleDecay", EDamageOrigin.VehicleDecay },
        };
    }
}
