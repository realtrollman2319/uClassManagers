using SDG.Unturned;
using System;
using uClassManagers.Classes;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Managers
{
    [ScriptModule("uEffectManager")] // Name conflict with uScript2's EffectManager, expanding it will cause more trouble
    public class uEffectManagerClass
    {
        [ScriptFunction("askEffectClearAll")]
        public static void AskEffectClearAll()
        {
            EffectManager.askEffectClearAll();
        }

        [ScriptFunction("askEffectClearByID")]
        public static void AskEffectClearByID(ushort id, PlayerClass player)
        {
            EffectManager.askEffectClearByID(id, player.Player.channel.owner.transportConnection);
        }

        [ScriptFunction("clearEffectByGuid")]
        public static void ClearEffectByGuid(string guid, PlayerClass player)
        {
            EffectManager.ClearEffectByGuid(Guid.Parse(guid), player.Player.channel.owner.transportConnection);
        }

        [ScriptFunction("clearEffectByGuid_AllPlayers")]
        public static void ClearEffectByGuid_AllPlayers(string guid)
        {
            EffectManager.ClearEffectByGuid_AllPlayers(Guid.Parse(guid));
        }

        [ScriptFunction("clearEffectByID_AllPlayers")]
        public static void ClearEffectByID_AllPlayers(ushort id)
        {
            EffectManager.ClearEffectByID_AllPlayers(id);
        }

        [ScriptFunction("createAndFormatUIEffect")]
        public static TransformClass CreateAndFormatUIEffect(ushort id, short key, params ExpressionValue[] args)
        {
            Transform uEffect = EffectManager.createAndFormatUIEffect(id, key, (object[])args);
            return new TransformClass(uEffect);
        }

        [ScriptFunction("createUIEffect")]
        public static TransformClass CreateUIEffect(ushort id, short key)
        {
            Transform uEffect = EffectManager.createUIEffect(id, key);
            return new TransformClass(uEffect);
        }

        [ScriptFunction("effect")]
        public static TransformClass Effect(string guid, Vector3Class point, Vector3Class normal, Vector3Class scaleMultiplier)
        {
            Transform uEffect = EffectManager.effect(Guid.Parse(guid), point.Vector3, normal.Vector3, scaleMultiplier.Vector3);
            return new TransformClass(uEffect);
        }

        [ScriptFunction("effect")]
        public static TransformClass Effect(ushort id, Vector3Class point, Vector3Class normal, Vector3Class scaleMultiplier)
        {
            Transform uEffect = EffectManager.effect(id, point.Vector3, normal.Vector3, scaleMultiplier.Vector3);
            return new TransformClass(uEffect);
        }

        [ScriptFunction("effect")]
        public static TransformClass Effect(string guid, Vector3Class point, Vector3Class normal)
        {
            Transform uEffect = EffectManager.effect(Guid.Parse(guid), point.Vector3, normal.Vector3);
            return new TransformClass(uEffect);
        }

        [ScriptFunction("effect")]
        public static TransformClass Effect(ushort id, Vector3Class point, Vector3Class normal)
        {
            Transform uEffect = EffectManager.effect(id, point.Vector3, normal.Vector3);
            return new TransformClass(uEffect);
        }

        [ScriptFunction("formatPluginHotkeysIntoUIEffect")]
        public static void FormatPluginHotkeysIntoUIEffect(TransformClass effect)
        {
            EffectManager.formatPluginHotkeysIntoUIEffect(effect.transform);
        }

        [ScriptFunction("formatTextIntoUIEffect")]
        public static void FormatTextIntoUIEffect(TransformClass effect, params ExpressionValue[] args)
        {
            EffectManager.formatTextIntoUIEffect(effect.transform, (object[])args);
        }

        [ScriptFunction("gatherFormattingForUIEffect")]
        public static void GatherFormattingForUIEffect(TransformClass effect)
        {
            EffectManager.gatherFormattingForUIEffect(effect.transform);
        }

        [ScriptFunction("hookButtonsInUIEffect")]
        public static void HookButtonsInUIEffect(TransformClass effect)
        {
            EffectManager.hookButtonsInUIEffect(effect.transform);
        }

        [ScriptFunction("hookInputFieldsInUIEffect")]
        public static void HookInputFieldsInUIEffect(TransformClass effect)
        {
            EffectManager.hookInputFieldsInUIEffect(effect.transform);
        }

        [ScriptFunction("receiveEffectClearAll")]
        public static void ReceiveEffectClearAll()
        {
            EffectManager.ReceiveEffectClearAll();
        }

        [ScriptFunction("sendEffectClicked")]
        public static void SendEffectClicked(string buttonName)
        {
            EffectManager.sendEffectClicked(buttonName);
        }

        [ScriptFunction("sendEffectTextCommitted")]
        public static void SendEffectTextCommitted(string inputFieldName, string text)
        {
            EffectManager.sendEffectTextCommitted(inputFieldName, text);
        }

        [ScriptFunction("sendUIEffect")]
        public static void SendUIEffect(ushort id, short key, PlayerClass player, string arg0, bool reliable = true)
        {
            EffectManager.sendUIEffect(id, key, player.Player.channel.owner.transportConnection, reliable, arg0);
        }

        [ScriptFunction("sendUIEffect")]
        public static void SendUIEffect(ushort id, short key, PlayerClass player, string arg0, string arg1, bool reliable = true)
        {
            EffectManager.sendUIEffect(id, key, player.Player.channel.owner.transportConnection, reliable, arg0, arg1);
        }

        [ScriptFunction("sendUIEffect")]
        public static void SendUIEffect(ushort id, short key, PlayerClass player, string arg0, string arg1, string arg2, bool reliable = true)
        {
            EffectManager.sendUIEffect(id, key, player.Player.channel.owner.transportConnection, reliable, arg0, arg1, arg2);
        }

        [ScriptFunction("sendUIEffect")]
        public static void SendUIEffect(ushort id, short key, PlayerClass player, string arg0, string arg1, string arg2, string arg3, bool reliable = true)
        {
            EffectManager.sendUIEffect(id, key, player.Player.channel.owner.transportConnection, reliable, arg0, arg1, arg2, arg3);
        }

        [ScriptFunction("sendUIEffectImageURL")]
        public static void SendUIEffectImageURL(PlayerClass player, short key, string childName, string url, bool reliable = true, bool shouldCache = true, bool forceRefresh = false)
        {
            EffectManager.sendUIEffectImageURL(key, player.Player.channel.owner.transportConnection, reliable, childName, url, shouldCache, forceRefresh);
        }

        [ScriptFunction("sendUIEffectText")]
        public static void SendUIEffectText(PlayerClass player, short key, string childName, string text, bool reliable = true)
        {
            EffectManager.sendUIEffectText(key, player.Player.channel.owner.transportConnection, reliable, childName, text);
        }

        [ScriptFunction("sendUIEffectVisibility")]
        public static void SendUIEffectVisibility(PlayerClass player, short key, string childName, bool isVisible, bool reliable = true)
        {
            EffectManager.sendUIEffectVisibility(key, player.Player.channel.owner.transportConnection, reliable, childName, isVisible);
        }

        [ScriptFunction("triggerEffect")]
        public static void TriggerEffect(ushort id, Vector3Class position, float relevantDistance = 128, bool wasInstigatedByPlayer = false) // If you need to change the effect parameters, then use TriggerEffectParametersClass. This exists for quick effect spawning.
        {
            #pragma warning disable CS0618
            TriggerEffectParameters triggerEffectParameters = new TriggerEffectParameters(id)
            {
                position = position.Vector3,
                scale = Vector3.one,
                shouldReplicate = true,
                reliable = true,
                wasInstigatedByPlayer = wasInstigatedByPlayer,
                relevantDistance = relevantDistance
            };

            EffectManager.triggerEffect(triggerEffectParameters);
        }

        [ScriptFunction("triggerEffect")]
        public static void TriggerEffect(TriggerEffectParametersClass triggerEffectParameters)
        {
            EffectManager.triggerEffect(triggerEffectParameters.triggerEffectParameters);
        }
    }
}