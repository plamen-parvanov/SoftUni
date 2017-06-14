namespace _07.Count_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    public class Lists
    {

        public static void Main()
        {
            var numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

            numberList.Sort();

            int count = 1;

            for (int i = 0; i < numberList.Count - 1; i++)
            {
                if (numberList[i] == numberList[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{numberList[i]} -> {count}");
                    count = 1;
                }
            }

            Console.WriteLine($"{numberList[numberList.Count - 1]} -> {count}");



        }
    }
}
