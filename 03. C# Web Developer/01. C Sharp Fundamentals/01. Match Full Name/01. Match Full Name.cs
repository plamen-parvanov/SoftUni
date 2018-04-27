namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem01
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            Print(matches);

        }

        public static void Print(MatchCollection matches)
        {
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
