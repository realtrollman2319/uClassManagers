using SDG.Unturned;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("uStructure")]
    public class uStructureClass
    {
        public Structure structure { get; private set; }
        public uStructureClass(Structure c_Structure) => structure = c_Structure;

        [ScriptProperty("isDead")]
        public bool IsDead => structure.isDead;

        [ScriptProperty("isRepaired")]
        public bool IsRepaired => structure.isRepaired;

        [ScriptProperty("asset")]
        public ItemStructureAssetClass Asset => new ItemStructureAssetClass(structure.asset);
    }
}