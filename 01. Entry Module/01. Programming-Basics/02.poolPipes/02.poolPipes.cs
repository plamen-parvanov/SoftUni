using System;


namespace _02.poolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

            var firstPipe = H * P1;
            var secondPipe = H * P2;
            var total = firstPipe + secondPipe;

            if (total <= V)
            {
                var totalPercentage = total * 100 / V;
                var firstPipePercentage = firstPipe * 100 / total;
                var secondPipePercentage = secondPipe * 100 / total;

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate(totalPercentage), Math.Truncate(firstPipePercentage), 
                    Math.Truncate(secondPipePercentage));
            }

            else 
            {
                var overflows = total - V;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, overflows);
            }
        }
    }
}
