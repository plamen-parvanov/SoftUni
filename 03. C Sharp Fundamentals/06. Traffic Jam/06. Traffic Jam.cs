namespace _06.Traffic_Jam
{
    using System;
    using System.Collections.Generic;

    public class Problem05
    {
        public static void Main()
        {
            var pass = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var passedCntr = 0;

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                else if (inputLine == "green")
                {
                    var lenght = Math.Min(pass, queue.Count);

                    for (int i = 0; i < lenght; i++)
                    {
                        var currCar = queue.Dequeue();
                        Console.WriteLine($"{currCar} passed!");
                        passedCntr++;
                    }
                }
                else
                {
                    queue.Enqueue(inputLine);
                }
            }

            Console.WriteLine($"{passedCntr} cars passed the crossroads.");
        }
    }
}
