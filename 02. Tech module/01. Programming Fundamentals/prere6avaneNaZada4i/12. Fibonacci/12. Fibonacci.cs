using System;


namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            int firrstNum = 1;
            int secondNum = 1;

            for (int i = 1; i < n; i++)
            {
                sum = firrstNum + secondNum;
                firrstNum = secondNum;
                secondNum = sum;
            }
            Console.WriteLine(sum);
        }
    }
}
