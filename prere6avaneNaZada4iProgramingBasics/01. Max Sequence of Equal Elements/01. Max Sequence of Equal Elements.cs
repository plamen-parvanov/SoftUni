namespace _01.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Lists
    {

        public static void Main()
        {
            var numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCount = 1;
            int maxCountElement = numList[0];

            GetMaxSequenceOfEqualElem(numList, ref maxCount, ref maxCountElement);

            List<int> maxSeqEqualElem = AddingMaxSeqElementInList(maxCount, maxCountElement, numList);

            Console.WriteLine(string.Join(" ", maxSeqEqualElem));
        }

        public static void GetMaxSequenceOfEqualElem(List<int> numList, ref int maxCount, ref int maxCountElement)
        {
            int count = 1;

            for (int i = 0; i < numList.Count - 1; i++)
            {

                if (numList[i] == numList[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxCountElement = numList[i];
                    }
                }
                else
                {
                    count = 1;
                }

                
            }
        }

        public static List<int> AddingMaxSeqElementInList(int maxCount, int maxCountElement, List<int> numList)
        {
            var maxSeqEqualElem = new List<int>();

            for (int i = 0; i < maxCount; i++)
            {
                maxSeqEqualElem.Add(maxCountElement);
            }

            return maxSeqEqualElem;
        }
    }
}
