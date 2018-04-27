using System;


namespace _02.Count_of_Negative_Elements_in_Arrayy
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] integers = new int[n];

            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }

            int countNegativeNum = 0;
            countNegativeNum = CountNegativeNumbers(integers, countNegativeNum);

            Console.WriteLine(countNegativeNum);
        }

        private static int CountNegativeNumbers(int[] integers, int countNegativeNum)
        {
            foreach (var number in integers)
            {
                if (number < 0)
                {
                    countNegativeNum++;
                }
            }

            return countNegativeNum;
        }
    }
}
