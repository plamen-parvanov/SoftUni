namespace _01.Max_Sequence_of_Equal_Elements_second_
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {

        public static void Main()
        {
            var numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bestStart = 0;
            int bestLength = 1;
            int currLength = 1;
            int currStart = 0;
           

            for (int i = 0; i < numList.Count - 1; i++)
            {
                if (numList[i] == numList[i + 1])
                {
                    currLength++;

                    if (currLength > bestLength)
                    {
                        bestStart = currStart;
                        bestLength = currLength;
                    }

                }
                else
                {
                    currStart = i + 1;
                    currLength = 1;
                }

            }

            for (int i = bestStart; i < bestLength + bestStart; i++)
            {
                Console.Write(numList[i] + " ");
            }
            Console.WriteLine();


        }
    }
}
