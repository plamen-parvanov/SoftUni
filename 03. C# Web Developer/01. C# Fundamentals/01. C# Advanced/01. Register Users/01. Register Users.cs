namespace _01.Register_Users
{

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Problem01
    {

        public static void Main()
        {
            var dict = new Dictionary<string, DateTime>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                var splitArr = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var user = splitArr[0];
                var date = DateTime.ParseExact(splitArr[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!dict.ContainsKey(user))
                {
                    dict[user] = new DateTime();
                }

                dict[user] = date;
            }

            var result = dict.Reverse()
                    .OrderBy(d => d.Value)
                    .Take(5)
                    .OrderByDescending(d => d.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine(string.Join(Environment.NewLine, result.Keys));
        }
    }
}
