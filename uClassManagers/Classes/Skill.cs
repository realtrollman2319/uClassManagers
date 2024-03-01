using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("Skill")]
    public class SkillClass
    {
        public Skill skill { get; private set; }
        public SkillClass(Skill c_Skill) => skill = c_Skill;

        [ScriptConstructor]
        public SkillClass(byte newLevel, byte newMax, uint newCost, float newDifficulty) => skill = new Skill(newLevel, newMax, newCost, newDifficulty);

        [ScriptProperty("level")]
        public byte Level => skill.level;

        [ScriptProperty("max")]
        public byte Max => skill.max;

        [ScriptProperty("maxUnlockableLevel")]
        public int MaxUnlockableLevel => skill.maxUnlockableLevel;

        [ScriptProperty("costMultiplier")]
        public float CostMultiplier => skill.costMultiplier;

        [ScriptProperty("mastery")]
        public float Mastery => skill.mastery;

        [ScriptProperty("cost")]
        public uint Cost => skill.cost;

        [ScriptFunction("GetClampedMaxUnlockableLevel")]
        public int GetClampedMaxUnlockableLevel()
        {
            return skill.GetClampedMaxUnlockableLevel();
        }

        [ScriptFunction("setLevelToMax")]
        public void SetLevelToMax()
        {
            skill.setLevelToMax();
        }
    }
}