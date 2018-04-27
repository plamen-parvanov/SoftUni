namespace _01.Phonebook
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var commandArr = Console.ReadLine().Split().ToArray();

            var command = commandArr[0];
           
            var phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
       
                switch (command)
                {
                    case "A":
                        phonebook[commandArr[1]] = commandArr[2];
                        break;

                    case "S":
                        if (phonebook.ContainsKey(commandArr[1]))
                        {
                            Console.WriteLine("{0} -> {1}",
                                commandArr[1], phonebook[commandArr[1]] );
                        }
                        else
                        {
                            Console.WriteLine($"Contact {commandArr[1]} does not exist.");
                        }
                        break;
                }

                commandArr = Console.ReadLine().Split().ToArray();
                command = commandArr[0];
                

            }
        }
    }
}
