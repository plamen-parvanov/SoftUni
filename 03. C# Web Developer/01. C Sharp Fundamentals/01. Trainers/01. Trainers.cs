namespace _01.Trainers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {
        public static Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
        public static void Main()
        {
            ReadInput();

            PrintMostEarnedTeam();
        }

        private static void ReadInput()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ReadLine();
            }
        }

        private static void ReadLine()
        {
            var distance = long.Parse(Console.ReadLine()) * 1600;
            var cargo = decimal.Parse(Console.ReadLine()) * 1000;
            var currTeam = Console.ReadLine();
            var currmoney = cargo * 1.5m - 0.7m * distance * 2.5m;

            if (!dict.ContainsKey(currTeam))
            {
                dict[currTeam] = 0;
            }
            dict[currTeam] += currmoney;
        }

        private static void PrintMostEarnedTeam()
        {
            Console.WriteLine(dict
                        .OrderByDescending(x => x.Value)
                        .Select(x => string.Format($"The {x.Key} Trainers win with ${x.Value:F3}."))
                        .First());
        }
    }
}
