namespace _05.Sequence_With_Queue
{
    using System;
    using System.Collections.Generic;

    public class Problem05
    {
        private static Queue<long> result;
        public static void Main()
        {
            CalculateSequenceWithQueue();

            PrintResult();

        }

        private static void CalculateSequenceWithQueue()
        {
            result = new Queue<long>(50);
            var n = long.Parse(Console.ReadLine());
            var tempQueue = new Queue<long>();
            result.Enqueue(n);
            tempQueue.Enqueue(n);

            for (int i = 1; i < 50; i += 3)
            {
                var first = tempQueue.Dequeue();
                var second = first + 1;
                var third = 2 * first + 1;
                var forth = first + 2;

                result.Enqueue(second);
                result.Enqueue(third);
                result.Enqueue(forth);

                tempQueue.Enqueue(second);
                tempQueue.Enqueue(third);
                tempQueue.Enqueue(forth);

            }
        }

        private static void PrintResult()
        {
            for (int i = 0; i < 49; i++)
            {
                Console.Write(result.Dequeue() + " ");
            }

            Console.WriteLine(result.Dequeue());
        }
    }
}
