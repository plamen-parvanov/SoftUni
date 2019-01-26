using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var diffInDays = DataModifier.CalculatesDifference(firstDate, secondDate);

            Console.WriteLine(diffInDays);
        }

        

        
    }
}
