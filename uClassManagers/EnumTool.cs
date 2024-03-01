using SDG.Unturned;
using System;
using System.Linq;

namespace uClassManagers
{
    public enum AssetType
    {
        ITEM,
        EFFECT,
        VEHICLE,
        ANIMAL,
        QUEST
    }

    public static class EnumTool
    {
        public static UnturnedEnum<AssetType> assetTypes;
        public static UnturnedEnum<ERagdollEffect> ragdollEffects;
        public static UnturnedEnum<EPluginWidgetFlags> pluginWidgetFlags;
        public static UnturnedEnum<EPlayerStat> playerStats;
        public static UnturnedEnum<EPlayerKill> playerKills;
        public static UnturnedEnum<EPlayerMessage> playerMessages;
        public static UnturnedEnum<EPlayerGesture> playerGestures;
        public static UnturnedEnum<EVisualToggleType> visualToggleTypes;
        public static UnturnedEnum<EItemOrigin> itemOrigins;
        public static UnturnedEnum<EAttackInputFlags> attackInputFlags;
        public static UnturnedEnum<EZombieSpeciality> zombieSpecialities;
        public static UnturnedEnum<EZombieStunOverride> zombieStunOverrides;
        public static UnturnedEnum<EDeathCause> deathCauses;
        public static UnturnedEnum<ELimb> limbs;
        public static UnturnedEnum<EGraphicQuality> graphicQualities;
        public static UnturnedEnum<EPlayerHeight> playerHeights;
        public static UnturnedEnum<EPlayerGroupRank> playerGroupRanks;
        public static UnturnedEnum<EPlayerStance> playerStances;
        public static UnturnedEnum<EDragMode> dragModes;
        public static UnturnedEnum<EDragCoordinate> dragCoordinates;
        public static UnturnedEnum<EDamageOrigin> damageOrigins;
        public static UnturnedEnum<ERaycastInfoUsage> raycastInfoUsages;
        // public static UnturnedEnum<ETestEnum> testEnums;

        public static void CreateEnums()
        {
            assetTypes = new UnturnedEnum<AssetType>();
            ragdollEffects = new UnturnedEnum<ERagdollEffect>();
            pluginWidgetFlags = new UnturnedEnum<EPluginWidgetFlags>();
            playerStats = new UnturnedEnum<EPlayerStat>();
            playerKills = new UnturnedEnum<EPlayerKill>();
            playerMessages = new UnturnedEnum<EPlayerMessage>();
            playerGestures = new UnturnedEnum<EPlayerGesture>();
            visualToggleTypes = new UnturnedEnum<EVisualToggleType>();
            itemOrigins = new UnturnedEnum<EItemOrigin>();
            attackInputFlags = new UnturnedEnum<EAttackInputFlags>();
            zombieSpecialities = new UnturnedEnum<EZombieSpeciality>();
            zombieStunOverrides = new UnturnedEnum<EZombieStunOverride>();
            deathCauses = new UnturnedEnum<EDeathCause>();
            limbs = new UnturnedEnum<ELimb>();
            graphicQualities = new UnturnedEnum<EGraphicQuality>();
            playerHeights = new UnturnedEnum<EPlayerHeight>();
            playerGroupRanks = new UnturnedEnum<EPlayerGroupRank>();
            playerStances = new UnturnedEnum<EPlayerStance>();
            dragModes = new UnturnedEnum<EDragMode>();
            dragCoordinates = new UnturnedEnum<EDragCoordinate>();
            damageOrigins = new UnturnedEnum<EDamageOrigin>();
            raycastInfoUsages = new UnturnedEnum<ERaycastInfoUsage>();
        }
    }

    public class UnturnedEnum<TEnum> where TEnum : struct, Enum
    {
        public TEnum? GetEnum(string input)
        {
            if (Enum.TryParse(input, true, out TEnum result))
            {
                return result;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[uClassManagers] Invalid enum specified! It must be one of the following:");
                Console.WriteLine(string.Join(", ", Enum.GetNames(typeof(TEnum))).ToArray());
                Console.WriteLine("[uClassManagers] Input dosen't need to be case sensitive.");
                Console.ResetColor();
                return null;
            }
        }
    }
}