using System;


namespace _08.Calories_Counter
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string ingredients = string.Empty;
            int sumOfCalories = 0;

            for (int i = 0; i < n; i++)
            {
                ingredients = Console.ReadLine().ToLower();

                switch (ingredients)
                {
                    case "cheese":
                        sumOfCalories += 500;
                        break;
                    case "tomato sauce":
                        sumOfCalories += 150;
                        break;
                    case "salami":
                        sumOfCalories += 600;
                        break;
                    case "pepper":
                        sumOfCalories += 50;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Total calories: {sumOfCalories}");
        }
    }
}
