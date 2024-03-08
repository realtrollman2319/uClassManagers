using SDG.Unturned;
using uClassManagers.Classes.Assets;
using UnityEngine;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("BarricadeDrop")]
    public class BarricadeDropClass
    {
        public BarricadeDrop barricadeDrop { get; private set; }
        public BarricadeDropClass(BarricadeDrop c_BarricadeDrop) => barricadeDrop = c_BarricadeDrop;

        [ScriptProperty("model")]
        public TransformClass Model => new TransformClass(barricadeDrop.model);

        [ScriptProperty("interactable")]
        public InteractableClass Interactable => new InteractableClass(barricadeDrop.interactable);

        [ScriptProperty("instanceID")]
        public uint InstanceID => barricadeDrop.instanceID;

        [ScriptProperty("asset")]
        public ItemBarricadeAssetClass Asset => new ItemBarricadeAssetClass(barricadeDrop.asset);
    }
}