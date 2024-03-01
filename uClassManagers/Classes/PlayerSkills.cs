using SDG.Unturned;
using System.Collections.Generic;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerSkills")]
    public class PlayerSkillsClass
    {
        public PlayerSkills playerSkills { get; private set; }
        public PlayerSkillsClass(PlayerSkills c_PlayerSkills) => playerSkills = c_PlayerSkills;

        [ScriptProperty("SKILLSETS")]
        public static ExpressionValue SKILLSETS
        {
            get
            {
                List<ExpressionValue> listA = new List<ExpressionValue>();
                foreach (SpecialitySkillPair[] a in PlayerSkills.SKILLSETS)
                {
                    List<ExpressionValue> listB = new List<ExpressionValue>();
                    foreach (SpecialitySkillPair b in a)
                    {
                        listB.Add(ExpressionValue.CreateObject(new SpecialitySkillPairClass(b)));
                    }
                    listA.Add(ExpressionValue.Array(listB.ToArray()));
                }
                return ExpressionValue.Array(listA.ToArray());
            }
        }

        [ScriptProperty("SAVEDATA_VERSION")]
        public static byte SAVEDATA_VERSION => PlayerSkills.SAVEDATA_VERSION;

        [ScriptProperty("SPECIALITIES")]
        public static byte SPECIALITIES => PlayerSkills.SPECIALITIES;

        [ScriptProperty("BOOST_COUNT")]
        public static byte BOOST_COUNT => PlayerSkills.BOOST_COUNT;

        [ScriptProperty("BOOST_COST")]
        public static uint BOOST_COST => PlayerSkills.BOOST_COST;

        [ScriptProperty("skills")]
        public ExpressionValue Skills
        {
            get
            {
                List<ExpressionValue> listA = new List<ExpressionValue>();
                foreach (Skill[] a in playerSkills.skills)
                {
                    List<ExpressionValue> listB = new List<ExpressionValue>();
                    foreach (Skill b in a)
                    {
                        listB.Add(ExpressionValue.CreateObject(new SkillClass(b)));
                    }
                    listA.Add(ExpressionValue.Array(listB.ToArray()));
                }
                return ExpressionValue.Array(listA.ToArray());
            }
        }

        [ScriptProperty("doesLevelAllowSkills")]
        public bool DoesLevelAllowSkills => playerSkills.doesLevelAllowSkills;

        [ScriptProperty("reputation")]
        public int Reputation => playerSkills.reputation;

        [ScriptProperty("experience")]
        public uint Experience => playerSkills.experience;

        [ScriptProperty("boost")]
        public string Boost => playerSkills.boost.ToString();

        [ScriptFunction("TryParseIndices")]
        public ExpressionValue TryParseIndices(string input)
        {
            bool hasParsed = PlayerSkills.TryParseIndices(input, out int specialityIndex, out int skillIndex);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasParsed, specialityIndex, skillIndex };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("askAward")]
        public void AskAward(uint award)
        {
            playerSkills.askAward(award);
        }

        [ScriptFunction("askPay")]
        public void AskPay(uint pay)
        {
            playerSkills.askPay(pay);
        }

        [ScriptFunction("askRep")]
        public void AskRep(int rep)
        {
            playerSkills.askRep(rep);
        }

        [ScriptFunction("askSpend")]
        public void AskSpend(uint cost)
        {
            playerSkills.askSpend(cost);
        }

        [ScriptFunction("cost")]
        public uint Cost(int speciality, int index)
        {
            return playerSkills.cost(speciality, index);
        }

        [ScriptFunction("load")]
        public void Load()
        {
            playerSkills.load();
        }

        [ScriptFunction("mastery")]
        public float Mastery(int speciality, int index)
        {
            return playerSkills.mastery(speciality, index);
        }

        [ScriptFunction("modRep")]
        public void ModRep(int rep)
        {
            playerSkills.modRep(rep);
        }

        [ScriptFunction("modXp")]
        public void ModXp(uint xp)
        {
            playerSkills.modXp(xp);
        }

        [ScriptFunction("modXp2")]
        public void ModXp2(uint xp)
        {
            playerSkills.modXp2(xp);
        }

        [ScriptFunction("save")]
        public void Save()
        {
            playerSkills.save();
        }

        [ScriptFunction("sendBoost")]
        public void SendBoost()
        {
            playerSkills.sendBoost();
        }

        [ScriptFunction("sendUpgrade")]
        public void SendUpgrade(byte speciality, byte index, bool force)
        {
            playerSkills.sendUpgrade(speciality, index, force);
        }

        [ScriptFunction("ServerModifyExperience")]
        public void ServerModifyExperience(int delta)
        {
            playerSkills.ServerModifyExperience(delta);
        }

        [ScriptFunction("ServerSetExperience")]
        public void ServerSetExperience(uint newExperience)
        {
            playerSkills.ServerSetExperience(newExperience);
        }

        [ScriptFunction("ServerSetSkillLevel")]
        public bool ServerSetSkillLevel(int specialityIndex, int skillIndex, int newLevel)
        {
            return playerSkills.ServerSetSkillLevel(specialityIndex, skillIndex, newLevel);
        }

        [ScriptFunction("ServerUnlockAllSkills")]
        public void ServerUnlockAllSkills()
        {
            playerSkills.ServerUnlockAllSkills();
        }
    }
}