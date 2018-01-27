namespace _04.Ununion_Lists
{

    using System;
    using System.Collections.Generic;

    public class Problem04
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine();
            var originalList = InitializeIntList(firstLine);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currLine = Console.ReadLine();
                var currList = InitializeIntList(currLine);

                originalList = ManipulateOriginal(originalList, currList);

            }

            originalList.Sort();
            Console.WriteLine(string.Join(" ", originalList));
        }

        public static List<int> InitializeIntList(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();

            foreach (var str in inputArr)
            {
                list.Add(int.Parse(str));
            }

            return list;
        }

        public static List<int> ManipulateOriginal(List<int> originalList, List<int> currList)
        {
            var numsToAdd = new List<int>();

            foreach (var num in currList)
            {
                if (!originalList.Contains(num))
                {
                    numsToAdd.Add(num);
                }
                else
                {
                    originalList.RemoveAll(a => a == num);
                }
            }
            originalList.AddRange(numsToAdd);

            return originalList;
        }
    }
}
