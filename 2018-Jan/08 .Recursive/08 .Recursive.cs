namespace _08.Recursive
{
    using System;
    using System.Collections.Generic;

    public class Problem
    {
        private static Dictionary<int, long> fibonacci;
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            fibonacci = new Dictionary<int, long>();
            fibonacci[1] = 1;
            fibonacci[2] = 1;

             var result = GetFibonacci(n);

            Console.WriteLine(result);
        }

        private static long GetFibonacci(int n)
        {
            if (fibonacci.ContainsKey(n))
            {
                return fibonacci[n];
            }

            return fibonacci[n] = GetFibonacci(n - 2 ) + GetFibonacci(n - 1); 
        }
    }
}
