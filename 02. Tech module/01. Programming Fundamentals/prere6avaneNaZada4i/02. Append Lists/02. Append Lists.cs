namespace _02.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Lists
    {

        public static void Main()
        {
            var inputList = Console.ReadLine().Split('|').ToList();

            inputList.Reverse();

            var numbList = new List<int>();

            foreach (var strList in inputList)
            {
                List<string> splitedList = strList.Split().ToList();

                RemoveEmptyStrings(numbList, splitedList);
            }

            Console.WriteLine(string.Join(" ", numbList));

        }

        public static void RemoveEmptyStrings(List<int> numbList, List<string> splitedList)
        {
            foreach (var number in splitedList)
            {
                if (number != string.Empty)
                {
                    numbList.Add(int.Parse(number));
                }
            }
        }


    }
}
