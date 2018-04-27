using System;


namespace _06.Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main()
        {
            string[] integers = Console.ReadLine().Split(' ');
            int[] intArr = new int[integers.Length];

            for (int i = 0; i < integers.Length; i++)
            {
                intArr[i] = int.Parse(integers[i]);

                if (i % 2 != 0 && intArr[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {intArr[i]}");
                }
            }
        }
    }
}
