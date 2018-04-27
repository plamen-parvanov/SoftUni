namespace _06.Sum_Reversed_Numbers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        static void Main()
        {
            var inputList = Console.ReadLine().Split().ToList();

            int sum = SumReversedNumbers(inputList);           

            Console.WriteLine(sum);
        }

        public static int SumReversedNumbers(List<string> inputList)
        {
            int sum = 0;

            foreach (var item in inputList)
            {
                var reversedItemArr = item.Reverse();
                string itemReversed = string.Join("", reversedItemArr);
                sum += int.Parse(itemReversed);
            }

            return sum;
        }
    }
}
