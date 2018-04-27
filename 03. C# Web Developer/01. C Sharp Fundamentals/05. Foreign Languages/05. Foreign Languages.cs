namespace _05.Foreign_Languages
{

    using System;


    public class Problem05
    {

        public static void Main()
        {
            // English is spoken in England and USA; 
            // Spanish is spoken in Spain, Argentina and Mexico;
            // for the others, we should print "unknown"

            var country = Console.ReadLine();
            var language = "unknown";

            switch (country)
            {
                case "USA":
                case "England":
                    language = "English";
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
            }

            Console.WriteLine($"{language}");

        }
    }
}
