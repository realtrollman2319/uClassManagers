using System;
using uScript.API.Attributes;

namespace uClassManagers.Extras.uDateTime
{
    [ScriptModule("uTime")]
    public class uTimeClass
    {
        [ScriptProperty("now")]
        public static DateTimeOffsetClass Now => new DateTimeOffsetClass(DateTimeOffset.Now);

        [ScriptProperty("utcNow")]
        public static DateTimeOffsetClass UtcNow => new DateTimeOffsetClass(DateTimeOffset.UtcNow);
    }
}
