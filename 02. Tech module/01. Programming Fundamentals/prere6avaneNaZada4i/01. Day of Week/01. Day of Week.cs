using System;


namespace _01.Day_of_Week
{
    class Program
    {
        static void Main()
        {
            string[] dayOfWeek = new string[7];
            dayOfWeek[0] = "Monday";
            dayOfWeek[1] = "Tuesday";
            dayOfWeek[2] = "Wednesday";
            dayOfWeek[3] = "Thursday";
            dayOfWeek[4] = "Friday";
            dayOfWeek[5] = "Saturday";
            dayOfWeek[6] = "Sunday";

            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber > 0 && dayNumber < 8)
            {
                Console.WriteLine(dayOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}
