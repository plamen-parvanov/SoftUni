﻿namespace _09.Multiplication_Table
{

    using System;


    public class Problem09
    {

        public static void Main()
        {

            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }

        }
    }
}
