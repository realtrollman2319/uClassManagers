using SDG.Unturned;
using System;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extensions
{
    [ScriptTypeExtension(typeof(PlayerEffectsClass))]
    public static class PlayerEffectsClassExtension // Extension for player.effects for additional UI methods
    {
        [ScriptFunction("clearUIByGuid")]
        public static void ClearUIByGuid([ScriptInstance] ExpressionValue instance, string guid)
        {
            if (!(instance.Data is PlayerEffectsClass playerEffects)) return;
            EffectManager.ClearEffectByGuid(Guid.Parse(guid), playerEffects.Player.channel.owner.transportConnection);
        }

        [ScriptFunction("sendImage")]
        public static void SendImage([ScriptInstance] ExpressionValue instance, short key, string childName, string url, bool reliable = true, bool shouldCache = true, bool forceRefresh = false)
        {
            if (!(instance.Data is PlayerEffectsClass playerEffects)) return;
            EffectManager.sendUIEffectImageURL(key, playerEffects.Player.channel.owner.transportConnection, reliable, childName, url, shouldCache, forceRefresh);
        }

        [ScriptFunction("sendVisibility")]
        public static void SendVisibility([ScriptInstance] ExpressionValue instance, short key, string childName, bool visible, bool reliable = true)
        {
            if (!(instance.Data is PlayerEffectsClass playerEffects)) return;
            EffectManager.sendUIEffectVisibility(key, playerEffects.Player.channel.owner.transportConnection, reliable, childName, visible);
        }
    }
}