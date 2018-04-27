using System;


namespace _01.Sum_Array_Elements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] allNumbres = new int [n];
            int sumOfNumbers = 0;

            foreach (var item in allNumbres)
            {
                sumOfNumbers += int.Parse(Console.ReadLine());

            }

            Console.WriteLine(sumOfNumbers);
        }
    }
}
