using System;


namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfOddNums = 0;

            for (int i = 1; i < 2 * n; i += 2)
            {
                sumOfOddNums += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Sum: {0}",sumOfOddNums);

        }
    }
}
