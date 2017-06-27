using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace probi
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<double> { 4, 5, 6 };

            list = list.OrderByDescending(n => n).ToList();

            Console.WriteLine(string.Join("-", list));





            var date1 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
           
            //  var date2 = DateTime.ParseExact(Console.ReadLine(), "dd-MM", CultureInfo.InvariantCulture);

            //var equals = date1.DayOfYear == date2.DayOfYear ? "Yes" : "No";

            var dayOfWeek = date1.DayOfWeek.Equals(DayOfWeek.Saturday) ? "Yes" : "No";

            Console.WriteLine(dayOfWeek);

            //var date3 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InstalledUICulture);
            //Console.WriteLine(date3);



        }



    }
}
