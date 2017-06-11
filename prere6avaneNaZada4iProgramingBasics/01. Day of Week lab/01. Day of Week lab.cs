namespace _01.Day_of_Week_lab
{
    using System;


    class Arrays
    {
        static void Main()
        {
            var daysOfWeekArr = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            try
            {
                var dayOfWeek = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine(daysOfWeekArr[dayOfWeek]);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Day!"); ;
            }

        }
    }
}
