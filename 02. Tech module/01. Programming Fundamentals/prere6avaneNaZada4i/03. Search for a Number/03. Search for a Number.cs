namespace _03.Search_for_a_Number
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
  
    public class Lists
    {

        public static void Main()
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var resultList = ManipulateList(inputList, arr);

            int elemToFind = arr[2];
            bool containsElement = resultList.Contains(elemToFind);

            if (containsElement)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }

        public static List<int> ManipulateList(List<int> list, int[] arr)
        {
            var result = new List<int>();
            int numsToTake = arr[0];
            int elemToDelete = arr[1];
            
            for (int i = 0; i < numsToTake; i++)
            {
                result.Add(list[i]);
            }

            for (int i = 0; i < elemToDelete; i++)
            {
                result.RemoveAt(0);
            }

            return result;
        }
    }
}
