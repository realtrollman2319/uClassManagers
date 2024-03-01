using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uClassManagers.Classes;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extensions
{
    [ScriptTypeExtension(typeof(PlayerClass))]
    public static class PlayerClassExtension
    {
        [ScriptFunction("get_transform")]
        public static TransformClass GetTransform([ScriptInstance] ExpressionValue instance)
        {
            return instance.Data is PlayerClass playerClass ? new TransformClass(playerClass.Player.transform) : null;
        }

        [ScriptFunction("get_player")]
        public static uPlayerClass GetPlayerClass([ScriptInstance] ExpressionValue instance)
        {
            return instance.Data is PlayerClass playerClass ? new uPlayerClass(playerClass.Player) : null;
        }
    }
}
