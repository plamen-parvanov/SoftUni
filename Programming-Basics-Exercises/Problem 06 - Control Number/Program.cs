using System;


namespace Problem_06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int ctrlNum = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += 2 * i + 3 * j;
                    counter++;
                    if (sum >= ctrlNum)
                    {
                        Console.WriteLine("{0} moves \nScore: {1} >= {2}", counter, sum, ctrlNum);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} moves", counter);
        }
    }
}
