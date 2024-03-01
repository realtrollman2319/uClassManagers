using SDG.Unturned;
using System.Linq;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("uBarricade")]
    public class uBarricadeClass
    {
        public Barricade barricade { get; private set; }
        public uBarricadeClass(Barricade c_Barricade) => barricade = c_Barricade;

        [ScriptProperty("state")]
        public ExpressionValue State => ExpressionValue.Array(barricade.state.Select(b => (ExpressionValue)b));

        [ScriptProperty("isDead")]
        public bool IsDead => barricade.isDead;

        [ScriptProperty("isRepaired")]
        public bool IsRepaired => barricade.isRepaired;

        [ScriptProperty("asset")]
        public ItemBarricadeAssetClass Asset => new ItemBarricadeAssetClass(barricade.asset);
    }
}