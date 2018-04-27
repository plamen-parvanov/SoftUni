using System;


namespace Problem_06___Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int cntr = 0;

            for (int i = num1; i >= num2; i--)
            {
                for (int j = num1; j >= num2; j--)
                {
                    cntr++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})",
                            cntr, i, j, magicNum);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", cntr, magicNum);

        }
    }
}
