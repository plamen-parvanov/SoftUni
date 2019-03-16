namespace AnimalCentre.Validators
{
    using Models.Contracts;
    using System;
    using System.Collections.Generic;

    public static class Validator
    {
        public static void ValidateHappiness(int value, int minValue, int maxValue, string type)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException($"Invalid {type}");
            }
        }

        public static void ValidateEnergy(int value, int minValue, int maxValue, string type)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException($"Invalid {type}");
            }
        }

        public static void IsAnimalChipped(IAnimal animal)
        {
            if (animal.IsChipped)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }
        }

        public static void IsProcedureTimeEnough(int timeLeft, int procedureTime)
        {
            if (procedureTime > timeLeft)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }
        }

        public static void IsThereEnoughCapacity(int capacity, int count)
        {
            if (capacity == count)
            {
                throw new InvalidOperationException("Not enough capacity"); 
            }
        }

        public static void DoesAnimalAlreadyExist(Dictionary<string, IAnimal> dict, string name)
        {
            if (dict.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} already exist");
            }
        }

        public static void AnimalDoesNotExist(Dictionary<string, IAnimal> dict, string name)
        {
            if (!dict.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }
    }
}
