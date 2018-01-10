namespace _07.Hideout
{
    using System.Linq;
    using System;
    using System.Text.RegularExpressions;


    public class Program
    {

        public static void Main()
        {
            var input = Console.ReadLine();

            while (true)
            {
                var tokens = Console.ReadLine().Split();

                var pattern = $@"\{tokens[0]}{{{tokens[1]},}}";

                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine("Hideout found at index {0} and it is with size {1}!",
                        input.IndexOf(match.Value), match.Value.Length);
                    break;
                }
            }
        }
    }
}
