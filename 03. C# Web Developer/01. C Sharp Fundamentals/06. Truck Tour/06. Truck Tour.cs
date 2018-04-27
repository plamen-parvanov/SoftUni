namespace _06.Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem06
    {
        public static void Main()
        {
            var pumpNum = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(pumpNum);
            var tank = 0;

            for (int i = 0; i < pumpNum; i++)
            {
                queue.Enqueue(Console.ReadLine());
            }

            for (int i = 0; i < pumpNum; i++)
            {
                if (CanCompleteTheCircle(queue, tank, ref i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        private static bool CanCompleteTheCircle(Queue<string> queue, int tank, ref int startIndex)
        {
            for (int i = 0; i < queue.Count; i++)
            {
                var curr = queue.Dequeue();
                queue.Enqueue(curr);
                var arr = curr
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                tank += arr[0];
                var distance = arr[1];

                if (tank < distance)
                {
                    startIndex += i;
                    return false;
                }
                else
                {
                    tank -= distance;
                }
            }

            return true;
        }
    }
}
