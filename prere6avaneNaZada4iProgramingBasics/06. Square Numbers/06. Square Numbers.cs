namespace _06.Square_Numbers
{

    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Lists
    {

        public static void Main()
        {
            var numbersInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            var sqrtList = new List<int>();

            CheckForSquaredNum(numbersInput, sqrtList);

            sqrtList.Sort();
            sqrtList.Reverse();

            Console.WriteLine(string.Join(" ", sqrtList));
        }

        public static void CheckForSquaredNum(List<int> numbersInput, List<int> sqrtList)
        {
            foreach (var number in numbersInput)
            {
                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    sqrtList.Add(number);
                }
            }
        }
    }
}
