using System;

namespace test_enum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var seasons = Enum.GetValues(typeof(Season));

            foreach (var season in seasons)
            {
                Console.WriteLine($"Season: {season} with value: {(int)season}");
            }

            Console.WriteLine("-----------------------");

            var seasonNames = Enum.GetNames(typeof(Season));
            
            foreach (var season in seasons)
            {
                Console.WriteLine($"Season: {season} with value: {(int)season}");
            }

            Console.WriteLine("---------------------");

            var day = Season.Spring;

            if (day == 0)
            {
                Console.WriteLine("true");
            }
        }
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
}
