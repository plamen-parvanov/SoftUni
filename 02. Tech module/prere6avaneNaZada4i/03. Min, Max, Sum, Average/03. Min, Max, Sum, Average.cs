namespace _03.Min__Max__Sum__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dictionaries
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            var sum = numArr.Sum();
            var min = numArr.Min();
            var max = numArr.Max();
            var average = numArr.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");

        }
    }
}
