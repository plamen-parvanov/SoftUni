using System;


namespace Problem_06___Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstNumber; i >= secondNumber; i--)
            {
                for (int j = firstNumber; j >= secondNumber; j--)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", counter, i, j, i + j);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            

            
        }
    }
}
