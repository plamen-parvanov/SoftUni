namespace _01.Wardrobe
{

    using System;
    using System.Collections.Generic;

    public class Problem01
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var wardrobeDict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var currInputLine = Console.ReadLine();
                AddingClothes(wardrobeDict, currInputLine);
            }

            var itemToFind = Console.ReadLine();

            PrintAllItemsAndIfItemFound(itemToFind, wardrobeDict);
        }

        public static void AddingClothes(Dictionary<string, Dictionary<string, int>> dict, string input)
        {
            var inputArr = input.Split(new[] { " -> "}, StringSplitOptions.RemoveEmptyEntries);
            var color = inputArr[0];
            var clothesArr = inputArr[1].Split(new[] { ',' },StringSplitOptions.RemoveEmptyEntries);

            if (!dict.ContainsKey(color))
            {
                dict[color] = new Dictionary<string, int>();
            }

            foreach (var item in clothesArr)
            {
                if (!dict[color].ContainsKey(item))
                {
                    dict[color][item] = 0;
                }

                dict[color][item]++;
            }
        }

        public static void PrintAllItemsAndIfItemFound(
            string itemToFind, Dictionary<string, Dictionary<string, int>> dict)
        {
            var itemArr = itemToFind.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var colorSearch = itemArr[0];
            var itemSearch = itemArr[1];

            foreach (var kvp in dict)
            {
                var color = kvp.Key;
                Console.WriteLine($"{color} clothes:");

                foreach (var itemAndCount in kvp.Value)
                {
                    Console.Write($"* {itemAndCount.Key} - {itemAndCount.Value}");

                    if (colorSearch == color && itemSearch == itemAndCount.Key)
                    {
                        Console.Write($" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
