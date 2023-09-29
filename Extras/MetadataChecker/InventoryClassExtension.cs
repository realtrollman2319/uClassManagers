using SDG.Unturned;
using System;
using System.Collections.Generic;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extras.MetadataChecker
{
    [ScriptTypeExtension(typeof(InventoryClass))]
    public class InventoryClassExtension
    {
        [ScriptFunction("addItemMetadata")]
        public static void addItemMetadata([ScriptInstance] ExpressionValue instance, ushort idGiven, ExpressionValue arrayGiven, byte qualityGiven = 100, byte amountGiven = 1) // For uScript module developers, you can set optional arguments by setting a default variable like qualityGiven, and amountGiven.
        {
            if (!(instance.Data is InventoryClass iclass)) return;

            Asset findAsset = Assets.find(EAssetType.ITEM, idGiven); // Find item

            if (findAsset != null) // Yes it exists
            {
                List<byte> bList = new List<byte>(); // Create list

                foreach (var arrayElement in arrayGiven.AsList) // Loop through
                {
                    byte parsedByte;
                    bool hasParsedArrayElementByte = Byte.TryParse(arrayElement, out parsedByte);
                    if (hasParsedArrayElementByte == true)
                    {
                        bList.Add(parsedByte); // Yay, valid array element! Let's add it.
                    }
                    else
                    {
                        Console.WriteLine("MetadataChecker module from uScript => One of the array elements failed to parse! Numbers must only be 0 to 255 and not a string or an object. Check the array elements and try again.", Console.ForegroundColor = ConsoleColor.Red); // Asshole put "255" lmao
                        Console.ResetColor();
                        return;
                    }
                }

                Item newItem = new Item(idGiven, 1, qualityGiven, bList.ToArray()); // Create an item
                ItemClass newUItemClass = new ItemClass(idGiven);
                int uItemLength = newUItemClass.Item.item.metadata.Length;

                if (uItemLength == 0) // Item dosen't have metadata (like a potato)
                {
                    Console.WriteLine("MetadataChecker module from uScript => Item's metadata dosen't contain an array! Spawn another item.", Console.ForegroundColor = ConsoleColor.Red); // metadata dosen't exist
                    Console.ResetColor();
                    return;
                }
                else if (uItemLength < bList.Count) // Item metadata is shorter than array given
                {
                    Console.WriteLine($"MetadataChecker module from uScript => Given array exceeds the given item's metadata! Edit your array to match the metadata you're editing. Item's metadata count: {uItemLength} | Array count: {bList.Count}", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                    return;
                }
                else if (uItemLength > bList.Count) // Item metadata is larger than array given
                {
                    Console.WriteLine($"MetadataChecker module from uScript => Given array is smaller than the item's metadata! Edit your array to match the metadata you're editing. Item's metadata count: {uItemLength} | Array count: {bList.Count}", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                    return;
                }
                else
                {
                    for (int i = 0; i < amountGiven; i++)
                    {
                        iclass.Inventory.tryAddItem(newItem, true);
                    }
                }
            }
            else // No it dosen't again lmao
            {
                Console.WriteLine("MetadataChecker module from uScript => Item not found.", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                return;
            }
        }
    }

}
