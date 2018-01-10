namespace _01.Centuries_to_Minutes
{
    using System;


    public class Problem1
    {

        public static void Main()
        {
            var years = byte.Parse(Console.ReadLine());
            //(convert years into days, hours, min)

            int days = years * 365;
            int hours = days * 24;
            int min = hours * 60;

            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.",
                 years, days, hours, min);

           

        }
    }
}
