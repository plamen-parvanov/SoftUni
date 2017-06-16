namespace _02.Phonebook_Upgrade
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {

            var inputArr = Console.ReadLine().Split().ToArray();
            var command = inputArr[0];
            var phonebook = new SortedDictionary<string, string>();

            while (command != "END")
            {

                switch (command)
                {
                    case "A":
                        phonebook[inputArr[1]] = inputArr[2];
                        break;

                    case "S":
                        SearchInPhonebookForName(inputArr, phonebook);
                        break;

                    case "ListAll":
                        PrintAllPhonebook(phonebook);
                        break;
                }
                inputArr = Console.ReadLine().Split().ToArray();
                command = inputArr[0];
            }



        }

        public static void SearchInPhonebookForName(string[] inputArr, SortedDictionary<string, string> phonebook)
        {
            if (phonebook.ContainsKey(inputArr[1]))
            {
                Console.WriteLine("{0} -> {1}", inputArr[1], phonebook[inputArr[1]]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", inputArr[1]);
            }
        }

        public static void PrintAllPhonebook(SortedDictionary<string, string> phonebook)
        {

            foreach (var kvp in phonebook)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }

        }
    }
}
