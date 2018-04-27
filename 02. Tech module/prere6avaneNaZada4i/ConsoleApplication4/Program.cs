using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startIngredients = Console.ReadLine().Split(' ').ToArray();
            int countOfLetters = int.Parse(Console.ReadLine());
            string[] realIngredients = new string[startIngredients.Length];
            int countOfIngerients = 0;
            for (int i = 0; i < startIngredients.Length; i++)
            {
                if (startIngredients[i].Length == countOfLetters)
                {
                    realIngredients[i] = startIngredients[i];
                    countOfIngerients++;
                    Console.WriteLine($"Adding {realIngredients[i]}.");
                }
            }

            Console.WriteLine($"Made pizza with total of {countOfIngerients} ingredients.");
            Console.WriteLine($"The ingredients are: " + String.Join(", ", realIngredients) + ".");
        }
    }
}