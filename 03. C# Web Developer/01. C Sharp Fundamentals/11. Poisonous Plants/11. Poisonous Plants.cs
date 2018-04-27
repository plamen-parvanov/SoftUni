namespace _11.Poisonous_Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem11
    {
        public static void Main()
        {
            var plantsNum = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(plants);
            var alivePlants = new Queue<int>(stack);
            var days = 0;
            var hasDied = true;

            while (true)
            {
                hasDied = false; 
                var count = alivePlants.Count;
                for (int i = 0; i < count -1; i++)
                {
                    var currPlantPest = alivePlants.Dequeue();
                    var prevPlantPest = alivePlants.Peek();

                    if (currPlantPest <= prevPlantPest)
                    {
                        alivePlants.Enqueue(currPlantPest);
                    }
                    else
                    {
                        hasDied = true;
                    }
                }

                alivePlants.Enqueue(alivePlants.Dequeue());

                if (!hasDied)
                {
                    break;
                }

                days++;
            }

            Console.WriteLine(days);
        }
    }
}
