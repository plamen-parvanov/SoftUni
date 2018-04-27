namespace _01.Choose_a_Drink
{

    using System;


    public class Problem01
    {

        public static void Main()
        {

            //“Water” – for “Athlete”
            //“Coffee” – for “Businessman” or “Businesswoman”
            //“Beer” – for “SoftUni Student”
            //“Tea” – for all other professions

            var profession = Console.ReadLine();

            var drink = string.Empty;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businessman":
                case "Buinesswomen":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;           
                default:
                    drink = "Tea";
                    break;
            }

            Console.WriteLine(drink);
        }
    }
}
