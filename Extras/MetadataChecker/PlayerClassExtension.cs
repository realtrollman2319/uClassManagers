using SDG.Unturned;
using System;
using System.Collections.Generic;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extras.MetadataChecker
{
    [ScriptTypeExtension(typeof(PlayerClass))]
    public class PlayerClassExtension
    {
        [ScriptFunction("giveItemMetadata")]
        public static void GiveItemMetadata([ScriptInstance] ExpressionValue instance, ushort idGiven, ExpressionValue arrayGiven, byte qualityGiven = 100, byte amountGiven = 1)
        {
            if (!(instance.Data is PlayerClass playerClass)) return;

            Asset findAsset = Assets.find(EAssetType.ITEM, idGiven); // Find the asset

            if (findAsset != null) // If it's not null (It exists)
            {
                List<byte> bList = new List<byte>(); // Create a byte list

                foreach (var arrayElement in arrayGiven.AsList)
                {
                    byte parsedByte;
                    bool hasParsedArrayElementByte = Byte.TryParse(arrayElement, out parsedByte); // Try to parse

                    if (hasParsedArrayElementByte == true) // Yes it exists
                    {
                        bList.Add(parsedByte);
                    }
                    else // No it dosen't lmao, now we tell player
                    {
                        Console.WriteLine("MetadataChecker module from uScript => One of the array elements failed to parse! Numbers must only be 0 to 255 and not a string or an object. Check the array elements and try again.", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();
                        return;
                    }
                }

                Item newItem = new Item(idGiven, 1, qualityGiven, bList.ToArray()); // Create an item
                ItemClass newUItemClass = new ItemClass(idGiven);
                int uItemLength = newUItemClass.Item.item.metadata.Length;

                if (uItemLength == 0) // Item dosen't have metadata (like a potato)
                {
                    Console.WriteLine("MetadataChecker module from uScript => Item's metadata dosen't contain an array! Spawn another item.", Console.ForegroundColor = ConsoleColor.Red); // Metadata dosen't exist
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
                        playerClass.Player.inventory.forceAddItem(newItem, true); // Add the item to player's inventory | TBH I should've removed this method and replace it to inventory.addItemMetadata, but that would fuck up scripts
                    }
                }
            }
            else
            {
                Console.WriteLine("MetadataChecker module from uScript => Item not found.", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                return;
            }
        }
    }
}
