using _05.Mordor_sCruelPlan.Enums;
using _05.Mordor_sCruelPlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Mordor_sCruelPlan.Factories
{
    public abstract class MoodFactory
    {
        public static Mood CreateMood(string inputLine)
        {
            return new Mood(CreateListOfFood(inputLine));            
        }

        private static List<Food> CreateListOfFood(string input)
        {
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList()
                        .Select(Parse)
                        .ToList();
        }

        private static Food Parse(string food)
        {

            Food result;
            Enum.TryParse<Food>(food, true, out result);

            if (result == 0)
            {
                result = Food.EverythingElse;
            }

            return result;
        }
    }
}
