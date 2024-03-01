using SDG.Unturned;
using System.Collections.Generic;
using uClassManagers.Classes;
using UnityEngine;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Managers
{
    [ScriptModule("AnimalManager")]
    public class AnimalManagerClass
    {
        [ScriptProperty("updates")]
        public static ushort Updates => AnimalManager.updates;

        [ScriptFunction("animals")]
        public static ExpressionValue Animals()
        {
            List<ExpressionValue> ListAnimal = new List<ExpressionValue>();
            foreach (Animal animal in AnimalManager.animals)
            {
                ListAnimal.Add(ExpressionValue.CreateObject(new uAnimalClass(animal)));
            }
            return ExpressionValue.Array(ListAnimal);
        }

        [ScriptFunction("tickingAnimals")]
        public static ExpressionValue TickingAnimals()
        {
            List<ExpressionValue> ListAnimal = new List<ExpressionValue>();
            foreach (Animal animal in AnimalManager.tickingAnimals)
            {
                ListAnimal.Add(ExpressionValue.CreateObject(new uAnimalClass(animal)));
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
        public static void DropLoot(uAnimalClass animal)
        {
            AnimalManager.dropLoot(animal.animal);
        }

        [ScriptFunction("getAnimal")]
        public static uAnimalClass GetAnimal(ushort index)
        {
            return new uAnimalClass(AnimalManager.getAnimal(index));
        }

        [ScriptFunction("getAnimalsInRadius")]
        public static ExpressionValue GetAnimalsInRadius(Vector3Class center, float sqrRadius)
        {
            List<Animal> animalsInRadius = new List<Animal>();
            AnimalManager.getAnimalsInRadius(center.Vector3, sqrRadius, animalsInRadius);

            List<ExpressionValue> listAnimal = new List<ExpressionValue>();
            foreach (Animal animal in animalsInRadius)
            {
                listAnimal.Add(ExpressionValue.CreateObject(new uAnimalClass(animal)));
            }
            return ExpressionValue.Array(listAnimal.ToArray());
        }

        [ScriptFunction("giveAnimal")]
        public static bool GiveAnimal(PlayerClass player, ushort id)
        {
            return AnimalManager.giveAnimal(player.Player, id);
        }

        [ScriptFunction("sendAnimalAlive")]
        public static void SendAnimalAlive(uAnimalClass animal, Vector3Class newPosition, byte newAngle)
        {
            AnimalManager.sendAnimalAlive(animal.animal, newPosition.Vector3, newAngle);
        }

        [ScriptFunction("sendAnimalAttack")]
        public static void SendAnimalAttack(uAnimalClass animal)
        {
            AnimalManager.sendAnimalAttack(animal.animal);
        }

        [ScriptFunction("sendAnimalDead")]
        public static void SendAnimalDead(uAnimalClass animal, Vector3Class newRagdoll, string newRagdollEffect = "none")
        {
            ERagdollEffect? ragdollEffect = EnumTool.ragdollEffects.GetEnum(newRagdollEffect);
            if (ragdollEffect == null) return;
            AnimalManager.sendAnimalDead(animal.animal, newRagdoll.Vector3, ragdollEffect.Value);
        }

        [ScriptFunction("sendAnimalPanic")]
        public static void SendAnimalPanic(uAnimalClass animal)
        {
            AnimalManager.sendAnimalPanic(animal.animal);
        }

        [ScriptFunction("sendAnimalStartle")]
        public static void SendAnimalStartle(uAnimalClass animal)
        {
            AnimalManager.sendAnimalStartle(animal.animal);
        }

        [ScriptFunction("spawnAnimal")]
        public static void SpawnAnimal(ushort id, Vector3Class point, Vector3Class rotation)
        {
            AnimalManager.spawnAnimal(id, point.Vector3, Quaternion.Euler(rotation.Vector3));
        }

        [ScriptFunction("teleportAnimalBackIntoMap")]
        public static void TeleportAnimalBackIntoMap(uAnimalClass animal)
        {
            AnimalManager.TeleportAnimalBackIntoMap(animal.animal);
        }
    }
}
