using System;


namespace Progblem_06___Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstNum; i <= lastNum; i++)
            {
                for (int j = firstNum; j <= lastNum; j++)
                {
                    counter++;
                    if (j + i == magicNum)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", counter, i, j, j + i);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNum);

        }
    }
}
