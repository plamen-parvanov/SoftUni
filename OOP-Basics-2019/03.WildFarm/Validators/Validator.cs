using System;
using System.Linq;

namespace _03.WildFarm.Validators
{
    public static class Validator
    {
        public static void FoodEaten(string type, string foodName, params string[] foods)
        {
            if (!foods.Any(f => f == foodName))
            {
                throw new ArgumentException($"{type} does not eat {foodName}!");
            }
        }
    }
}
