using SDG.Unturned;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerClothing")]
    public class PlayerClothingClass
    {
        public PlayerClothing playerClothing { get; private set; }
        public PlayerClothingClass(PlayerClothing c_PlayerClothing) => playerClothing = c_PlayerClothing;

        [ScriptProperty("SAVEDATA_VERSION")]
        public static byte SAVEDATA_VERSION => PlayerClothing.SAVEDATA_VERSION;

        [ScriptProperty("glassesState")]
        public ExpressionValue GlassesState => ByteTool.FromArray(playerClothing.glassesState);

        [ScriptProperty("vestState")]
        public ExpressionValue VestState => ByteTool.FromArray(playerClothing.vestState);

        [ScriptProperty("backpackState")]
        public ExpressionValue BackpackState => ByteTool.FromArray(playerClothing.backpackState);

        [ScriptProperty("hatState")]
        public ExpressionValue HatState => ByteTool.FromArray(playerClothing.hatState);

        [ScriptProperty("pantsState")]
        public ExpressionValue PantsState => ByteTool.FromArray(playerClothing.pantsState);

        [ScriptProperty("shirtState")]
        public ExpressionValue ShirtState => ByteTool.FromArray(playerClothing.shirtState);

        [ScriptProperty("glassesQuality")]
        public byte GlassesQuality => playerClothing.glassesQuality;

        [ScriptProperty("maskQuality")]
        public byte MaskQuality => playerClothing.maskQuality;

        [ScriptProperty("vestQuality")]
        public byte VestQuality => playerClothing.vestQuality;

        [ScriptProperty("backpackQuality")]
        public byte BackpackQuality => playerClothing.backpackQuality;

        [ScriptProperty("maskState")]
        public ExpressionValue MaskState => ByteTool.FromArray(playerClothing.maskState);

        [ScriptProperty("pantsQuality")]
        public byte PantsQuality => playerClothing.pantsQuality;

        [ScriptProperty("hatQuality")]
        public byte HatQuality => playerClothing.hatQuality;

        [ScriptProperty("shirtQuality")]
        public byte ShirtQuality => playerClothing.shirtQuality;

        [ScriptProperty("visualHat")]
        public int VisualHat => playerClothing.visualHat;

        [ScriptProperty("visualPants")]
        public int VisualPants => playerClothing.visualPants;

        [ScriptProperty("visualShirt")]
        public int VisualShirt => playerClothing.visualShirt;

        [ScriptProperty("isSkinned")]
        public bool IsSkinned => playerClothing.isSkinned;

        [ScriptProperty("isMythic")]
        public bool IsMythic => playerClothing.isMythic;

        [ScriptProperty("isVisual")]
        public bool IsVisual => playerClothing.isVisual;

        [ScriptProperty("visualBackpack")]
        public int VisualBackpack => playerClothing.visualBackpack;

        [ScriptProperty("visualVest")]
        public int VisualVest => playerClothing.visualVest;

        [ScriptProperty("hair")]
        public byte Hair => playerClothing.hair;

        [ScriptProperty("visualGlasses")]
        public int VisualGlasses => playerClothing.visualGlasses;

        [ScriptProperty("color")]
        public string Color => ColorUtility.ToHtmlStringRGB(playerClothing.color);

        [ScriptProperty("skin")]
        public string Skin => ColorUtility.ToHtmlStringRGB(playerClothing.skin);

        [ScriptProperty("visualMask")]
        public int VisualMask => playerClothing.visualMask;

        [ScriptProperty("face")]
        public byte Face => playerClothing.face;

        [ScriptProperty("glasses")]
        public ushort Glasses => playerClothing.glasses;

        [ScriptProperty("beard")]
        public byte Beard => playerClothing.beard;

        [ScriptProperty("vest")]
        public ushort Vest => playerClothing.vest;

        [ScriptProperty("backpack")]
        public ushort Backpack => playerClothing.backpack;

        [ScriptProperty("hat")]
        public ushort Hat => playerClothing.hat;

        [ScriptProperty("pants")]
        public ushort Pants => playerClothing.pants;

        [ScriptProperty("shirt")]
        public ushort Shirt => playerClothing.shirt;

        [ScriptProperty("mask")]
        public ushort Mask => playerClothing.mask;

        [ScriptFunction("askWearBackpack")]
        public void AskWearBackpack(ushort id, byte quality, ExpressionValue state, bool playEffect)
        {
            playerClothing.askWearBackpack(id, quality, ByteTool.FromExpressionValue(state), playEffect);
        }

        [ScriptFunction("askWearGlasses")]
        public void AskWearGlasses(ushort id, byte quality, ExpressionValue state, bool playEffect)
        {
            playerClothing.askWearGlasses(id, quality, ByteTool.FromExpressionValue(state), playEffect);
        }

        [ScriptFunction("askWearHat")]
        public void AskWearHat(ushort id, byte quality, ExpressionValue state, bool playEffect)
        {
            playerClothing.askWearHat(id, quality, ByteTool.FromExpressionValue(state), playEffect);
        }

        [ScriptFunction("askWearMask")]
        public void AskWearMask(ushort id, byte quality, ExpressionValue state, bool playEffect)
        {
            playerClothing.askWearMask(id, quality, ByteTool.FromExpressionValue(state), playEffect);
        }

        [ScriptFunction("askWearPants")]
        public void AskWearPants(ushort id, byte quality, ExpressionValue state, bool playEffect)
        {
            playerClothing.askWearPants(id, quality, ByteTool.FromExpressionValue(state), playEffect);
        }

        [ScriptFunction("askWearShirt")]
        public void AskWearShirt(ushort id, byte quality, ExpressionValue state, bool playEffect)
        {
            playerClothing.askWearShirt(id, quality, ByteTool.FromExpressionValue(state), playEffect);
        }

        [ScriptFunction("askWearVest")]
        public void AskWearVest(ushort id, byte quality, ExpressionValue state, bool playEffect)
        {
            playerClothing.askWearVest(id, quality, ByteTool.FromExpressionValue(state), playEffect);
        }

        [ScriptFunction("load")]
        public void Load()
        {
            playerClothing.load();
        }

        [ScriptFunction("save")]
        public void Save()
        {
            playerClothing.save();
        }

        [ScriptFunction("sendSwapBackpack")]
        public void SendSwapBackpack(byte page, byte x, byte y)
        {
            playerClothing.sendSwapBackpack(page, x, y);
        }

        [ScriptFunction("sendSwapFace")]
        public void SendSwapFace(byte index)
        {
            playerClothing.sendSwapFace(index);
        }

        [ScriptFunction("sendSwapGlasses")]
        public void SendSwapGlasses(byte page, byte x, byte y)
        {
            playerClothing.sendSwapGlasses(page, x, y);
        }

        [ScriptFunction("sendSwapHat")]
        public void SendSwapHat(byte page, byte x, byte y)
        {
            playerClothing.sendSwapHat(page, x, y);
        }

        [ScriptFunction("sendSwapMask")]
        public void SendSwapMask(byte page, byte x, byte y)
        {
            playerClothing.sendSwapMask(page, x, y);
        }

        [ScriptFunction("sendSwapPants")]
        public void SendSwapPants(byte page, byte x, byte y)
        {
            playerClothing.sendSwapPants(page, x, y);
        }

        [ScriptFunction("sendSwapShirt")]
        public void SendSwapShirt(byte page, byte x, byte y)
        {
            playerClothing.sendSwapShirt(page, x, y);
        }

        [ScriptFunction("sendSwapVest")]
        public void SendSwapVest(byte page, byte x, byte y)
        {
            playerClothing.sendSwapVest(page, x, y);
        }

        [ScriptFunction("sendUpdateBackpackQuality")]
        public void SendUpdateBackpackQuality()
        {
            playerClothing.sendUpdateBackpackQuality();
        }

        [ScriptFunction("sendUpdateGlassesQuality")]
        public void SendUpdateGlassesQuality()
        {
            playerClothing.sendUpdateGlassesQuality();
        }

        [ScriptFunction("sendUpdateHatQuality")]
        public void SendUpdateHatQuality()
        {
            playerClothing.sendUpdateHatQuality();
        }

        [ScriptFunction("sendUpdateMaskQuality")]
        public void SendUpdateMaskQuality()
        {
            playerClothing.sendUpdateMaskQuality();
        }

        [ScriptFunction("sendUpdatePantsQuality")]
        public void SendUpdatePantsQuality()
        {
            playerClothing.sendUpdatePantsQuality();
        }

        [ScriptFunction("sendUpdateShirtQuality")]
        public void SendUpdateShirtQuality()
        {
            playerClothing.sendUpdateShirtQuality();
        }

        [ScriptFunction("sendUpdateVestQuality")]
        public void SendUpdateVestQuality()
        {
            playerClothing.sendUpdateVestQuality();
        }

        [ScriptFunction("sendVisualToggle")]
        public void SendVisualToggle(string type)
        {
            EVisualToggleType? visualToggleType = EnumTool.visualToggleTypes.GetEnum(type);
            if (visualToggleType == null) return;
            playerClothing.sendVisualToggle(visualToggleType.Value);
        }

        [ScriptFunction("ServerSetFace")]
        public bool ServerSetFace(byte index)
        {
            return playerClothing.ServerSetFace(index);
        }

        [ScriptFunction("ServerSetVisualToggleState")]
        public void ServerSetVisualToggleState(string type, bool isVisible)
        {
            EVisualToggleType? visualToggleType = EnumTool.visualToggleTypes.GetEnum(type);
            if (visualToggleType == null) return;
            playerClothing.ServerSetVisualToggleState(visualToggleType.Value, isVisible);
        }

        [ScriptFunction("updateClothes")]
        public void UpdateClothes(ushort newShirt, byte newShirtQuality, ExpressionValue newShirtState, ushort newPants, byte newPantsQuality, ExpressionValue newPantsState, ushort newHat, byte newHatQuality, ExpressionValue newHatState, ushort newBackpack, byte newBackpackQuality, ExpressionValue newBackpackState, ushort newVest, byte newVestQuality, ExpressionValue newVestState, ushort newMask, byte newMaskQuality, ExpressionValue newMaskState, ushort newGlasses, byte newGlassesQuality, ExpressionValue newGlassesState)
        {
            playerClothing.updateClothes(
                newShirt, newShirtQuality,
                ByteTool.FromExpressionValue(newShirtState),
                newPants, newPantsQuality,
                ByteTool.FromExpressionValue(newPantsState),
                newHat, newHatQuality,
                ByteTool.FromExpressionValue(newHatState),
                newBackpack, newBackpackQuality,
                ByteTool.FromExpressionValue(newBackpackState),
                newVest, newVestQuality,
                ByteTool.FromExpressionValue(newVestState),
                newMask, newMaskQuality,
                ByteTool.FromExpressionValue(newMaskState),
                newGlasses, newGlassesQuality,
                ByteTool.FromExpressionValue(newGlassesState)
            );
        }

        [ScriptFunction("updateMaskQuality")]
        public void UpdateMaskQuality()
        {
            playerClothing.updateMaskQuality();
        }
    }
}
