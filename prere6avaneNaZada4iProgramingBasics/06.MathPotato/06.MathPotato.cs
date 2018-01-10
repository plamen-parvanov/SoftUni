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
            var cntr = 1;
            var toss = int.Parse(Console.ReadLine());



            while (queue.Count > 1)
            {
                for (int i = 0; i < (toss - 1) % queue.Count; i++)
                {
                    var temp = queue.Dequeue();
                    queue.Enqueue(temp);
                }
                var isPrime = PrimeCheck(cntr);

                if (!isPrime)
                {
                    var removed = queue.Dequeue();

                    Console.WriteLine($"Removed {removed}");
                }
                else
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }

                cntr++;

            }

            Console.WriteLine($"Last is {queue.Dequeue()}");

        }

        public static bool PrimeCheck(int cntr)
        {
            var isPrime = true;

            for (int i = 2; i < cntr; i++)
            {
                if (cntr % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }

            if (cntr < 2)
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
