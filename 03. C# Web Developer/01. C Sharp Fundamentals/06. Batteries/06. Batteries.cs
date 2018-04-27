namespace _06.Batteries
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem06
    {

        public static void Main()
        {
            var capacity = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var usagePerHour = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var testHours = int.Parse(Console.ReadLine());

            for (int i = 0; i < capacity.Length; i++)
            {
                var currCapacity = capacity[i];
                var currUsage = usagePerHour[i];
                var hourWorked = currCapacity / currUsage;

                if (hourWorked >= testHours)
                {
                    var remainig = currCapacity - (currUsage * testHours);
                    var remInPerc = remainig / currCapacity * 100;
                    Console.WriteLine($"Battery {i + 1}: {remainig:f2} mAh ({remInPerc:f2})%");
                }
                else
                {
                    var surviveHours = Math.Ceiling(currCapacity / currUsage);
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {surviveHours} hours)");
                } 
            }
            
        }
    }
}
