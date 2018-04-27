using System;


namespace _01.Largest_Element_in_Array
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;

            int[] integers = new int[n];

            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }

            foreach (var integer in integers)
            {
                if (integer > maxValue)
                {
                    maxValue = integer;
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
