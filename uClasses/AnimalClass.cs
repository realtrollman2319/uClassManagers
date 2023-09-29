using SDG.Unturned;
using System;
using System.Collections.Generic;
using uClassManagers.Dictionaries;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.uClasses
{
    [ScriptClass("AnimalClass")] // Name conflict with Molyi's module uScriptExtended
    public class AnimalClass
    {
        public Animal animal { get; private set; }
        public AnimalClass(Animal c_animal) => animal = c_animal;

        [ScriptProperty("isDead")]
        public bool IsDead
        {
            get => animal.isDead;
        }

        [ScriptProperty("index")]
        public ushort Index
        {
            get => animal.index;
        }

        [ScriptProperty("id")]
        public ushort Id
        {
            get => animal.id;
        }

        [ScriptProperty("isUpdated")]
        public bool IsUpdated
        {
            get => animal.isUpdated;
        }

        [ScriptProperty("isHunting")]
        public bool IsHunting
        {
            get => animal.isHunting;
        }

        [ScriptProperty("isFleeing")]
        public bool IsFleeing
        {
            get => animal.isFleeing;
        }

        [ScriptProperty("target")]
        public Vector3Class Target
        {
            get => new Vector3Class(animal.target);
        }

        [ScriptProperty("lastDead")]
        public float LastDead
        {
            get => animal.lastDead;
        }

        [ScriptFunction("alertDamagedFromPoint")]
        public void AlertDamagedFromPoint(Vector3Class point)
        {
            animal.alertDamagedFromPoint(point.Vector3);
        }

        [ScriptFunction("alertDirection")]
        public void AlertDirection(Vector3Class newDirection, bool sendToPack)
        {
            animal.alertDirection(newDirection.Vector3, sendToPack);
        }

        [ScriptFunction("alertGoToPoint")]
        public void AlertGoToPoint(Vector3Class point, bool sendToPack)
        {
            animal.alertGoToPoint(point.Vector3, sendToPack);
        }

        [ScriptFunction("alertPlayer")]
        public void AlertPlayer(PlayerClass newPlayer, bool sendToPack)
        {
            animal.alertPlayer(newPlayer.Player, sendToPack);
        }

        [ScriptFunction("alertRunAwayFromPoint")]
        public void AlertRunAwayFromPoint(Vector3Class newPosition, bool sendToPack)
        {
            animal.alertRunAwayFromPoint(newPosition.Vector3, sendToPack);
        }

        [ScriptFunction("askAttack")]
        public void AskAttack()
        {
            animal.askAttack();
        }

        [ScriptFunction("askDamage")]
        public ExpressionValue AskDamage(ushort amount, Vector3Class newRagdoll, bool trackKill = true, bool dropLoot = true, string ragdollEffect = "NONE")
        {
            if (EnumDictionaries.ERagdollEffects.TryGetValue(ragdollEffect, out ERagdollEffect rEff))
            {
                List<ExpressionValue> EVList = new List<ExpressionValue>();
                EPlayerKill EPKill;
                animal.askDamage(amount, newRagdoll.Vector3, out EPKill, out uint exp, trackKill, dropLoot = true, rEff);
                EVList.Add(Enum.GetName(typeof(EPlayerKill), EPKill));
                EVList.Add(exp);
                return ExpressionValue.Array(EVList.ToArray());
            }
            else
            {
                Console.WriteLine(@"uClassManagers/AnimalClass module from uScript => Ragdoll effects MUST be ""NONE"", ""BRONZE"", ""SILVER"", ""GOLD"", or ""ZERO"". They cannot be lowercase, only uppercase.", Console.ForegroundColor = ConsoleColor.Red);
                return ExpressionValue.Null;
            }
        }

        [ScriptFunction("askEat")]
        public void AskEat()
        {
            animal.askEat();
        }

        [ScriptFunction("askGlance")]
        public void AskGlance()
        {
            animal.askGlance();
        }


        [ScriptFunction("askPanic")]
        public void AskPanic()
        {
            animal.askPanic();
        }


        [ScriptFunction("askStartle")]
        public void AskStartle()
        {
            animal.askStartle();
        }


        [ScriptFunction("checkAlert")]
        public bool CheckAlert(PlayerClass player)
        {
            return animal.checkAlert(player.Player);
        }

        [ScriptFunction("getHealth")]
        public float GetHealth()
        {
            return animal.GetHealth();
        }

        [ScriptFunction("getTargetPlayer")]
        public PlayerClass GetTargetPlayer()
        {
            return animal.GetTargetPlayer() != null ? new PlayerClass(animal.GetTargetPlayer()) : null;
        }

        [ScriptFunction("init")]
        public void Init()
        {
            animal.init();
        }

        [ScriptFunction("sendRevive")]
        public void SendRevive(Vector3Class position, float angle)
        {
            animal.sendRevive(position.Vector3, angle);
        }

        [ScriptFunction("tellAlive")]
        public void TellAlive(Vector3Class newPosition, byte newAngle)
        {
            animal.tellAlive(newPosition.Vector3, newAngle);
        }

        [ScriptFunction("tellDead")]
        public void TellDead(Vector3Class newRagdoll, string ragdollEffect)
        {
            if (EnumDictionaries.ERagdollEffects.TryGetValue(ragdollEffect, out ERagdollEffect rEff))
            {
                animal.tellDead(newRagdoll.Vector3, rEff);
            }
            else
            {
                Console.WriteLine(@"uClassManagers/AnimalClass module from uScript => Ragdoll effects MUST be ""NONE"", ""BRONZE"", ""SILVER"", ""GOLD"", or ""ZERO"". They cannot be lowercase, only uppercase.", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                return;
            }
        }

        [ScriptFunction("tellState")]
        public void TellState(Vector3Class newPosition, float newAngle)
        {
            animal.tellState(newPosition.Vector3, newAngle);
        }

        [ScriptFunction("tick")]
        public void Tick()
        {
            animal.tick();
        }

        [ScriptFunction("updateStates")]
        public void UpdateStates()
        {
            animal.updateStates();
        }
    }
}
