using System;


namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int start = secondNum;
            int end = firstNum;

            if (firstNum <= secondNum)
            {
                start = firstNum;
                end = secondNum;
            }

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
