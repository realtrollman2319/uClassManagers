using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uScript.API.Attributes;

namespace uClassManagers.Extras.ConsoleModule
{
    [ScriptModule("console")]
    public static class ConsoleModule
    {
        [ScriptFunction("Write")]
        public static void Write(string text)
        {
            Console.Write(text);
        }

        [ScriptFunction("WriteLine")]
        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
