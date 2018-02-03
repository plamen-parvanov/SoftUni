namespace _06.Ordered_Banking_System
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem06
    {

        static Dictionary<string, Dictionary<string, decimal>> dict;

        public static void Main()
        {
            dict = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                AddingInfoInDict(input);
            }

            PrintOrderedDict();
        }

        public static void AddingInfoInDict(string input)
        {
            var arr = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var bank = arr[0];
            var account = arr[1];
            var balance = arr[2];

            if (!dict.ContainsKey(bank))
            {
                dict[bank] = new Dictionary<string, decimal>();
            }

            if (!dict[bank].ContainsKey(account))
            {
                dict[bank][account] = 0;
            }
            dict[bank][account] += decimal.Parse(balance);

        }

        public static void PrintOrderedDict()
        {
            dict = dict
                .OrderByDescending(v => v.Value.Values.Sum())
                .ThenByDescending(v => v.Value.Values.Max())
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var bank in dict)
            {
                var name = bank.Key;
                var accounts = bank.Value;

                foreach (var acc in accounts.OrderByDescending(v => v.Value))
                {
                    var account = acc.Key;
                    var balance = acc.Value;
                    Console.WriteLine($"{account} -> {balance} ({name})");
                }
            }
        }
    }
}
