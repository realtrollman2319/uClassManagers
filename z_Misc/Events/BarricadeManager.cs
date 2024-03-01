using SDG.Unturned;
using Steamworks;
using System.Reflection;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;
using uScript.Unturned;

namespace uClassManagers.Events
{
    [ScriptEvent("onTransformRequested", "victim, killer, cause")]
    public class OnTransformRequestedEvent : ScriptEvent
    {
        public override EventInfo EventHook(out object instance)
        {
            instance = null;
            return typeof(BarricadeManager).GetEvent("onTransformRequested", BindingFlags.Public | BindingFlags.Static);
        }

        [ScriptEventSubscription]
        public void PlayerDeath(CSteamID instigator, byte x, byte y, ushort plant, uint instanceID, ref Vector3 point, ref byte angle_x, ref byte angle_y, ref byte angle_z, ref bool shouldAllow)
        {
            var args = new ExpressionValue[]
            {
                instigator != Provider.server ? ExpressionValue.CreateObject(new PlayerClass(PlayerTool.getPlayer(instigator))) : ExpressionValue.Null,
                x, y, plant, instanceID,
            };

            RunEvent(this, args);
        }
    }
}
