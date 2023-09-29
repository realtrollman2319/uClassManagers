using SDG.Unturned;
using System;
using System.Collections.Generic;
using uClassManagers.Dictionaries;
using uClassManagers.uClasses;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers
{
    [ScriptModule("AnimalManager")]
    public class AnimalManagerClass
    {
        [ScriptProperty("updates")]
        public static ushort Updates => AnimalManager.updates;

        [ScriptFunction("animals")]
        public static ExpressionValue Animals()
        {
            if (AnimalManager.animals.Count <= 0) return ExpressionValue.Null;

            List<ExpressionValue> ListAnimal = new List<ExpressionValue>();
            foreach (Animal animal in AnimalManager.animals)
            {
                ListAnimal.Add(ExpressionValue.CreateObject(new AnimalClass(animal)));
            }
            return ExpressionValue.Array(ListAnimal);
        }

        [ScriptFunction("tickingAnimals")]
        public static ExpressionValue TickingAnimals()
        {
            if (AnimalManager.tickingAnimals.Count <= 0) return ExpressionValue.Null;

            List<ExpressionValue> ListAnimal = new List<ExpressionValue>();
            foreach (Animal animal in AnimalManager.tickingAnimals)
            {
                ListAnimal.Add(ExpressionValue.CreateObject(new AnimalClass(animal)));
            }
            return ExpressionValue.Array(ListAnimal);
        }

        [ScriptFunction("maxInstances")]
        public static uint MaxInstances()
        {
            return AnimalManager.maxInstances;
        }

        [ScriptFunction("askClearAllAnimals")]
        public static void AskClearAllAnimals()
        {
            AnimalManager.askClearAllAnimals();
        }

        [ScriptFunction("dropLoot")]
        public static void DropLoot(AnimalClass animal)
        {
            AnimalManager.dropLoot(animal.animal);
        }

        [ScriptFunction("getAnimal")]
        public static AnimalClass GetAnimal(ushort index)
        {
            return new AnimalClass(AnimalManager.getAnimal(index));
        }

        [ScriptFunction("getAnimalsInRadius")]
        public static ExpressionValue GetAnimalsInRadius(Vector3Class center, float sqrRadius)
        {
            List<Animal> animalsInRadius = new List<Animal>();
            AnimalManager.getAnimalsInRadius(center.Vector3, sqrRadius, animalsInRadius);
            if (animalsInRadius.Count <= 0) return ExpressionValue.Null;

            List<ExpressionValue> listAnimal = new List<ExpressionValue>();
            foreach (Animal animal in animalsInRadius)
            {
                listAnimal.Add(ExpressionValue.CreateObject(new AnimalClass(animal)));
            }
            return ExpressionValue.Array(listAnimal.ToArray());
        }

        [ScriptFunction("giveAnimal")]
        public static bool GiveAnimal(PlayerClass player, ushort id)
        {
            return AnimalManager.giveAnimal(player.Player, id);
        }

        [ScriptFunction("sendAnimalAlive")]
        public static void SendAnimalAlive(AnimalClass animal, Vector3Class newPosition, byte newAngle)
        {
            AnimalManager.sendAnimalAlive(animal.animal, newPosition.Vector3, newAngle);
        }

        [ScriptFunction("sendAnimalAttack")]
        public static void SendAnimalAttack(AnimalClass animal)
        {
            AnimalManager.sendAnimalAttack(animal.animal);
        }

        [ScriptFunction("sendAnimalDead")]
        public static void SendAnimalDead(AnimalClass animal, Vector3Class newRagdoll, string newRagdollEffect = "NONE")
        {
            if (EnumDictionaries.ERagdollEffects.TryGetValue(newRagdollEffect, out ERagdollEffect ragdollEffect))
            {
                AnimalManager.sendAnimalDead(animal.animal, newRagdoll.Vector3, ragdollEffect);
            }
            else
            {
                Console.WriteLine(@"uClassManagers/AnimalClass module from uScript => Ragdoll effects MUST be ""NONE"", ""BRONZE"", ""SILVER"", ""GOLD"", or ""ZERO"". They cannot be lowercase, only uppercase.", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                return;
            }
        }

        [ScriptFunction("sendAnimalPanic")]
        public static void SendAnimalPanic(AnimalClass animal)
        {
            AnimalManager.sendAnimalPanic(animal.animal);
        }

        [ScriptFunction("sendAnimalStartle")]
        public static void SendAnimalStartle(AnimalClass animal)
        {
            AnimalManager.sendAnimalStartle(animal.animal);
        }

        [ScriptFunction("spawnAnimal")]
        public static void SpawnAnimal(ushort id, Vector3Class point, Vector3Class rotation)
        {
            AnimalManager.spawnAnimal(id, point.Vector3, Quaternion.Euler(rotation.Vector3));
        }

        [ScriptFunction("teleportAnimalBackIntoMap")]
        public static void TeleportAnimalBackIntoMap(AnimalClass animal)
        {
            AnimalManager.TeleportAnimalBackIntoMap(animal.animal);
        }
    }
}
