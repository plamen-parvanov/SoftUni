using System;


namespace _12.Test_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int cntr = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += 3 * i * j;
                    cntr++;

                    if (sum >= maxSum)
                    {
                        break;
                    }
                }
                if (sum >= maxSum)
                {
                    break;
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine($"{cntr} combinations\nSum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{cntr} combinations\nSum: {sum}");
            }


        }
    }
}
