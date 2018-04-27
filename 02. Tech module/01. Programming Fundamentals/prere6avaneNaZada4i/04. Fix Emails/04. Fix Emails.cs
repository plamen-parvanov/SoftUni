namespace _04.Fix_Emails
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var emailBook = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "stop")
            {
                var name = input;
                var email = Console.ReadLine();
                var emailEndArr = email.Split('.').Reverse().ToArray();
              
                if (emailEndArr[0] != "us" && emailEndArr[0] != "uk")
                {
                    emailBook[name] = email;
                }


                input = Console.ReadLine();
            }

            PrintEmailsFromDict(emailBook);

        }


        public static void PrintEmailsFromDict(Dictionary<string, string> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }

        }
    }
}
