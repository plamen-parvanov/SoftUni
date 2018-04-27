namespace _06.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem06
    {
        public static void Main()
        {
            var input = @"<ul> <li> <a href=""http://softuni.bg"">SoftUni</a> </li> </ul>";
            var pattern = @"(<a) \w+=""\w +:\/\/\w +\.\w + "">\w+(<\/a>)";
            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
                match.Groups[1].Value.Replace("<a", "[URL");
                match.Groups[2].Value.Replace(@"<\/a>", @"[\URL]");
                Console.WriteLine(match.Value);
                +5

           

        }
    }
}
