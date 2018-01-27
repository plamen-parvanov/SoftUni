namespace test_multi_dict
{

    using System;
    using System.Collections.Generic;

    public class TestMultiDict
    {

        public static void Main()
        {
            var nestedDict = new Dictionary<string, Dictionary<string, string>>();

            var inputArr = Console.ReadLine().Split(' ');
            var continent = inputArr[0];
            var country = inputArr[1];
            var capital = inputArr[2];

            if (!nestedDict.ContainsKey(continent))
            {
                nestedDict[continent] = new Dictionary<string, string>();
            }

            nestedDict[continent][country] = capital;

            
        }
    }
}
