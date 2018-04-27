using System;


namespace _05.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main()
        {
            string[] integers = Console.ReadLine().Split(' ');
            int[] intArr = new int[integers.Length];
            int cntr = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                intArr[i] = int.Parse(integers[i]);
                cntr = IncreaseCntrIfNumOdd(intArr, cntr, i);
            }
            Console.WriteLine(cntr);
        }

        private static int IncreaseCntrIfNumOdd(int[] intArr, int cntr, int i)
        {
            if (intArr[i] % 2 != 0)
            {
                cntr++;
            }

            return cntr;
        }
    }
}
