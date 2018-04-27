namespace _03.Back_in_30_Minutes
{

    using System;


    public class Problem03
    {
        public static void Main()
        {

            var hours = short.Parse(Console.ReadLine());
            var mins = short.Parse(Console.ReadLine());

            var timeInMins = hours * 60 + mins;
            var timeAfter30mins = timeInMins + 30;

            Console.WriteLine($"{timeAfter30mins / 60 % 24}:{timeAfter30mins % 60 :d2}");

        }
    }
}
