using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uClassManagers
{
    public static class GuidTool
    {
        public static Guid ParseGuid(string input)
        {
            bool hasParsed = Guid.TryParseExact(input, "N", out Guid result);
            return hasParsed ? result : Guid.Empty;
        }
    }
}