using System;


namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
