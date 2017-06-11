using System;


namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (nextNum > maxNumber)
                {
                    maxNumber = nextNum;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
