using SDG.Unturned;
using uClassManagers.uClasses;
using uScript.API.Attributes;

namespace uClassManagers
{
    [ScriptClass("uStructure")]
    public class uStructureClass
    {
        public Structure structure { get; private set; }
        public uStructureClass(Structure c_structure) => structure = c_structure;

        [ScriptProperty("isDead")]
        public bool IsDead
        {
            get => structure.isDead;
        }

        [ScriptProperty("isRepaired")]
        public bool IsRepaired
        {
            get => structure.isRepaired;
        }

        [ScriptProperty("asset")]
        public ItemStructureAssetClass Asset
        {
            get => new ItemStructureAssetClass(structure.asset);
        }
    }
}
