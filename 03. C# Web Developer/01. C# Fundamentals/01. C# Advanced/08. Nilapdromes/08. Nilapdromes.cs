namespace _08.Nilapdromes
{
    using System;

    public class Problem08
    {
        public static void Main()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                else if (WordIsNilapdrome(inputLine))
                {
                    Console.WriteLine(ChangeCoreWithBorders(inputLine));
                }
            }
        }

        public static bool WordIsNilapdrome(string input)
        {
            if (input.Length < 3)
            {
                return false;
            }
            else if (input[0] != input[input.Length - 1])
            {
                return false;
            }

            return true;
        }

        public static string ChangeCoreWithBorders(string input)
        {
            var border = FindBorder(input);
            var core = input.Trim(border.ToCharArray());

            return core + border + core;
        }

        public static string FindBorder(string input)
        {
          // TODO

            return null;
        }

    }
}
