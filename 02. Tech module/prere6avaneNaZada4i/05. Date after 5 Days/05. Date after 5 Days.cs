using System;


namespace _05.Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int daysInMonth = 0;
            int dayPlus5 = day + 5;

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }
            if (dayPlus5 > daysInMonth)
            {
                month += 1;
                dayPlus5 -= daysInMonth;
            }
            if (month > 12)
            {
                month -= 12;
            }
            Console.WriteLine("{0}.{1:d2}", dayPlus5, month);
            
        }
    }
}
