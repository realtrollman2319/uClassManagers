using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace uClassManagers
{
    public static class ColorTool
    {
        public static Color? ParseString(string hexColor)
        {
            bool hasParsed = ColorUtility.TryParseHtmlString(hexColor, out Color color);
            if (hasParsed)
            {
                return color;
            }
            else
            {
                C.WriteError("Invalid hexadecimal color code! It must be between #000000 and #FFFFFF. Check the color code and try again.");
                return null;
            }
        }
    }
}
