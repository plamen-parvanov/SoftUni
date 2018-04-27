namespace _01._Crossroads
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {
        private static Queue<string> queue;
        private static int passed;

        public static void Main()
        {
            var greenTime = int.Parse(Console.ReadLine());
            var freePassTime = int.Parse(Console.ReadLine());
            queue = new Queue<string>();
            passed = 0;

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{passed} total cars passed the crossroads.");
                    break;
                }
                else if (inputLine == "green")
                {
                    StartMoving(greenTime, freePassTime);
                }
                else
                {
                    queue.Enqueue(inputLine);
                }
            }
        }

        private static void StartMoving(int greenTime, int freePassTime)
        {
            while (queue.Count > 0 && greenTime > 0)
            {
                var car = queue.Dequeue();
                var carLeft = string.Join("", car.Skip(greenTime));
                greenTime -= car.Length;

                if (carLeft.Length > 0)
                {
                    carLeft = string.Join("", carLeft.Skip(freePassTime));
                    if (carLeft.Length > 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{car} was hit at {carLeft[0]}.");
                        System.Environment.Exit(1);
                    }
                }

                passed++;
            }
        }
    }
}
