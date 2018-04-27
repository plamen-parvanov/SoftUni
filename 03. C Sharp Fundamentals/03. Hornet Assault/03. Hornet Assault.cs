namespace _03.Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem03
    {
        public static long[] beehives;
        public static List<long> hornets;
        public static void Main()
        {
            beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            HornetsAttacks();

            PrintResult();
        }

        private static void HornetsAttacks()
        {
            for (int i = 0; i < beehives.Length; i++)
            {

                if (hornets.Count == 0)
                {
                    break;
                }
                var hornetsPower = hornets.Sum();

                if (beehives[i] < hornetsPower)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= hornetsPower;
                    hornets.RemoveAt(0);
                }
            }

        }

        private static void PrintResult()
        {
            if (beehives.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
