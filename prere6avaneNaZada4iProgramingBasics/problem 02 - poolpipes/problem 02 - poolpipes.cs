using System;


namespace problem_02___poolpipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolV = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double firstPipe = pipe1 * time;
            double secondPipe = pipe2 * time;
            double total = firstPipe + secondPipe;

            if (total <= poolV)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate(total * 100 / poolV), 
                    Math.Truncate(firstPipe * 100 / total), 
                    Math.Truncate(secondPipe * 100 / total));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                     time, total - poolV);
            }
        }
    }
}
