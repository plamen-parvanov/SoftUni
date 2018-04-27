namespace _01.Count_Real_Numbers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dictionaries
    {

        public static void Main()
        {
            var inputNums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var numDict = new SortedDictionary<double, int>();

            foreach (var num in inputNums)
            {
                if (!numDict.Keys.Contains(num))
                {
                    numDict.Add(num, 0);
                }

                numDict[num]++;
            }

            foreach (var kvp in numDict)
            {
                //var singleOtPlural = kvp.Value < 2 ? "time" : "times";

                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);

            }
        }
    }
}
