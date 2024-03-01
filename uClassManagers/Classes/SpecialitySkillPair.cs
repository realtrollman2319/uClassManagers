using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("SpecialitySkillPair")]
    public class SpecialitySkillPairClass
    {
        public SpecialitySkillPair specialitySkillPair { get; private set; }
        public SpecialitySkillPairClass(SpecialitySkillPair c_SpecialitySkillPair) => specialitySkillPair = c_SpecialitySkillPair;

        [ScriptConstructor]
        public SpecialitySkillPairClass(int newSpeciality, int newSkill) => specialitySkillPair = new SpecialitySkillPair(newSpeciality, newSkill);

        [ScriptProperty("speciality")]
        public int Speciality => specialitySkillPair.speciality;

        [ScriptProperty("skill")]
        public int Skill => specialitySkillPair.skill;
    }
}