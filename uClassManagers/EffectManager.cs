using SDG.Unturned;
using System;
using uClassManagers.uClasses;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers
{
    [ScriptModule("EffectManagerV2")] // Name conflict with uScript2's EffectManager, and uEffectManager (by Hath)
    public class EffectManagerClassV2
    {
        [ScriptFunction("askEffectClearAll")]
        public static void AskEffectClearAll()
        {
            EffectManager.askEffectClearAll();
        }

        [ScriptFunction("askEffectClearByID")]
        public static void AskEffectClearByID(ushort id, PlayerClass player)
        {
            EffectManager.askEffectClearByID(id, player.Player.channel.GetOwnerTransportConnection());
        }

        [ScriptFunction("clearEffectByGuid")]
        public static void ClearEffectByGuid(string guid, PlayerClass player)
        {
            EffectManager.ClearEffectByGuid(Guid.Parse(guid), player.Player.channel.GetOwnerTransportConnection());
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
            EffectManager.formatPluginHotkeysIntoUIEffect(effect.Transform);
        }

        [ScriptFunction("formatTextIntoUIEffect")]
        public static void FormatTextIntoUIEffect(TransformClass effect, params ExpressionValue[] args)
        {
            EffectManager.formatTextIntoUIEffect(effect.Transform, (object[])args);
        }

        [ScriptFunction("gatherFormattingForUIEffect")]
        public static void GatherFormattingForUIEffect(TransformClass effect)
        {
            EffectManager.gatherFormattingForUIEffect(effect.Transform);
        }

        [ScriptFunction("hookButtonsInUIEffect")]
        public static void HookButtonsInUIEffect(TransformClass effect)
        {
            EffectManager.hookButtonsInUIEffect(effect.Transform);
        }

        [ScriptFunction("hookInputFieldsInUIEffect")]
        public static void HookInputFieldsInUIEffect(TransformClass effect)
        {
            EffectManager.hookInputFieldsInUIEffect(effect.Transform);
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
        public static void SendUIEffect(ushort id, short key, PlayerClass player, string arg0, string arg1 = "", string arg2 = "", string arg3 = "", bool reliable = true)
        {
            EffectManager.sendUIEffect(id, key, player.Player.channel.GetOwnerTransportConnection(), reliable, arg0, arg1, arg2, arg3);
        }

        [ScriptFunction("sendUIEffectImageURL")]
        public static void SendUIEffectImageURL(PlayerClass player, short key, string childName, string url, bool reliable = true, bool shouldCache = true, bool forceRefresh = false)
        {
            EffectManager.sendUIEffectImageURL(key, player.Player.channel.GetOwnerTransportConnection(), reliable, childName, url, shouldCache, forceRefresh);
        }

        [ScriptFunction("sendUIEffectText")]
        public static void SendUIEffectText(PlayerClass player, short key, string childName, string text, bool reliable = true)
        {
            EffectManager.sendUIEffectText(key, player.Player.channel.GetOwnerTransportConnection(), reliable, childName, text);
        }

        [ScriptFunction("sendUIEffectVisibility")]
        public static void SendUIEffectVisibility(PlayerClass player, short key, string childName, bool isVisible, bool reliable = true)
        {
            EffectManager.sendUIEffectVisibility(key, player.Player.channel.GetOwnerTransportConnection(), reliable, childName, isVisible);
        }

        [ScriptFunction("triggerEffect")]
        public static void TriggerEffect(TriggerEffectParametersClass triggerEffectParameters)
        {
            TriggerEffectParametersCSClass tepCS = triggerEffectParameters.triggerEffectParametersCSClass;

            if (tepCS.guid != Guid.Empty)
            {
                TriggerEffectParameters n_triggerEffectParameters = new TriggerEffectParameters(tepCS.guid);
                n_triggerEffectParameters.relevantDistance = tepCS.relevantDistance;
                n_triggerEffectParameters.wasInstigatedByPlayer = tepCS.wasInstigatedByPlayer;
                n_triggerEffectParameters.reliable = tepCS.reliable;
                n_triggerEffectParameters.scale = tepCS.scale;
                n_triggerEffectParameters.direction = tepCS.direction;
                n_triggerEffectParameters.position = tepCS.position;
                n_triggerEffectParameters.shouldReplicate = tepCS.shouldReplicate;
                EffectManager.triggerEffect(n_triggerEffectParameters);
            }
            else if (tepCS.id > 0)
            {
                TriggerEffectParameters n_triggerEffectParameters = new TriggerEffectParameters(tepCS.id);
                n_triggerEffectParameters.relevantDistance = tepCS.relevantDistance;
                n_triggerEffectParameters.wasInstigatedByPlayer = tepCS.wasInstigatedByPlayer;
                n_triggerEffectParameters.reliable = tepCS.reliable;
                n_triggerEffectParameters.scale = tepCS.scale;
                n_triggerEffectParameters.direction = tepCS.direction;
                n_triggerEffectParameters.position = tepCS.position;
                n_triggerEffectParameters.shouldReplicate = tepCS.shouldReplicate;
                EffectManager.triggerEffect(n_triggerEffectParameters);
            }
            else
            {
                Console.WriteLine("uClassManagers (EffectManager) module from uScript => Please enter a valid ID or GUID", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                return;
            }
        }
    }
}