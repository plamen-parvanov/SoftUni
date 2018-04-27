namespace test98
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class test
    {

        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            dict["Bulgaria"] = new Dictionary<string, int>();
            dict["Bulgaria"]["Sofia"] = 1;
            dict["Bulgaria"]["Plovdiv"] = 2;
           
            dict["Albania"] = new Dictionary<string, int>();
            dict["Albania"]["Tirana"] = 4;

            dict["England"] = new Dictionary<string, int>();
            dict["England"]["London"] = 5;


            var result = dict.OrderByDescending(p => p.Value.Values.Sum());

            foreach (var country in result)
            {
                Console.WriteLine($"{country.Key}");
                foreach (var tonwAndPop in country.Value)
                {
                    Console.WriteLine($"  {tonwAndPop.Key} - {tonwAndPop.Value}");
                }

            }
           



        }
    }
}
