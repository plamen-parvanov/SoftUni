namespace _02.Choose_a_Drink_2._0
{

    using System;


    public class Problem02
    {

        public static void Main()
        {

            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var price = 0d;

            switch (profession)
            {
                case "Athlete":
                    price = 0.7;
                    break;

                case "Businessman":
                case "Businesswoman":
                    price = 1;
                    break;

                case "SoftUni Student":
                    price = 1.7;
                    break;

                default:
                    price = 1.2;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {price * quantity :f2}.");

        }
    }
}
