namespace _01.Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {

        public static void Main()
        {
            var numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var positiveNumList = RemoveNegativeNumbs(numberList);

            PrintReversedList(positiveNumList);



        }

        public static List<int> RemoveNegativeNumbs(List<int> numList)
        {
            var positiveList = new List<int>();

            foreach (var number in numList)
            {
                if (number >= 0)
                {
                    positiveList.Add(number);
                }
            }

            return positiveList;


        }






        //    var numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    numberList.RemoveAll(x => x < 0);

        //    PrintReversedList(numberList);

        //}

        public static void PrintReversedList(List<int> numberList)
        {
            if (numberList.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numberList.Reverse();

                Console.WriteLine(string.Join(" ", numberList));
            }
        }

    }
}
