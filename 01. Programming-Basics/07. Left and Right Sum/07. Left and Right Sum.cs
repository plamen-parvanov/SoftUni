﻿using System;


namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum1 += number; 
            }

            for (int i = n; i < 2 * n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum2 += number;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }

            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sum1 - sum2));
            }
        }
    }
}
