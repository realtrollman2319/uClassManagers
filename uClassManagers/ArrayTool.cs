using System;
using System.Collections.Generic;
using System.Linq;
using uScript.Core;

namespace uClassManagers
{
    public static class UnsignedShortTool
    {
        public static ushort[] FromVectorExpressionValue(ExpressionValue array)
        {
            List<ushort> list = new List<ushort>();

            foreach (var arrayElement in array.AsList)
            {
                bool hasParsed = ushort.TryParse(arrayElement, out ushort parsedushort);
                if (hasParsed)
                {
                    list.Add(parsedushort);
                }
                else
                {
                    C.WriteError("One of the array elements failed to parse! ushorts must be 0 to 65535 and not a string or an object. Check the array elements and try again.");
                    return null;
                }
            }

            return list.ToArray();
        }

        public static ushort[][] FromMatrixExpressionValue(ExpressionValue array)
        {
            List<ushort[]> list = new List<ushort[]>();

            foreach (var row in array.AsList)
            {
                List<ushort> col = new List<ushort>();
                foreach (var column in row.AsList)
                {
                    bool hasParsed = ushort.TryParse(column, out ushort parsedushort);
                    if (hasParsed)
                    {
                        col.Add(parsedushort);
                    }
                    else
                    {
                        C.WriteError("One of the array elements failed to parse! Unsigned shorts must be 0 to 65535 and not a string or an object. Check the array elements and try again.");
                        return null;
                    }
                }

                list.Add(col.ToArray());
            }

            return list.ToArray();
        }

        public static ExpressionValue FromVectorArray(ushort[] array) => ExpressionValue.Array(array.Select(u => (ExpressionValue)u));

        public static ExpressionValue FromMatrixArray(ushort[][] array)
        {
            List<ExpressionValue> list = new List<ExpressionValue>();
            for (int r = 0; r < array.Length; r++)
            {
                ExpressionValue[] row = array[r].Select(u => (ExpressionValue)u).ToArray();
                list.Add(ExpressionValue.Array(row));
            }
            return ExpressionValue.Array(list.ToArray());
        }
    }

    public static class ByteTool
    {
        public static byte[] FromExpressionValue(ExpressionValue array)
        {
            List<byte> list = new List<byte>();

            foreach (var arrayElement in array.AsList)
            {
                bool hasParsed = byte.TryParse(arrayElement, out byte parsedByte);
                if (hasParsed)
                {
                    list.Add(parsedByte);
                }
                else
                {
                    C.WriteError("One of the array elements failed to parse! Numbers must only be 0 to 255 and not a string or an object. Check the array elements and try again.");
                    return null;
                }
            }

            return list.ToArray();
        }

        public static ExpressionValue FromArray(byte[] array) => ExpressionValue.Array(array.Select(b => (ExpressionValue)b));
    }

    public static class BoolTool
    {
        public static bool[] FromExpressionValue(ExpressionValue array)
        {
            List<bool> list = new List<bool>();

            foreach (var arrayElement in array.AsList)
            {
                bool hasParsed = bool.TryParse(arrayElement, out bool parsedBool);
                if (hasParsed)
                {
                    list.Add(parsedBool);
                }
                else
                {
                    C.WriteError("One of the array elements failed to parse! Booleans must be only true or false and not a string or an object. Check the array elements and try again.");
                    return null;
                }
            }

            return list.ToArray();
        }

        public static ExpressionValue FromArray(bool[] array) => ExpressionValue.Array(array.Select(b => (ExpressionValue)b));
    }
}