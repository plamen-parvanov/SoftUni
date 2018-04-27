namespace _02.Crypto_Master
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {
        private static Queue<short> input;
        public static void Main()
        {
            input = ReadSequense();

            var result = FindLongestIncSeq();

            Console.WriteLine(result);
        }

        private static short FindLongestIncSeq()
        {
            short longestSeq = 0;

            for (short startPosition = 0; startPosition < input.Count; startPosition++)
            {
                var currBestSeq = FindSequenceLengthFromStartPosition();

                input.Enqueue(input.Dequeue());

                if (currBestSeq > longestSeq)
                {
                    longestSeq = currBestSeq;
                }
            }

            return longestSeq;
        }

        private static short FindSequenceLengthFromStartPosition()
        {
            short biggest = 0;
            for (short step = 1; step < input.Count; step++)
            {
                var curr =  ClaculateSeqWith(step);

                if (curr > biggest)
                {
                    biggest = curr;
                }
            }

            return biggest;
        }

        private static short ClaculateSeqWith(short step)
        {
            short biggest = 1;
            var numbersPoped = new Queue<short>();
            var queue = new Queue<short>(input);

            while (true)
            {
                var currNum = queue.Dequeue();
                queue.Enqueue(currNum);

                numbersPoped.Enqueue(currNum);

                for (short i = 1; i < step; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                var nextNum = queue.Peek();

                if (numbersPoped.Contains(nextNum))
                {
                    break;
                }

                if (nextNum > currNum)
                {
                    biggest++;
                }
                else
                {
                    break;
                }
            }

            return biggest;
        }

        private static Queue<short> ReadSequense()
        {
            return new Queue<short> (Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(short.Parse)
                .ToArray());
        }
    }
}
