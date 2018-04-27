namespace _05.Pizza_Ingredients
{
    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var inputArr = Console.ReadLine().Split().ToArray();
            byte maxLenght = byte.Parse(Console.ReadLine());

            byte ingredients = 0;

            foreach (var item in inputArr)
            {
                if (item.Length == maxLenght )
                {
                    ingredients++;
                    Console.WriteLine($"Adding {item}.");                   
                }

                if (ingredients > 9)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredients} ingredients.");

            var ingrArr = new string[ingredients];
            byte temp = 0;

            foreach (var item in inputArr)
            {
                if (item.Length == maxLenght && temp < 10)
                {
                    ingrArr[temp] = item;
                    temp++;
                }
            }

            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", ingrArr));


        }
    }
}
