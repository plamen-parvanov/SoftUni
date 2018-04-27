namespace _01.Sum_Array_Elements
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Arrays
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var intArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArr[i] = int.Parse(Console.ReadLine());
            }

            var sum = 0;

            foreach (var number in intArr)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
