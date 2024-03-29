﻿using SDG.Unturned;
using uClassManagers.Classes;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extensions
{
    [ScriptTypeExtension(typeof(BarricadeClass))]
    public class BarricadeClassExtension
    {
        [ScriptFunction("get_data")]
        public static BarricadeDataClass GetBarricadeDataClass([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is BarricadeClass barricadeClass)) return null;
            return new BarricadeDataClass(BarricadeManager.FindBarricadeByRootTransform(barricadeClass.BarricadeTransform).GetServersideData());
        }

        [ScriptFunction("get_drop")]
        public static BarricadeDropClass GetBarricadeDropClass([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is BarricadeClass barricadeClass)) return null;
            return new BarricadeDropClass(BarricadeManager.FindBarricadeByRootTransform(barricadeClass.BarricadeTransform));
        }

        [ScriptFunction("get_transform")]
        public static TransformClass GetBarricadeTransform([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is BarricadeClass barricadeClass)) return null;
            return new TransformClass(barricadeClass.BarricadeTransform);
        }
    }
}