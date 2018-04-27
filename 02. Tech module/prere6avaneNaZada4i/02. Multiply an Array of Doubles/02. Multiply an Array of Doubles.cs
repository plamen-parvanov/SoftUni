using System;


namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());

            string[] stringNumbers = numbers.Split(' ');

            double[] doubleNumbers = new double[stringNumbers.Length];

            for (int i = 0; i < doubleNumbers.Length; i++)
            {
                doubleNumbers[i] = double.Parse(stringNumbers[i]) * p;
                Console.Write(doubleNumbers[i] + " ");

            }
            Console.WriteLine();
            
        }
    }
}
