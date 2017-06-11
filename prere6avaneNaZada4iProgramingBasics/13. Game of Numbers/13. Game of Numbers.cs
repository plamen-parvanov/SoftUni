using System;


namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int cntrCombinations = 0;
            int cntrSum = 0;
            int firstNum = 0;
            int secondNum = 0;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    cntrCombinations++;

                    if (i + j == magicNum)
                    {
                        cntrSum++;
                        firstNum = i;
                        secondNum = j;

                    }
                }
            }

            if (cntrSum != 0)
            {
                Console.WriteLine($"Number found! {firstNum} + {secondNum} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{cntrCombinations} combinations - neither equals {magicNum}");
            }

        }
    }
}
