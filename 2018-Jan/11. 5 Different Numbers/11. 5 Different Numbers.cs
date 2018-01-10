namespace _11._5_Different_Numbers
{

    using System;


    public class Problem11
    {

        public static void Main()
        {

            var firstNum = int.Parse(Console.ReadLine());
            var lastNum = int.Parse(Console.ReadLine());

            if (lastNum - firstNum < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                PrintAllNumsBetweenFirstAndLast(firstNum, lastNum);
            }

        }

        public static void PrintAllNumsBetweenFirstAndLast(int firstNum, int lastNum)
        {
            for (int i = firstNum; i <= lastNum; i++)
            {
                for (int j = i + 1; j <= lastNum; j++)
                {
                    for (int k = j + 1; k <= lastNum; k++)
                    {
                        for (int l = k + 1; l <= lastNum; l++)
                        {
                            for (int m = l + 1; m <= lastNum; m++)
                            {
                                Console.WriteLine($"{i} {j} {k} {l} {m}");
                            }
                        }
                    }
                }
            }
        }
    }
}
