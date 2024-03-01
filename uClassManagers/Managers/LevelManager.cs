using SDG.Unturned;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Managers
{
    [ScriptModule("LevelManager")]
    public class LevelManagerClass
    {
        [ScriptProperty("SAVEDATA_VERSION")]
        public static float SAVEDATA_VERSION => LevelManager.SAVEDATA_VERSION;

        [ScriptProperty("airdropFrequency")]
        public static uint AirdropFrequency => LevelManager.airdropFrequency;

        [ScriptProperty("arenaTargetRadius")]
        public static float ArenaTargetRadius => LevelManager.arenaTargetRadius;

        [ScriptProperty("arenaOriginRadius")]
        public static float ArenaOriginRadius => LevelManager.arenaOriginRadius;

        [ScriptProperty("arenaCurrentRadius")]
        public static float ArenaCurrentRadius => LevelManager.arenaCurrentRadius;

        [ScriptProperty("compactorSpeed")]
        public static float CompactorSpeed => LevelManager.compactorSpeed;

        [ScriptProperty("arenaCompactorSpeed")]
        public static float ArenaCompactorSpeed => LevelManager.arenaCompactorSpeed;

        [ScriptProperty("arenaTargetCenter")]
        public static Vector3Class ArenaTargetCenter => new Vector3Class(LevelManager.arenaTargetCenter);

        [ScriptProperty("arenaOriginCenter")]
        public static Vector3Class ArenaOriginCenter => new Vector3Class(LevelManager.arenaOriginCenter);

        [ScriptProperty("arenaCurrentCenter")]
        public static Vector3Class ArenaCurrentCenter => new Vector3Class(LevelManager.arenaCurrentCenter);

        [ScriptProperty("levelType")]
        public static string LevelType => LevelManager.levelType.ToString();

        [ScriptProperty("arenaState")]
        public static string ArenaState => LevelManager.arenaState.ToString();

        [ScriptProperty("arenaMessage")]
        public static string ArenaMessage => LevelManager.arenaMessage.ToString();

        [ScriptProperty("hasAirdrop")]
        public static bool HasAirdrop => LevelManager.hasAirdrop;

        [ScriptProperty("isArenaMode")]
        public static bool IsArenaMode => LevelManager.isArenaMode;

        [ScriptFunction("isPlayerInArena")]
        public static bool isPlayerInArena(PlayerClass player)
        {
            return LevelManager.isPlayerInArena(player.Player);
        }

        [ScriptFunction("airdrop")]
        public static void Airdrop(Vector3Class point, ushort id, float speed)
        {
            LevelManager.airdrop(point.Vector3, id, speed);
        }

        [ScriptFunction("load")]
        public static void Load()
        {
            LevelManager.load();
        }

        [ScriptFunction("save")]
        public static void Save()
        {
            LevelManager.save();
        }
    }
}