namespace _01.Letter_Repetition
{

    using System;
    using System.Collections.Generic;

    public class Problem01
    {
        public static void Main()
        {
            var inputStr = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            foreach (var charecter in inputStr)
            {
                if (!dict.ContainsKey(charecter))
                {
                    dict[charecter] = 0;
                }

                dict[charecter]++;
            }

            PrintDict(dict);

        }

        public static void PrintDict(Dictionary<char, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
