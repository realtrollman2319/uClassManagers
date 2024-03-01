using SDG.Unturned;
using Steamworks;
using System.Collections.Generic;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("InteractableStorage")]
    public class InteractableStorageClass
    {
        public InteractableStorage interactableStorage { get; private set; }
        public InteractableStorageClass(InteractableStorage c_InteractableStorage) => interactableStorage = c_InteractableStorage;

        [ScriptProperty("rot_z")]
        public byte Rot_z => interactableStorage.rot_z;

        [ScriptProperty("displayItem")]
        public uItemClass DisplayItem => new uItemClass(interactableStorage.displayItem);

        [ScriptProperty("displaySkin")]
        public ushort DisplaySkin => interactableStorage.displaySkin;

        [ScriptProperty("displayMythic")]
        public ushort DisplayMythic => interactableStorage.displayMythic;

        [ScriptProperty("displayTags")]
        public string DisplayTags => interactableStorage.displayTags;

        [ScriptProperty("displayDynamicProps")]
        public string DisplayDynamicProps => interactableStorage.displayDynamicProps;

        [ScriptProperty("rot_comp")]
        public byte Rot_comp => interactableStorage.rot_comp;

        [ScriptProperty("rot_x")]
        public byte Rot_x => interactableStorage.rot_x;

        [ScriptProperty("rot_y")]
        public byte Rot_y => interactableStorage.rot_y;

        [ScriptProperty("shouldCloseWhenOutsideRange")]
        public bool ShouldCloseWhenOutsideRange => interactableStorage.shouldCloseWhenOutsideRange;

        [ScriptProperty("isOpen")]
        public bool IsOpen => interactableStorage.isOpen;

        [ScriptProperty("opener")]
        public PlayerClass Opener => new PlayerClass(interactableStorage.opener);

        [ScriptProperty("despawnWhenDestroyed")]
        public bool DespawnWhenDestroyed => interactableStorage.despawnWhenDestroyed;

        [ScriptProperty("items")]
        public ItemsClass Items => new ItemsClass(interactableStorage.items);

        [ScriptProperty("group")]
        public string Group => interactableStorage.group.m_SteamID.ToString();

        [ScriptProperty("owner")]
        public string Owner => interactableStorage.owner.m_SteamID.ToString();

        [ScriptProperty("isDisplay")]
        public bool IsDisplay => interactableStorage.isDisplay;

        [ScriptFunction("applyRotation")]
        public void ApplyRotation(byte rotComp)
        {
            interactableStorage.applyRotation(rotComp);
        }

        [ScriptFunction("checkHint")]
        public ExpressionValue CheckHint()
        {
            bool hasHint = interactableStorage.checkHint(out EPlayerMessage message, out string text, out Color color);
            List<ExpressionValue> list = new List<ExpressionValue>() { hasHint, message.ToString(), text, ColorUtility.ToHtmlStringRGB(color) };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("checkRot")]
        public bool CheckRot(string enemyPlayer, string enemyGroup)
        {
            return interactableStorage.checkRot(new CSteamID(ulong.Parse(enemyPlayer)), new CSteamID(ulong.Parse(enemyGroup)));
        }

        [ScriptFunction("checkStore")]
        public bool CheckStore(string enemyPlayer, string enemyGroup)
        {
            return interactableStorage.checkStore(new CSteamID(ulong.Parse(enemyPlayer)), new CSteamID(ulong.Parse(enemyGroup)));
        }

        [ScriptFunction("checkUseable")]
        public bool CheckUseable()
        {
            return interactableStorage.checkUseable();
        }

        [ScriptFunction("ClientInteract")]
        public void ClientInteract(bool quickGrab)
        {
            interactableStorage.ClientInteract(quickGrab);
        }

        [ScriptFunction("ClientSetDisplayRotation")]
        public void ClientSetDisplayRotation(byte rotComp)
        {
            interactableStorage.ClientSetDisplayRotation(rotComp);
        }

        [ScriptFunction("getRotation")]
        public byte GetRotation(byte rot_x, byte rot_y, byte rot_z)
        {
            return interactableStorage.getRotation(rot_x, rot_y, rot_z);
        }

        [ScriptFunction("ManualOnDestroy")]
        public void ManualOnDestroy()
        {
            interactableStorage.ManualOnDestroy();
        }

        [ScriptFunction("rebuildState")]
        public void RebuildState()
        {
            interactableStorage.rebuildState();
        }

        [ScriptFunction("refreshDisplay")]
        public void RefreshDisplay()
        {
            interactableStorage.refreshDisplay();
        }

        [ScriptFunction("setDisplay")]
        public void SetDisplay(ushort id, byte quality, ExpressionValue state, ushort skin, ushort mythic, string tags, string dynamicProps)
        {
            interactableStorage.setDisplay(id, quality, ByteTool.FromExpressionValue(state), skin, mythic, tags, dynamicProps);
        }

        [ScriptFunction("setRotation")]
        public void SetRotation(byte rotComp)
        {
            interactableStorage.setRotation(rotComp);
        }

        [ScriptFunction("use")]
        public void Use()
        {
            interactableStorage.use();
        }
    }
}