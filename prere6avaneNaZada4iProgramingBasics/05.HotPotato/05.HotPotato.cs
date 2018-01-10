namespace _05.HotPotato
{

    using System;
    using System.Collections.Generic;

    public class StacksAndQueues
    {

        public static void Main()
        {
            var children = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var queue = new Queue<string>(children);

            var toss = int.Parse(Console.ReadLine());


            while (queue.Count > 1)
            {
                for (int i = 0; i < (toss - 1) % queue.Count; i++)
                {
                    var temp = queue.Dequeue();
                    queue.Enqueue(temp);
                }

                var removed = queue.Dequeue();

                Console.WriteLine($"Removed {removed}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
