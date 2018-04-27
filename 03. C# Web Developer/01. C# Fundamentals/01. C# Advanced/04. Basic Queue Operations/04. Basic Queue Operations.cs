namespace _04.Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var nums = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var ellToPush = inputLine[0];
            var ellToDelete = inputLine[1];
            var ellToFind = inputLine[2];
            var queue = new Queue<int>(ellToPush);

            for (int i = 0; i < ellToPush; i++)
            {
                queue.Enqueue(nums[i]);
            }

            for (int i = 0; i < ellToDelete; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(ellToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
            
        }
    }
}
