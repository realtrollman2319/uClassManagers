using SDG.Unturned;
using System.Linq;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.uClasses
{
    [ScriptClass("uBarricade")]
    public class uBarricadeClass
    {
        public Barricade barricade { get; private set; }
        public uBarricadeClass(Barricade c_barricade) => barricade = c_barricade;

        [ScriptProperty("state")]
        public ExpressionValue State
        {
            get => ExpressionValue.Array(barricade.state.Select(b => (ExpressionValue)b));
        }

        [ScriptProperty("isDead")]
        public bool IsDead
        {
            get => barricade.isDead;
        }

        [ScriptProperty("isRepaired")]
        public bool IsRepaired
        {
            get => barricade.isRepaired;
        }

        [ScriptProperty("asset")]
        public ItemBarricadeAssetClass Asset
        {
            get => new ItemBarricadeAssetClass(barricade.asset);
        }
    }
}
