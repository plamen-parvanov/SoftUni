namespace _06.User_Logs
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' , '='}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var userAndIP = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                var user = input[input.Length - 1];

                if (!userAndIP.Keys.Contains(user))
                {
                    userAndIP[user] = new Dictionary<string, int>();

                }

                userAndIP[user] = CountIPentries(userAndIP[user], input);

                input = Console.ReadLine().Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var user in userAndIP)
            {
                Console.WriteLine("{0}:", user.Key);

                Console.WriteLine(string.Join(", ", user.Value.Select(x => $"{x.Key} => {x.Value}")) + ".");
            }



        }

        public static Dictionary<string, int> CountIPentries
            (Dictionary<string, int> dict, string[] input)
        {
            var IP = input[1];

            if (!dict.Keys.Contains(IP))
            {
                dict[IP] = 0;
            }

            dict[IP]++;

            return dict;
        }
    }
}