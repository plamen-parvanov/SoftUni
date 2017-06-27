namespace _01.Day_of_Week_obj
{
    using System;
    using System.Globalization;


    public class ObjectsAndClasses
    {

        public static void Main()
        {
            var inputDate = Console.ReadLine();
            var date = DateTime.ParseExact(inputDate, 
                "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
