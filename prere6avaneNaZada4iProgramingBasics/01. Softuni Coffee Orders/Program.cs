namespace _01.Softuni_Coffee_Orders
{
    using System;
    using System.Globalization;


    public class ExamPreparationIII
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var total = 0m;

            for (int i = 0; i < n; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var daysInMonth = GetDaysInMonth();
                var count = int.Parse(Console.ReadLine());
               
                var coffePrice = price * daysInMonth * count;
                Console.WriteLine($"The price for the coffee is: ${coffePrice:F2}");
                total += coffePrice;
            }

            Console.WriteLine($"Total: ${total:F2}");


        }

        public static byte GetDaysInMonth()
        {
            var date = DateTime.ParseExact(
                Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

            var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            return (byte)daysInMonth;      
        
        }
}
}
