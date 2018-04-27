namespace _02.Entertrain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {
        public static List<int> wagons = new List<int>();
        public static void Main()
        {
            var power = int.Parse(Console.ReadLine());
          
            AddWagons(power);

            wagons.Reverse();
            wagons.Add(power);
            
            PrintResult();
        }

        private static void AddWagons(int power)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "All ofboard!")
                {
                    break;
                }

                wagons.Add(int.Parse(inputLine));

                if (wagons.Sum() > power)
                {
                    var average = wagons.Sum() / wagons.Count;
                    wagons.Remove(GetElementClosestTo(average));
                }
            }
        }

        private static int GetElementClosestTo(int average)
        {
            var diff = int.MaxValue;
            var element = -1;

            for (int i = 0; i < wagons.Count; i++)
            {
                var currDiff = Math.Abs(average - wagons[i]);
                if (currDiff < diff)
                {
                    diff = currDiff;
                    element = wagons[i];
                    if (diff == 0)
                    {
                        break;
                    }
                }
              
            }

            return element;
        }

        private static void PrintResult()
        {
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
