namespace DungeonsAndCodeWizards.Validaros
{
    using Models;
    using Models.Characters.Enums;
    using Models.Characters;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Validator
    {
        public static void IsAlive(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        public static void IsBagFull(double bagWeight, double itemWeight, double maxCapacity)
        {
            if (bagWeight + itemWeight > maxCapacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
        }

        public static void IsBagEmpty(int count)
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }
        }

        public static void DoesItemExist(string name, Item item)
        {
            if (item == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }
        }

        public static void InvalidCharacterName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }

        }

        public static void AttackItSelf(Character first, Character second)
        {
            if (first.Name == second.Name)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }
        }

        public static void AttackSameFraction(Character first, Character second)
        {
            var firstFraction = first.Faction;
            var secondFraction = second.Faction;

            if (firstFraction == secondFraction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {firstFraction} faction!");
            }
        }

        public static void HealEnemyFraction(Character first, Character second)
        {
            if (first.Faction.ToString() != second.Faction.ToString())
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }
        }

        public static Faction ValidateFaction(string faction)
        {
            try
            {
                return Enum.Parse<Faction>(faction);
            }
            catch (Exception)
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }
        }

        public static void ValidateCharacterInParty(Character character, string name)
        {
            if (character == null)
            {
                throw new ArgumentException($"Character {name} not found!");
            }
        }

        public static void EmptyPool(int count)
        {
            if (count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }
        }

        public static void ValidateAttacker(Character attacker)
        {
            if (!(attacker is Warrior))
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

        }

        public static void ValidateHealer(Character healer)
        {
            if (!(healer is Cleric))
            {
                throw new ArgumentException($"{healer.Name} cannot heal!");
            }

        }
    }
}
