namespace _03.Mixed_Phones
{

    using System;
    using System.Collections.Generic;

    public class Problem03
    {

        public static void Main()
        {
            var phoneBook = new SortedDictionary<string, long>();

            while (true)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLine[0] == "Over")
                {
                    break;
                }

                long value;
                string name;

                if (long.TryParse(inputLine[0], out value))
                {
                    name = inputLine[1];
                }
                else
                {
                    name = inputLine[0];
                    value = long.Parse(inputLine[1]);
                }

                phoneBook[name] = value;
            }

            PrintPhoneBook(phoneBook);
        }

        public static void PrintPhoneBook(SortedDictionary<string, long> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
