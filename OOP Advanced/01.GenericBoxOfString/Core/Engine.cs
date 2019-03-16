namespace _01.GenericBoxOfString.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public class Engine
    {
      public void Run()
        {
            IList<Box<double>> list = new List<Box<double>>();

            AddingItemsToList(list);

            var box = new Box<double>(double.Parse(Console.ReadLine()));

            Console.WriteLine(CountGreaterElement(list, box));

            //SwapPositionsInList(list);

            //PrintList(list);
        }

        private void PrintList(IList<Box<string>> list)
        {
            foreach (var box in list)
            {
                Console.WriteLine(box);
            }
        }

        private void SwapPositionsInList(IList<Box<int>> list)
        {
            var input = Console.ReadLine();
            var indexes = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            var firstIndex = indexes[0];
            var secondIndex = indexes[1];

            var tempBox = list[firstIndex];

            list[firstIndex] = list[secondIndex];
            list[secondIndex] = tempBox;
        }       

        private void AddingItemsToList(IList<Box<double>> list)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var value = double.Parse(Console.ReadLine());

                var currentBox = new Box<double>(value);

                list.Add(currentBox);
            }
        }

        private int CountGreaterElement(IList<Box<double>> list, Box<double> box)
        {
            // var result = list.Where(b => b.CompareTo(box) > 0).Count();

            var result = list.Count(b => b.CompareTo(box) > 0);

            return result;
        }
    }
}
