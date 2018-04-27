namespace _08.Calories_Counter
{

    using System;


    public class Problem08
    {

        public static void Main()
        {
       
            var n = int.Parse(Console.ReadLine());
            var totalCal = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine();

                totalCal += CalculateIngredientCal(ingredient); 
            }

            Console.WriteLine($"Total calories: {totalCal}");
        }

        public static int CalculateIngredientCal(string ingredient)
        {
            //Cheese – 500 calories
            //Tomato sauce – 150 calories
            //Salami – 600 calories
            //Pepper – 50 calories

            var cal = 0;

            switch (ingredient.ToLower())
            {
                case "cheese":
                    cal = 500;
                    break;
                case "tomato sauce":
                    cal = 150;
                    break;
                case "salami":
                    cal = 600;
                    break;
                case "pepper":
                    cal = 50;
                    break;
            }

            return cal;
        }

    }
}
