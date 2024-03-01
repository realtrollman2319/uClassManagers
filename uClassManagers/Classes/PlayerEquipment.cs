using SDG.Provider;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerEquipment")]
    public class PlayerEquipmentClass
    {
        public PlayerEquipment playerEquipment { get; private set; }
        public PlayerEquipmentClass(PlayerEquipment c_PlayerEquipment) => playerEquipment = c_PlayerEquipment;

        [ScriptProperty("SAVEDATA_VERSION")]
        public static byte SAVEDATA_VERSION => PlayerEquipment.SAVEDATA_VERSION;

        [ScriptProperty("wasTryingToSelect")]
        public bool WasTryingToSelect => playerEquipment.wasTryingToSelect;

        [ScriptProperty("isBusy")]
        public bool IsBusy => playerEquipment.isBusy;

        [ScriptProperty("canEquip")]
        public bool CanEquip => playerEquipment.canEquip;

        [ScriptProperty("characterSecondaryMeleeSlot")]
        public TransformClass CharacterSecondaryMeleeSlot => new TransformClass(playerEquipment.characterSecondaryMeleeSlot);

        [ScriptProperty("characterPrimarySmallGunSlot")]
        public TransformClass CharacterPrimarySmallGunSlot => new TransformClass(playerEquipment.characterPrimarySmallGunSlot);

        [ScriptProperty("characterPrimaryLargeGunSlot")]
        public TransformClass CharacterPrimaryLargeGunSlot => new TransformClass(playerEquipment.characterPrimaryLargeGunSlot);

        [ScriptProperty("characterPrimaryMeleeSlot")]
        public TransformClass CharacterPrimaryMeleeSlot => new TransformClass(playerEquipment.characterPrimaryMeleeSlot);

        [ScriptProperty("thirdSecondaryGunSlot")]
        public TransformClass ThirdSecondaryGunSlot => new TransformClass(playerEquipment.thirdSecondaryGunSlot);

        [ScriptProperty("thirdSecondaryMeleeSlot")]
        public TransformClass ThirdSecondaryMeleeSlot => new TransformClass(playerEquipment.thirdSecondaryMeleeSlot);

        [ScriptProperty("thirdPrimarySmallGunSlot")]
        public TransformClass ThirdPrimarySmallGunSlot => new TransformClass(playerEquipment.thirdPrimarySmallGunSlot);

        [ScriptProperty("characterSecondaryGunSlot")]
        public TransformClass CharacterSecondaryGunSlot => new TransformClass(playerEquipment.characterSecondaryGunSlot);

        [ScriptProperty("thirdPrimaryLargeGunSlot")]
        public TransformClass ThirdPrimaryLargeGunSlot => new TransformClass(playerEquipment.thirdPrimaryLargeGunSlot);

        [ScriptProperty("useable")]
        public UseableClass Useable => new UseableClass(playerEquipment.useable);

        [ScriptProperty("asset")]
        public ItemAssetClass Asset => new ItemAssetClass(playerEquipment.asset);

        [ScriptProperty("characterModel")]
        public TransformClass CharacterModel => new TransformClass(playerEquipment.characterModel);

        [ScriptProperty("thirdModel")]
        public TransformClass ThirdModel => new TransformClass(playerEquipment.thirdModel);

        [ScriptProperty("firstModel")]
        public TransformClass FirstModel => new TransformClass(playerEquipment.firstModel);

        [ScriptProperty("quality")]
        public byte Quality => playerEquipment.quality;

        [ScriptProperty("state")]
        public ExpressionValue State => ByteTool.FromArray(playerEquipment.state);

        [ScriptProperty("thirdPrimaryMeleeSlot")]
        public TransformClass ThirdPrimaryMeleeSlot => new TransformClass(playerEquipment.thirdPrimaryMeleeSlot);

        [ScriptProperty("firstLeftHook")]
        public TransformClass FirstLeftHook => new TransformClass(playerEquipment.firstLeftHook);

        [ScriptProperty("thirdLeftHook")]
        public TransformClass ThirdLeftHook => new TransformClass(playerEquipment.thirdLeftHook);

        [ScriptProperty("canInspect")]
        public bool CanInspect => playerEquipment.canInspect;

        [ScriptProperty("isInspecting")]
        public bool IsInspecting => playerEquipment.isInspecting;

        [ScriptProperty("lastPunching")]
        public float LastPunching => playerEquipment.lastPunching;

        [ScriptProperty("equipped_y")]
        public byte Equipped_y => playerEquipment.equipped_y;

        [ScriptProperty("equipped_x")]
        public byte Equipped_x => playerEquipment.equipped_x;

        [ScriptProperty("firstRightHook")]
        public TransformClass FirstRightHook => new TransformClass(playerEquipment.firstRightHook);

        [ScriptProperty("equippedPage")]
        public byte EquippedPage => playerEquipment.equippedPage;

        [ScriptProperty("isTurret")]
        public bool IsTurret => playerEquipment.isTurret;

        [ScriptProperty("IsEquipAnimationFinished")]
        public bool IsEquipAnimationFinished => playerEquipment.IsEquipAnimationFinished;

        [ScriptProperty("itemID")]
        public ushort ItemID => playerEquipment.itemID;

        [ScriptProperty("hotkeys")]
        public ExpressionValue Hotkeys
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (HotkeyInfo hotkeyInfo in playerEquipment.hotkeys)
                {
                    list.Add(ExpressionValue.CreateObject(new HotkeyInfoClass(hotkeyInfo)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptProperty("characterRightHook")]
        public TransformClass CharacterRightHook => new TransformClass(playerEquipment.characterRightHook);

        [ScriptProperty("characterLeftHook")]
        public TransformClass CharacterLeftHook => new TransformClass(playerEquipment.characterLeftHook);

        [ScriptProperty("thirdRightHook")]
        public TransformClass ThirdRightHook => new TransformClass(playerEquipment.thirdRightHook);

        [ScriptProperty("isUseableShowingMenu")]
        public bool IsUseableShowingMenu => playerEquipment.isUseableShowingMenu;

        [ScriptProperty("HasValidUseable")]
        public bool HasValidUseable => playerEquipment.HasValidUseable;

        [ScriptFunction("applyMythicVisual")]
        public void ApplyMythicVisual()
        {
            playerEquipment.applyMythicVisual();
        }

        [ScriptFunction("applySkinVisual")]
        public void ApplySkinVisual()
        {
            playerEquipment.applySkinVisual();
        }

        [ScriptFunction("checkSelection")]
        public bool CheckSelection(byte page, byte x, byte y)
        {
            return playerEquipment.checkSelection(page, x, y);
        }

        [ScriptFunction("checkSelection")]
        public bool CheckSelection(byte page)
        {
            return playerEquipment.checkSelection(page);
        }

        [ScriptFunction("dequip")]
        public void Dequip()
        {
            playerEquipment.dequip();
        }

        [ScriptFunction("equip")]
        public void Equip(byte page, byte x, byte y)
        {
            playerEquipment.equip(page, x, y);
        }

        [ScriptFunction("getUseableRagdollEffect")]
        public string GetUseableRagdollEffect()
        {
            return playerEquipment.getUseableRagdollEffect().ToString();
        }

        [ScriptFunction("getUseableStatTrackerValue")]
        public ExpressionValue GetUseableStatTrackerValue()
        {
            playerEquipment.getUseableStatTrackerValue(out EStatTrackerType type, out int kills);
            List<ExpressionValue> list = new List<ExpressionValue>() { type.ToString(), kills };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("inspect")]
        public void Inspect()
        {
            playerEquipment.inspect();
        }

        [ScriptFunction("isItemHotkeyed")]
        public bool IsItemHotkeyed(byte page, byte index, ItemJarClass jar)
        {
            bool isHotkeyed = playerEquipment.isItemHotkeyed(page, index, jar.itemJar, out byte button);
            List<ExpressionValue> list = new List<ExpressionValue>() { isHotkeyed.ToString(), button };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("sendSlot")]
        public void SendSlot(byte slot)
        {
            playerEquipment.sendSlot(slot);
        }

        [ScriptFunction("sendUpdateQuality")]
        public void SendUpdateQuality()
        {
            playerEquipment.sendUpdateQuality();
        }

        [ScriptFunction("sendUpdateState")]
        public void SendUpdateState()
        {
            playerEquipment.sendUpdateState();
        }

        [ScriptFunction("ServerBindItemHotkey")]
        public void ServerBindItemHotkey(byte hotkeyIndex, ItemAssetClass expectedItem, byte page, byte x, byte y)
        {
            playerEquipment.ServerBindItemHotkey(hotkeyIndex, expectedItem.itemAsset, page, x, y);
        }

        [ScriptFunction("ServerBindItemHotkey")]
        public void ServerBindItemHotkey(byte hotkeyIndex, string expectedItemGuid, byte page, byte x, byte y)
        {
            playerEquipment.ServerBindItemHotkey(hotkeyIndex, SDG.Unturned.Assets.find<ItemAsset>(Guid.Parse(expectedItemGuid)), page, x, y);
        }

        [ScriptFunction("ServerBindItemHotkey")]
        public void ServerBindItemHotkey(byte hotkeyIndex, ushort id, byte page, byte x, byte y)
        {
            playerEquipment.ServerBindItemHotkey(hotkeyIndex, (ItemAsset)SDG.Unturned.Assets.find(EAssetType.ITEM, id), page, x, y);
        }


        [ScriptFunction("ServerClearItemHotkey")]
        public void ServerClearItemHotkey(byte hotkeyIndex)
        {
            playerEquipment.ServerClearItemHotkey(hotkeyIndex);
        }

        [ScriptFunction("ServerEquip")]
        public void ServerEquip(byte page, byte x, byte y)
        {
            playerEquipment.ServerEquip(page, x, y);
        }

        [ScriptFunction("simulate")]
        public void Simulate(uint simulation, string inputPrimary, string inputSecondary, bool inputSteady)
        {
            EAttackInputFlags? attackFlagPrimary = EnumTool.attackInputFlags.GetEnum(inputPrimary);
            if (attackFlagPrimary == null) return;
            EAttackInputFlags? attackFlagSecondary = EnumTool.attackInputFlags.GetEnum(inputSecondary);
            if (attackFlagSecondary == null) return;

            playerEquipment.simulate(simulation, attackFlagPrimary.Value, attackFlagSecondary.Value, inputSteady);
        }

        [ScriptFunction("tock")]
        public void Tock(uint clock)
        {
            playerEquipment.tock(clock);
        }

        [ScriptFunction("turretDequipClient")]
        public void TurretDequipClient()
        {
            playerEquipment.turretDequipClient();
        }

        [ScriptFunction("turretDequipServer")]
        public void TurretDequipServer()
        {
            playerEquipment.turretDequipServer();
        }

        [ScriptFunction("turretEquipClient")]
        public void TurretEquipClient()
        {
            playerEquipment.turretEquipClient();
        }

        [ScriptFunction("turretEquipServer")]
        public void TurretEquipServer(ushort id, ExpressionValue state)
        {
            playerEquipment.turretEquipServer(id, ByteTool.FromExpressionValue(state));
        }

        [ScriptFunction("uninspect")]
        public void Uninspect()
        {
            playerEquipment.uninspect();
        }

        [ScriptFunction("updateQuality")]
        public void UpdateQuality()
        {
            playerEquipment.updateQuality();
        }

        [ScriptFunction("updateState")]
        public void UpdateState()
        {
            playerEquipment.updateState();
        }

        [ScriptFunction("use")]
        public void Use()
        {
            playerEquipment.use();
        }

        [ScriptFunction("useStepA")]
        public void UseStepA()
        {
            playerEquipment.useStepA();
        }

        [ScriptFunction("useStepB")]
        public void UseStepB()
        {
            playerEquipment.useStepB();
        }
    }
}
