using System;

namespace _02.Diamond_Problem
{
    public class Problem02
    {
        public static bool found;

        public static void Main()
        {
            var text = Console.ReadLine();

            SearchForDiamondsIn(text);

            if (!found)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        public static void SearchForDiamondsIn(string text)
        {
            var isDiamond = false;
            var carats = 0;

            foreach (var symbol in text)
            {
                if (symbol == '<')
                {
                    isDiamond = true;
                }
                else if (symbol == '>' && isDiamond)
                {
                    isDiamond = false;
                    found = true;
                    Console.WriteLine($"Found {carats} carat diamond");

                    carats = 0;
                }

                if (isDiamond && char.IsDigit(symbol))
                {
                    carats += symbol - '0';  
                }
            }
        }
    }
}
