namespace _03.Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem06
    {
        public static void Main()
        {
            //{surface}
            //{mantle}
            //{surface}{mantle}{core}{mantle}{surface}
            //{mantle}
            //{surface}
            var isValid = true;
            var coreLength = 0;
            var surfacePattern = @"^[\W_]+$";
            var mantlePattern = @"^[0-9_]+$";
            var corePattern = @"^[\W_]+[0-9_]+(?<core>[A-Za-z]+)[0-9_]+[\W_]+$";

            for (int i = 0; i < 5; i++)
            {
                var inputLine = Console.ReadLine();
                if (i == 0 || i == 4)
                {
                    if (!Regex.IsMatch(inputLine, surfacePattern))
                    {
                        isValid = false;
                        break;
                    }
                }
                else if (i == 1 || i == 3)
                {
                    if (!Regex.IsMatch(inputLine, mantlePattern))
                    {
                        isValid = false;
                        break;
                    }
                }
                else
                {
                    if (!Regex.IsMatch(inputLine, corePattern))
                    {
                        isValid = false;
                        break;
                    }

                    coreLength = Regex.Match(inputLine, corePattern).Groups["core"].Length;
                }
            }

            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine($"{coreLength}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
