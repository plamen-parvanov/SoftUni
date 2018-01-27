namespace _01.Shoot_List_Elements
{

    using System;
    using System.Collections.Generic;

    public class Problem01
    {

        public static void Main()
        {
            var list = new List<int>();
            var lastRemovedEll = 0;

            while (true)
            {
                var inputLine = Console.ReadLine();             

                if (inputLine == "stop")
                {
                    break; 
                }
                else if (inputLine == "bang")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine(
                            $"nobody left to shoot! last one was {lastRemovedEll}");
                        return;
                    }

                    lastRemovedEll = GetFirstEllSmallerOrEqualToAverage(list);

                        list.Remove(lastRemovedEll);
                        Console.WriteLine($"shot {lastRemovedEll}");

                        DecrementEveryElementInList(list);
                   
                }
                else
                {
                    list.Insert(0, int.Parse(inputLine));
                }
            }

            if (list.Count > 0)
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", list));
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastRemovedEll}");
            }

        }

        public static int GetFirstEllSmallerOrEqualToAverage(List<int> list)
        {
            var average = GetAverage(list);
            var currEll = 0;

            for (int i = 0; i < list.Count; i++)
            {
                currEll = list[i];

                if (currEll <= average)
                {
                    break;
                }
            }

            return currEll;
        }

        public static double GetAverage(List<int> list)
        {
            var sum = 0d;

            foreach (var num in list)
            {
                sum += num;
            }

            return sum / list.Count;
        }

        public static void DecrementEveryElementInList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i]--;
            }

        }
    }
}
